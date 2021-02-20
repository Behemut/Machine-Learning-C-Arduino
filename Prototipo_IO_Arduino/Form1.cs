using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;


using Microsoft.ML.Data;
using Timer = System.Threading.Timer;
using System.IO;

namespace Prototipo_IO_Arduino
{
    public partial class Form1 : MetroFramework.Forms.MetroForm 
    {

        Prediccion_Invernadero obj_Prediccion = new Prediccion_Invernadero();
        Arduino arduino = new Arduino();

        CCola Resultados_cola = new CCola();
        CCola Exportacion_cola = new CCola();

        DateTime varInicio;

     //Valores de temperatura y humedad mostrados en el formulario pero a la vez funcionan para enviarlo al metodo para el analisis de la informacion
        float temperatura_formulario;
        float humedad_formulario;
        int ContadorDatos;
        int contador = 0;
        string Resultado_Tarea;


        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Timers.Timer timer = new System.Timers.Timer();
            ////timer.Interval = 300000; //5 minutos
            //timer.Interval = 240000;  //4 minutos
            ////timer.Interval = 60000;  //1 minuto
            //    timer.Elapsed += timer_Elapsed;
            //    timer.Start();
            chartHumedad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;

        }

        public Form1()
        {
            InitializeComponent();
            //Iniciar el programa se lee los puertos de Arduino que estan disponibles
            arduino.PuertosDisponibles(metrocmbPuertos);
        }

        private delegate void LineReceiveEvent(string puerto);

        private void puerto_DataRecibida(object sender, SerialDataReceivedEventArgs e)
        {
            string line = arduino.Puerto.ReadLine();
            this.BeginInvoke(new LineReceiveEvent(LineasRecibidas), line);
        }
        private void LineasRecibidas(string line)
        {
            MostrarValores(line);
        }

        //Funcion que muestra los valores extraidos por medio de la comunicacion serial con Arduino donde los '|' son los separadores de informacion
        public void MostrarValores(string datos)
        {
            try
            {

                chartTemperatura.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                
                string[] valores = datos.Split('|');
                foreach (string word in valores)
                {
                    
                    //Los textbox con la informacion que vera el usuario
                    txtTemperatura.Text= (valores[0] + "C°");
                    txtHumedad.Text = (valores[1]+"%");

                    //Contador para llevar en el Eje X para los charts y sus graficas de tiempo real 
                    ContadorDatos++;
                    var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    culture.NumberFormat.NumberDecimalSeparator = ".";
                    
                   temperatura_formulario = float.Parse(valores[0].ToString(), culture);
                   humedad_formulario = float.Parse(valores[1].ToString(), culture);

                    if (ContadorDatos > 0 && temperatura_formulario < 50  )
                    {
                        chartTemperatura.Series[0].Points.AddXY(ContadorDatos, temperatura_formulario );
                        chartHumedad.Series[0].Points.AddXY(ContadorDatos, humedad_formulario);
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (!arduino.Conexion)
                {
                    arduino.conectarArduino(metrocmbPuertos, button1);
                    arduino.Puerto.DataReceived += puerto_DataRecibida;
                   
                    timerEncolador.Enabled = true;
                    timerActualizacion.Enabled = true;
                    timerDesencolar.Enabled = true;
                    varInicio = DateTime.Now;
                }
                else
                {
                    arduino.desconectarArduino(button1);
                    timerActualizacion.Enabled = false;
                    timerEncolador.Enabled = false;
                    timerDesencolar.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           arduino.Puerto.DataReceived += puerto_DataRecibida;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //   Resultados_cola.Mostrar(lstSalidaPrediccion);
        }

        private async void timerEncolador_Tick(object sender, EventArgs e)
        {
            var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            obj_Prediccion.Temperatura_actual = temperatura_formulario;
            obj_Prediccion.Humedad_rel = humedad_formulario;

            //Tarea asincrona en base a un metodo del tipo String que devuelve un valor de ese tipo que es la Prediccion
            Task<string> Tarea_Prediccion = new Task<string>(obj_Prediccion.Resultado_Prediccion);
            Tarea_Prediccion.Start();
            //Tarea inicia

            //await indica que espera la tarea a finalizar antes de asignarle el valor a la variable
            Resultado_Tarea = await Tarea_Prediccion;

            try
            {
                contador++;
                Resultados_cola.Encolar(temperatura_formulario, humedad_formulario, Resultado_Tarea, DateTime.Now, contador);
                Resultados_cola.Mostrar(lstSalidaPrediccion);

                //Desencolar objetos si la lista se esta acumulando mas de predicciones
                if (lstSalidaPrediccion.Items.Count >= 2)
                {
                    Resultados_cola.Desencolar();
                    Iconos_Estados();
                }
                  

                Exportacion_cola.Encolar(temperatura_formulario, humedad_formulario, Resultado_Tarea, DateTime.Now, contador);
                Exportacion_cola.Mostrar(lstExportados);
                Iconos_Estados();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerDesencolar_Tick(object sender, EventArgs e)
        {
             Resultados_cola.Desencolar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ruta = new FolderBrowserDialog();    
            if (ruta.ShowDialog() == DialogResult.OK)
            {
                string var;

                var = DateTime.Now.Day.ToString()+ "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString();

                string sPath = ("Exportación-" + var + ".txt");
                using (StreamWriter writer = new StreamWriter(ruta.SelectedPath + "\\" + sPath, true))
                {
                    writer.WriteLine("Archivo creado con los datos recolectados del programa de monitoreo del Invernadero que inició el  " + varInicio.ToString());
                    foreach (var item in lstExportados.Items)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }

        private void gbValores_Enter(object sender, EventArgs e)
        {

        }

        private void timerActualizacion_Tick(object sender, EventArgs e)
        {

            Iconos_Estados();
        }

        public void Iconos_Estados()
        {
            if (Resultados_cola.Primero() == "Temperatura alta y ambiente seco")
            {
                pbEstados.Image = Properties.Resources.Desert_512;
                lblMensaje.Text = "Ambiente de sequía en el invernadero";

                this.Refresh();
            }
            else if (Resultados_cola.Primero() == "Temperatura ideal y humedad ideal")
            {
                pbEstados.Image = Properties.Resources.tree_green_natural_512;
                lblMensaje.Text = "Condiciones ideales en el invernadero";

                this.Refresh();
            }
            else if (Resultados_cola.Primero() == "Temperatura normal, humedad relativa alta" || Resultados_cola.Primero() == "Temperatura normal, humedad extrema")
            {
                pbEstados.Image = Properties.Resources.humidity_forecast_hydration_precipitation_temperature_weather_38924;
                lblMensaje.Text = "Temperatura estable con humedad alta";

                this.Refresh();
            }
            else
            {
                pbEstados.Image = null;
                lblMensaje.Text = "";

                this.Refresh();
            }
        }
    }
}

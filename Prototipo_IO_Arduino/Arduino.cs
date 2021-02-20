using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using MetroFramework.Controls;

namespace Prototipo_IO_Arduino
{
    class Arduino
    {
        private bool conexion = false;
        private String[] puertos;
        private SerialPort puerto;

        public bool Conexion { get => conexion; set => conexion = value; }
        public string[] Puertos { get => puertos; set => puertos = value; }
        public SerialPort Puerto { get => puerto; set => puerto = value; }


        public void PuertosDisponibles(MetroComboBox combo)
        {
            puertos = SerialPort.GetPortNames();

            foreach (string puerto in puertos)
            {
                combo.Items.Add(puerto);
                if (puertos[0] != null)
                {
                    combo.SelectedItem = puerto[0];
                }
            }
        }


        public void conectarArduino(MetroComboBox seleccion, Button boton)
        {
            try
            {
                conexion = true;
            string selectedPort = seleccion.GetItemText(seleccion.SelectedItem);
            puerto = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            puerto.Open();
            puerto.Write("#STAR\n");
            boton.Text = "Desconectar arduino";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
       
            }
        }


        public void desconectarArduino(Button boton)
        {
            conexion = false;
            puerto.Write("#STOP\n");
            puerto.Close();
            boton.Text = "Conectar arduino";

        }

    }
}

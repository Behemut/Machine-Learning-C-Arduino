using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_IO_Arduino
{
    class CCola
    {

        public Nodo primero;
        public Nodo ultimo;

        public CCola(){primero = ultimo = null;}

       public void Encolar(float temp, float hum, string est, DateTime fecha_registro, int info){
            Nodo aux = new Nodo();
            aux.temperatura = temp;
            aux.humedad = hum;
            aux.estado = est;
            aux.fecha = fecha_registro;
            aux.contador = info;

            if (primero == null)
            {
                primero = ultimo = aux;
                aux.siguiente = null;
                
            }
            else
            {
                ultimo.siguiente = aux;
                aux.siguiente = null;
                ultimo = aux;
           
            }
        }

        public void Mostrar(ListBox imprimir){
            imprimir.Items.Clear();
            if (primero != null)
            {
                Nodo puntero;
                puntero = primero;
                imprimir.Items.Add(puntero.temperatura + "C° " + puntero.humedad + "%  " + puntero.estado + "   " + puntero.fecha);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    imprimir.Items.Add(puntero.temperatura + "C° " + puntero.humedad + "%  " + puntero.estado + "   " + puntero.fecha);
                }
            }
        }

        public void Desencolar()
        {
            if (primero !=null)
                primero = primero.siguiente;
        }

        public string Primero()
        {
            string PrimerValor;

            PrimerValor = "";
            if (primero != null)
            {
                Nodo puntero;
                puntero = primero;
                PrimerValor = primero.estado;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
               
                }
                return PrimerValor;
            }
            return PrimerValor;
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_IO_Arduino
{
    public class Nodo
    {
        //Valores que tomara para guardar en la cola
        public DateTime fecha;
        public float temperatura;
        public float humedad;
        public string estado;
        public int contador;
        public Nodo siguiente = null;
    }
}

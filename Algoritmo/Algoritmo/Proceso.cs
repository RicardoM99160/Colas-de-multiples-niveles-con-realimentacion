using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    class Proceso
    {
        public int Prioridad;
        public int TiempoDeEjecucion;
        public bool Estado=false;
        //RICARDOOOO
       public void ActualizarEstado()
        {
            if (TiempoDeEjecucion<=0)
            {
                Estado = true;
            }
        }
    }
}

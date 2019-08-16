using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    class Proceso
    {
        public int P = 0;
        public int TE = 0;
        public bool E = false;

        public Proceso(int Prioridad, int TiempoEjecucion, bool Estado)
        {
            P = Prioridad;
            TE = TiempoEjecucion;
            E = Estado;
        }
       public void ActualizarEstado()
        {
            if (TE<=0)
            {
                E = true;
            }
        }
    }
}

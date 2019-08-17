using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo
{
    public partial class Form1 : Form
    {
        //Creación de procesos
        Proceso[] procesos = new Proceso[5];
        Queue<Proceso> Cola0;
        Queue<Proceso> Cola1;
        Queue<Proceso> Cola2;
        Queue<Proceso> Cola3;
        Queue<Proceso> Cola4;
        Queue<Proceso> Cola5;

        public Form1()
        {
            //Creación de procesos
            Random Aleatorio = new Random();
            for (int i = 0; i < procesos.Length; i++)
            {
                int prioridad = Aleatorio.Next(0, 5);
                int tiempo = Aleatorio.Next(1, 30);
                procesos[i] = new Proceso(prioridad, tiempo, true);
            }

            //Creacion de colas
            Cola0 = new Queue<Proceso>();
            Cola1 = new Queue<Proceso>();
            Cola2 = new Queue<Proceso>();
            Cola3 = new Queue<Proceso>();
            Cola4 = new Queue<Proceso>();
            Cola5 = new Queue<Proceso>();

            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Proceso[] AsignacionCola(Proceso[] prcs)
        {
            foreach (Proceso proceso in prcs)
            {
                if (proceso.P == 0)
                {
                    Cola0.Enqueue(proceso);
                }
                else if (proceso.P == 1)
                {
                    Cola1.Enqueue(proceso);
                }
                else if (proceso.P == 2)
                {
                    Cola2.Enqueue(proceso);
                }
                else if (proceso.P == 3)
                {
                    Cola3.Enqueue(proceso);
                }
                else if (proceso.P == 4)
                {
                    Cola4.Enqueue(proceso);
                }
                else if (proceso.P == 5)
                {
                    Cola5.Enqueue(proceso);
                }
            }
            return prcs;
        }

    }

}

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
        public Form1()
        {
            Proceso[] procesos = new Proceso[5];
            Random Aleatorio = new Random();
            for (int i = 0; i < procesos.Length; i++)
            {
                int prioridad = Aleatorio.Next(0, 5);
                int tiempo = Aleatorio.Next(1, 30);
                procesos[i] = new Proceso(prioridad, tiempo, true);
            }
            

            InitializeComponent();
 
            //Creacion de colas
            Queue<Proceso> Cola0 = new Queue<Proceso>();
            Queue<Proceso> Cola1 = new Queue<Proceso>();
            Queue<Proceso> Cola2 = new Queue<Proceso>();
            Queue<Proceso> Cola3 = new Queue<Proceso>();
            Queue<Proceso> Cola4 = new Queue<Proceso>();
            Queue<Proceso> Cola5 = new Queue<Proceso>();

            //Clasificación de procesos en sus respectivas colas
            //Clasificación proceso A:
            if (procesoA.P==0)
            {
                Cola0.Enqueue(procesoA);
            }
            else if (procesoA.P == 1)
            {
                Cola1.Enqueue(procesoA);
            }
            else if (procesoA.P == 2)
            {
                Cola2.Enqueue(procesoA);
            }
            else if (procesoA.P == 3)
            {
                Cola3.Enqueue(procesoA);
            }
            else if (procesoA.P == 4)
            {
                Cola4.Enqueue(procesoA);
            }
            else if (procesoA.P == 5)
            {
                Cola5.Enqueue(procesoA);
            }

            //Clasificación proceso B:
            if (procesoB.P == 0)
            {
                Cola0.Enqueue(procesoB);
            }
            else if (procesoB.P == 1)
            {
                Cola1.Enqueue(procesoB);
            }
            else if (procesoB.P == 2)
            {
                Cola2.Enqueue(procesoB);
            }
            else if (procesoB.P == 3)
            {
                Cola3.Enqueue(procesoB);
            }
            else if (procesoB.P == 4)
            {
                Cola4.Enqueue(procesoB);
            }
            else if (procesoB.P == 5)
            {
                Cola5.Enqueue(procesoB);
            }

            //Clasificación proceso C:
            if (procesoA.P == 0)
            {
                Cola0.Enqueue(procesoA);
            }
            else if (procesoA.P == 1)
            {
                Cola1.Enqueue(procesoA);
            }
            else if (procesoA.P == 2)
            {
                Cola2.Enqueue(procesoA);
            }
            else if (procesoA.P == 3)
            {
                Cola3.Enqueue(procesoA);
            }
            else if (procesoA.P == 4)
            {
                Cola4.Enqueue(procesoA);
            }
            else if (procesoA.P == 5)
            {
                Cola5.Enqueue(procesoA);
            }

            //Clasificación proceso A:
            if (procesoA.P == 0)
            {
                Cola0.Enqueue(procesoA);
            }
            else if (procesoA.P == 1)
            {
                Cola1.Enqueue(procesoA);
            }
            else if (procesoA.P == 2)
            {
                Cola2.Enqueue(procesoA);
            }
            else if (procesoA.P == 3)
            {
                Cola3.Enqueue(procesoA);
            }
            else if (procesoA.P == 4)
            {
                Cola4.Enqueue(procesoA);
            }
            else if (procesoA.P == 5)
            {
                Cola5.Enqueue(procesoA);
            }

            //Clasificación proceso A:
            if (procesoA.P == 0)
            {
                Cola0.Enqueue(procesoA);
            }
            else if (procesoA.P == 1)
            {
                Cola1.Enqueue(procesoA);
            }
            else if (procesoA.P == 2)
            {
                Cola2.Enqueue(procesoA);
            }
            else if (procesoA.P == 3)
            {
                Cola3.Enqueue(procesoA);
            }
            else if (procesoA.P == 4)
            {
                Cola4.Enqueue(procesoA);
            }
            else if (procesoA.P == 5)
            {
                Cola5.Enqueue(procesoA);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

}

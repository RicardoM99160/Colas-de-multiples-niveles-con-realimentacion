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

            Random Aleatorio = new Random();
            //Creación de proceso A
            int prioridad1 = Aleatorio.Next(0, 5);
            int tiempo1 = Aleatorio.Next(1, 30);
            Proceso procesoA = new Proceso(prioridad1, tiempo1, false);
            //Creación de proceso B
            int prioridad2 = Aleatorio.Next(0, 5);
            int tiempo2 = Aleatorio.Next(1, 30);
            Proceso procesoB = new Proceso(prioridad2, tiempo2, false);
            //Creación de proceso C
            int prioridad3 = Aleatorio.Next(0, 5);
            int tiempo3 = Aleatorio.Next(1, 30);
            Proceso procesoC = new Proceso(prioridad3, tiempo3, false);
            //Creación de proceso D
            int prioridad4 = Aleatorio.Next(0, 5);
            int tiempo4 = Aleatorio.Next(1, 30);
            Proceso procesoD = new Proceso(prioridad4, tiempo4, false);
            //Creación de proceso E
            int prioridad5 = Aleatorio.Next(0, 5);
            int tiempo5 = Aleatorio.Next(1, 30);
            Proceso procesoE = new Proceso(prioridad5, tiempo5, false);

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

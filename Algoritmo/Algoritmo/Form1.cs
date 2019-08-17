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
            //Creación de procesos
            Proceso[] procesos = new Proceso[5];
            Random Aleatorio = new Random();
            for (int i = 0; i < procesos.Length; i++)
            {
                int prioridad = Aleatorio.Next(0, 5);
                int tiempo = Aleatorio.Next(1, 30);
                procesos[i] = new Proceso(prioridad, tiempo, true);
            }

            //Creacion de colas
            Queue<Proceso> Cola0 = new Queue<Proceso>();
            Queue<Proceso> Cola1 = new Queue<Proceso>();
            Queue<Proceso> Cola2 = new Queue<Proceso>();
            Queue<Proceso> Cola3 = new Queue<Proceso>();
            Queue<Proceso> Cola4 = new Queue<Proceso>();
            Queue<Proceso> Cola5 = new Queue<Proceso>();

            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

}

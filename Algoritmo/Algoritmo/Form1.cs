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
            InitializeComponent();
            Proceso procesoA, procesoB, procesoC, procesoD, procesoE;

            //Creacion de colas
            Queue<Proceso> Cola0 = new Queue<Proceso>();
            Queue<Proceso> Cola1 = new Queue<Proceso>();
            Queue<Proceso> Cola2 = new Queue<Proceso>();
            Queue<Proceso> Cola3 = new Queue<Proceso>();
            Queue<Proceso> Cola4 = new Queue<Proceso>();
            Queue<Proceso> Cola5 = new Queue<Proceso>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

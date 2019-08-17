using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Algoritmo
{
    public partial class Form1 : Form
    {
        //Creación de procesos
        string nombres = "ABCDE";
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
                procesos[i] = new Proceso(prioridad, tiempo, false,nombres[i].ToString());
            }

            //Creacion de colas
            Cola0 = new Queue<Proceso>();
            Cola1 = new Queue<Proceso>();
            Cola2 = new Queue<Proceso>();
            Cola3 = new Queue<Proceso>();
            Cola4 = new Queue<Proceso>();
            Cola5 = new Queue<Proceso>();


            InitializeComponent();

            procesos = AsignacionCola(procesos);
            mostrarProcesos();

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

        //Mostrar los procesos en los datagrid
        private void mostrarProcesos()
        {

         /*   DataTable dt = (DataTable)Prioridad0dt.DataSource;
            dt.Clear();

            DataTable dt2 = (DataTable)Prioridad1dt.DataSource;
            dt2.Clear();

            DataTable dt3 = (DataTable)Prioridad2dt.DataSource;
            dt3.Clear();

            DataTable dt4 = (DataTable)Prioridad3dt.DataSource;
            dt4.Clear();

            DataTable dt5 = (DataTable)Prioridad4dt.DataSource;
            dt5.Clear();

            DataTable dt6 = (DataTable)Prioridad5dt.DataSource;
            dt6.Clear();

            Prioridad0dt.ClearSelection();*/
            foreach (Proceso item in Cola0)
            {
                Prioridad0dt.Rows.Add(item.nombre, item.TE);
            }
            foreach (Proceso item in Cola1)
            {
                Prioridad1dt.Rows.Add(item.nombre, item.TE);
            }
            foreach (Proceso item in Cola2)
            {
                Prioridad2dt.Rows.Add(item.nombre, item.TE);
            }
            foreach (Proceso item in Cola3)
            {
                Prioridad3dt.Rows.Add(item.nombre, item.TE);
            }
            foreach (Proceso item in Cola4)
            {
                Prioridad4dt.Rows.Add(item.nombre, item.TE);
            }
            foreach (Proceso item in Cola5)
            {
                Prioridad5dt.Rows.Add(item.nombre, item.TE);
            }
        }

        //Cambiar el color del estado del proceso
        private void MostrarProcesoAcabado(Proceso Pros)
        {
            if (Pros.nombre == "A" && Pros.E==true)
            {
                PanelA.BackColor = Color.Green;
            }
            if (Pros.nombre == "B" && Pros.E == true)
            {
                PanelB.BackColor = Color.Green;
            }
            if (Pros.nombre == "C" && Pros.E == true)
            {
                PanelC.BackColor = Color.Green;
            }
            if (Pros.nombre == "D" && Pros.E == true)
            {
                PanelD.BackColor = Color.Green;
            }
            if (Pros.nombre == "E" && Pros.E == true)
            {
                PanelE.BackColor = Color.Green;
            }

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            int terminado = 0; 
            do
            {
                //Prioridad 0
                foreach (Proceso item in Cola0)
                {

                    item.TE -= 1;
                    
                    if (item.TE>0)
                    {                      
                        Cola0.Dequeue();
                        Cola1.Enqueue(item);
                    }
                    else
                    {
                        Cola0.Dequeue();
                        terminado++;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    Thread.Sleep(5000);
                    if (Cola0==null)
                    {
                        break;
                    }
                }

                //Prioridad 1
                foreach (Proceso item in Cola1)
                {
                    item.TE -= 2;

                    if (item.TE > 0)
                    {
                        Cola2.Enqueue(Cola1.Dequeue());
                    }
                    else
                    {
                        Cola1.Dequeue();
                        terminado++;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    Thread.Sleep(5000);
                }

                //Prioridad 2
                foreach (Proceso item in Cola2)
                {
                    item.TE -= 4;

                    if (item.TE > 0)
                    {
                        Cola3.Enqueue(Cola2.Dequeue());
                    }
                    else
                    {
                        Cola2.Dequeue();
                        terminado++;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    Thread.Sleep(5000);
                }

                //Prioridad 3
                foreach (Proceso item in Cola3)
                {
                    item.TE -= 8;

                    if (item.TE > 0)
                    {
                        Cola4.Enqueue(Cola3.Dequeue());
                    }
                    else
                    {
                        Cola3.Dequeue();
                        terminado++;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    Thread.Sleep(5000);
                }

                //Prioridad 4
                foreach (Proceso item in Cola4)
                {
                    item.TE -= 16;

                    if (item.TE > 0)
                    {
                        Cola5.Enqueue(Cola4.Dequeue());
                    }
                    else
                    {
                        Cola4.Dequeue();
                        terminado++;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    Thread.Sleep(5000);
                }

                //Prioridad 5
                foreach (Proceso item in Cola0)
                {
                    item.TE -= 32;

                    if (item.TE > 0)
                    {
                        Cola5.Dequeue();
                        item.TE = 0;
                        terminado++;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    Thread.Sleep(5000);
                }

                

            }
            while (terminado<5);
        }
    }

}

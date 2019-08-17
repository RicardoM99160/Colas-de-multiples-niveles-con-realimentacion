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
        bool op = true;
        Proceso[] procesos = new Proceso[5];
        List<Proceso> Cola0 = new List<Proceso>();
        List<Proceso> Cola1 = new List<Proceso>();
        List<Proceso> Cola2 = new List<Proceso>();
        List<Proceso> Cola3 = new List<Proceso>();
        List<Proceso> Cola4 = new List<Proceso>();
        List<Proceso> Cola5 = new List<Proceso>();


        public Form1()
        {
            //Creación de procesos
            Random Aleatorio = new Random();
            for (int i = 0; i < procesos.Length; i++)
            {
                int prioridad = Aleatorio.Next(0, 6);
                int tiempo = Aleatorio.Next(1, 50);
                procesos[i] = new Proceso(prioridad, tiempo, false,nombres[i].ToString());
            }

           
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
                    Cola0.Add(proceso);
                }
                else if (proceso.P == 1)
                {
                    Cola1.Add(proceso);
                }
                else if (proceso.P == 2)
                {
                    Cola2.Add(proceso);
                }
                else if (proceso.P == 3)
                {
                    Cola3.Add(proceso);
                }
                else if (proceso.P == 4)
                {
                    Cola4.Add(proceso);
                }
                else if (proceso.P == 5)
                {
                    Cola5.Add(proceso);
                }
            }
            return prcs;
        }

        //Mostrar los procesos en los datagrid
        private void mostrarProcesos()
        {

            Prioridad0dt.Rows.Clear();
            Prioridad1dt.Rows.Clear();
            Prioridad2dt.Rows.Clear();
            Prioridad3dt.Rows.Clear();
            Prioridad4dt.Rows.Clear();
            Prioridad5dt.Rows.Clear();


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
            Cola0 = Cola0.OrderBy(x => x.TE).ToList();
            Cola1 = Cola1.OrderBy(x => x.TE).ToList();
            Cola2 = Cola2.OrderBy(x => x.TE).ToList();
            Cola3 = Cola3.OrderBy(x => x.TE).ToList();
            Cola4 = Cola4.OrderBy(x => x.TE).ToList();
            Cola5 = Cola5.OrderBy(x => x.TE).ToList();

            //Prioridad 0
            if (Cola0.Count!=0)
            {
                for (int i = 0; i < Cola0.Count; i++)
                {
                    Proceso item = Cola0[i];
                    item.TE -= 1;
                    if (item.TE > 0)
                    {
                        Cola0.Remove(item);
                        Cola1.Add(item);
                        i--;
                    }
                    else
                    {
                        item.ActualizarEstado();
                        Cola0.Remove(item);
                        i--;
                        op = true;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    break;
                }
            }


            //Prioridad 1
           else if (Cola0.Count==0 && Cola1.Count!=0)
            {
                for (int i = 0; i < Cola1.Count; i++)
                {
                    Proceso item = Cola1[i];
                    item.TE -= 2;
                    if (item.TE > 0)
                    {
                        Cola1.Remove(item);
                        Cola2.Add(item);
                        i--;
                    }
                    else
                    {
                        item.ActualizarEstado();
                        Cola1.Remove(item);
                        i--;
                        op = true;
                        
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    break;
                }
            }


            //Prioridad 2
          else  if (Cola1.Count==0 && Cola2.Count!=0)
            {
                for (int i = 0; i < Cola2.Count; i++)
                {
                    Proceso item = Cola2[i];
                    item.TE -= 4;
                    if (item.TE > 0)
                    {
                        Cola2.Remove(item);
                        Cola3.Add(item);
                        i--;
                    }
                    else
                    {
                        item.ActualizarEstado();
                        Cola2.Remove(item);
                        i--;
                        op = true;
                        
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    break;
                }
            }


            //Prioridad 3
           else if (Cola2.Count==0 && Cola3.Count!=0)
            {
                for (int i = 0; i < Cola3.Count; i++)
                {
                    Proceso item = Cola3[i];
                    item.TE -= 8;
                    if (item.TE > 0)
                    {
                        Cola3.Remove(item);
                        Cola4.Add(item);
                        i--;
                    }
                    else
                    {
                        item.ActualizarEstado();
                        Cola3.Remove(item);
                        i--;
                        op = true;
                        
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    break;
                }
            }


            //Prioridad 4
         else  if (Cola3.Count==0 && Cola4.Count!=0)
            {
                for (int i = 0; i < Cola4.Count; i++)
                {
                    Proceso item = Cola4[i];
                    item.TE -= 16;
                    if (item.TE > 0)
                    {
                        Cola4.Remove(item);
                        Cola5.Add(item);
                        i--;
                    }
                    else
                    {
                        item.ActualizarEstado();
                        Cola4.Remove(item);
                        i--;
                        op = true;
                        
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    break;
                }
            }


            //Prioridad 5
           else if (Cola4.Count==0 && Cola5.Count!=0)
            {
                for (int i = 0; i < Cola5.Count; i++)
                {
                    Proceso item = Cola5[i];
                    item.TE -= 32;

                    if (item.TE <= 0)
                    {
                        item.ActualizarEstado();
                        Cola5.Remove(item);
                        i--;
                        op = true;
                    }
                    MostrarProcesoAcabado(item);
                    mostrarProcesos();
                    break;
                }
            }


        }
    }

}

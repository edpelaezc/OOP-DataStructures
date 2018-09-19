using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstrcuturasDinamicas;

namespace HojaDeTrabajo1
{
    public partial class Form1 : Form
    {
        Cajero cajero1 = new Cajero();
        Cajero cajero2 = new Cajero();
        Cajero cajero3 = new Cajero();
        Cajero cajero4 = new Cajero();
        LinkedQueue<int> tiempoCajero = new LinkedQueue<int>();
        Random generador = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());                                
            }
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = "Cajero " + (i + 1).ToString();
            }

            dataGridView1.Columns[0].HeaderCell.Value = "No. Clientes";
            dataGridView1.Columns[1].HeaderCell.Value = "Tiempo Acumulado (segundos)";
            dataGridView1.Columns[2].HeaderCell.Value = "Promedio";
        }

        public static bool parsed(string _string)
        {
            int numValue;
            return int.TryParse(_string, out numValue);
        }

        private void ingresarClientes_Click(object sender, EventArgs e)
        {
            string cantidad = textBox1.Text;
            int num = 0;
            int sumatoria = 0;
            int elemento = 0;
            if (parsed(cantidad))
            {
                num = int.Parse(cantidad);
                for (int i = 0; i < num; i++)
                {
                    elemento = generador.Next(5, 11);
                    sumatoria += elemento;
                    tiempoCajero.enqueue(elemento);
                }

                if (tiempoCajero.size() > 4 && num > 0)
                {
                    //Asignación inicial, todos tienen un cliente.
                    cajero1.tiempoAtencion(tiempoCajero.dequeue());
                    cajero2.tiempoAtencion(tiempoCajero.dequeue());
                    cajero3.tiempoAtencion(tiempoCajero.dequeue());
                    cajero4.tiempoAtencion(tiempoCajero.dequeue());

                    //Mientras la cola tenga clientes los cajeros atenderan
                    //Aumentara el tiempo acumulado y el numero de clientes
                    while (!tiempoCajero.isEmpty())
                    {
                        for (int i = 0; i < sumatoria; i++)
                        {
                            cajero1.tiempo--;
                            cajero2.tiempo--;
                            cajero3.tiempo--;
                            cajero4.tiempo--;

                            if (cajero1.tiempo == 0)
                            {
                                cajero1.tiempoAtencion(tiempoCajero.dequeue());
                                cajero1.atender();
                            }
                            if (cajero2.tiempo == 0)
                            {
                                cajero2.tiempoAtencion(tiempoCajero.dequeue());
                                cajero2.atender();
                            }
                            if (cajero3.tiempo == 0)
                            {
                                cajero3.tiempoAtencion(tiempoCajero.dequeue());
                                cajero3.atender();
                            }
                            if (cajero4.tiempo == 0)
                            {
                                cajero4.tiempoAtencion(tiempoCajero.dequeue());
                                cajero4.atender();
                            }
                        }
                    }
                    //mostrar datos en gridview                        
                    //mostrar numero de clientes
                    dataGridView1.Rows[0].Cells[0].Value = cajero1.clientesAtendidos.ToString();
                    dataGridView1.Rows[1].Cells[0].Value = cajero2.clientesAtendidos.ToString();
                    dataGridView1.Rows[2].Cells[0].Value = cajero3.clientesAtendidos.ToString();
                    dataGridView1.Rows[3].Cells[0].Value = cajero4.clientesAtendidos.ToString();
                    //mostrar tiempo acumulado
                    dataGridView1.Rows[0].Cells[1].Value = cajero1.tiempoAcumulado.ToString();
                    dataGridView1.Rows[1].Cells[1].Value = cajero2.tiempoAcumulado.ToString();
                    dataGridView1.Rows[2].Cells[1].Value = cajero3.tiempoAcumulado.ToString();
                    dataGridView1.Rows[3].Cells[1].Value = cajero4.tiempoAcumulado.ToString();
                    //mostrar tiempo promedio en que atiende el cajero
                    if (cajero1.clientesAtendidos != 0 || cajero2.clientesAtendidos != 0 || cajero3.clientesAtendidos != 0 || cajero4.clientesAtendidos != 0)
                    {
                        dataGridView1.Rows[0].Cells[2].Value = (cajero1.tiempoAcumulado / cajero1.clientesAtendidos).ToString();
                        dataGridView1.Rows[1].Cells[2].Value = (cajero2.tiempoAcumulado / cajero2.clientesAtendidos).ToString();
                        dataGridView1.Rows[2].Cells[2].Value = (cajero3.tiempoAcumulado / cajero3.clientesAtendidos).ToString();
                        dataGridView1.Rows[3].Cells[2].Value = (cajero4.tiempoAcumulado / cajero4.clientesAtendidos).ToString();
                    }

                }
                else
                {
                    if (num == 4)
                    {
                        cajero1.tiempoAtencion(tiempoCajero.dequeue());
                        cajero2.tiempoAtencion(tiempoCajero.dequeue());
                        cajero3.tiempoAtencion(tiempoCajero.dequeue());
                        cajero4.tiempoAtencion(tiempoCajero.dequeue());
                        cajero1.atender();
                        cajero2.atender();
                        cajero3.atender();
                        cajero4.atender();
                        //mostrar datos en gridview                        
                        //mostrar numero de clientes
                        dataGridView1.Rows[0].Cells[0].Value = cajero1.clientesAtendidos.ToString();
                        dataGridView1.Rows[1].Cells[0].Value = cajero2.clientesAtendidos.ToString();
                        dataGridView1.Rows[2].Cells[0].Value = cajero3.clientesAtendidos.ToString();
                        dataGridView1.Rows[3].Cells[0].Value = cajero4.clientesAtendidos.ToString();
                        //mostrar tiempo acumulado
                        dataGridView1.Rows[0].Cells[1].Value = cajero1.tiempoAcumulado.ToString();
                        dataGridView1.Rows[1].Cells[1].Value = cajero2.tiempoAcumulado.ToString();
                        dataGridView1.Rows[2].Cells[1].Value = cajero3.tiempoAcumulado.ToString();
                        dataGridView1.Rows[3].Cells[1].Value = cajero4.tiempoAcumulado.ToString();
                        //mostrar tiempo promedio en que atiende el cajero
                        if (cajero1.clientesAtendidos != 0 || cajero2.clientesAtendidos != 0 || cajero3.clientesAtendidos != 0)
                        {
                            dataGridView1.Rows[0].Cells[2].Value = (cajero1.tiempoAcumulado / cajero1.clientesAtendidos).ToString();
                            dataGridView1.Rows[1].Cells[2].Value = (cajero2.tiempoAcumulado / cajero2.clientesAtendidos).ToString();
                            dataGridView1.Rows[2].Cells[2].Value = (cajero3.tiempoAcumulado / cajero3.clientesAtendidos).ToString();
                            dataGridView1.Rows[3].Cells[2].Value = (cajero4.tiempoAcumulado / cajero4.clientesAtendidos).ToString();
                        }
                    }
                    else if (num == 3) {
                        cajero1.tiempoAtencion(tiempoCajero.dequeue());
                        cajero2.tiempoAtencion(tiempoCajero.dequeue());
                        cajero3.tiempoAtencion(tiempoCajero.dequeue());
                        cajero1.atender();
                        cajero2.atender();
                        cajero3.atender();
                        //mostrar datos en gridview                        
                        //mostrar numero de clientes
                        dataGridView1.Rows[0].Cells[0].Value = cajero1.clientesAtendidos.ToString();
                        dataGridView1.Rows[1].Cells[0].Value = cajero2.clientesAtendidos.ToString();
                        dataGridView1.Rows[2].Cells[0].Value = cajero3.clientesAtendidos.ToString();
                        //mostrar tiempo acumulado
                        dataGridView1.Rows[0].Cells[1].Value = cajero1.tiempoAcumulado.ToString();
                        dataGridView1.Rows[1].Cells[1].Value = cajero2.tiempoAcumulado.ToString();
                        dataGridView1.Rows[2].Cells[1].Value = cajero3.tiempoAcumulado.ToString();
                        //mostrar tiempo promedio en que atiende el cajero
                        if (cajero1.clientesAtendidos != 0 || cajero2.clientesAtendidos != 0 || cajero3.clientesAtendidos != 0)
                        {
                            dataGridView1.Rows[0].Cells[2].Value = (cajero1.tiempoAcumulado / cajero1.clientesAtendidos).ToString();
                            dataGridView1.Rows[1].Cells[2].Value = (cajero2.tiempoAcumulado / cajero2.clientesAtendidos).ToString();
                            dataGridView1.Rows[2].Cells[2].Value = (cajero3.tiempoAcumulado / cajero3.clientesAtendidos).ToString();
                        }
                    }
                    else if (num == 2)
                        {
                            cajero1.tiempoAtencion(tiempoCajero.dequeue());
                            cajero2.tiempoAtencion(tiempoCajero.dequeue());                            
                            cajero1.atender();
                            cajero2.atender();                            
                            //mostrar datos en gridview                        
                            //mostrar numero de clientes
                            dataGridView1.Rows[0].Cells[0].Value = cajero1.clientesAtendidos.ToString();
                            dataGridView1.Rows[1].Cells[0].Value = cajero2.clientesAtendidos.ToString();                            
                            //mostrar tiempo acumulado
                            dataGridView1.Rows[0].Cells[1].Value = cajero1.tiempoAcumulado.ToString();
                            dataGridView1.Rows[1].Cells[1].Value = cajero2.tiempoAcumulado.ToString();                            
                            //mostrar tiempo promedio en que atiende el cajero
                            if (cajero1.clientesAtendidos != 0 || cajero2.clientesAtendidos != 0)
                            {
                                dataGridView1.Rows[0].Cells[2].Value = (cajero1.tiempoAcumulado / cajero1.clientesAtendidos).ToString();
                                dataGridView1.Rows[1].Cells[2].Value = (cajero2.tiempoAcumulado / cajero2.clientesAtendidos).ToString();                                
                            }
                        }
                        else if (num == 1)
                        {
                            cajero1.tiempoAtencion(tiempoCajero.dequeue());                            
                            cajero1.atender();                            
                            //mostrar datos en gridview                        
                            //mostrar numero de clientes
                            dataGridView1.Rows[0].Cells[0].Value = cajero1.clientesAtendidos.ToString();                            
                            //mostrar tiempo acumulado
                            dataGridView1.Rows[0].Cells[1].Value = cajero1.tiempoAcumulado.ToString();
                           
                            //mostrar tiempo promedio en que atiende el cajero
                            if (cajero1.clientesAtendidos != 0)
                            {
                                dataGridView1.Rows[0].Cells[2].Value = (cajero1.tiempoAcumulado / cajero1.clientesAtendidos).ToString();                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("LA COLA NO TIENE CLIENTES.");
                        }
                    
                }
            }
            else
            {
                MessageBox.Show("FORMATO INVÁLIDO. VUELVA A INGRESAR LA CANTIDAD DE CLIENTES.");
                textBox1.Clear();
            }
            textBox1.Clear();
        }

        private void borrarDatos_Click(object sender, EventArgs e)
        {
            //vaciar gridview
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }

            cajero1 = new Cajero();
            cajero2 = new Cajero();
            cajero3 = new Cajero();
            cajero4 = new Cajero();
            tiempoCajero = new LinkedQueue<int>();
        }
    }
}

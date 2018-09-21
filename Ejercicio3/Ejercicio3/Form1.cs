using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int num3;

        public Form1()
        {
            InitializeComponent();
        }

        private void IngresarNum_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                if (num1 < 0)
                {
                    MessageBox.Show("EL NÚMERO TIENE QUE SER MAYOR A 0. VUELVA A INGRESARLO.");
                    num1 = 0;
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FORMATO INVÁLIDO. INGRESE OTRA VEZ EL NÚMERO.");
                textBox1.Clear();
            }
        }

        private void IngresarNum2_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToInt32(textBox2.Text);
                if (num2 < 0)
                {
                    MessageBox.Show("EL NÚMERO TIENE QUE SER MAYOR A 0. VUELVA A INGRESARLO.");
                    num2 = 0;
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FORMATO INVÁLIDO. INGRESE OTRA VEZ EL NÚMERO.");
                textBox2.Clear();
            }
        }

        private void IngresarNumero3_Click(object sender, EventArgs e)
        {
            try
            {
                num3 = Convert.ToInt32(textBox3.Text);
                if (num3 < 0)
                {
                    MessageBox.Show("EL NÚMERO TIENE QUE SER MAYOR A 0. VUELVA A INGRESARLO.");
                    num3 = 0;
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FORMATO INVÁLIDO. INGRESE OTRA VEZ EL NÚMERO.");
                textBox3.Clear();
            }                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resolución del problema
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    MessageBox.Show("RESULTADO: El mayor es " + num1);
                }
                else
                {
                    if (num1 == num3)
                    {
                        MessageBox.Show("RESULTADO: El mayor es " + num1);
                    }
                    else
                    {
                        MessageBox.Show("RESULTADO: El mayor es " + num3);
                    }
                }
            }
            else
            {
                if (num1 == num2)
                {
                    if (num1 > num3)
                    {
                        MessageBox.Show("RESULTADO: El mayor es " + num1);
                    }
                    else
                    {
                        if (num1 == num3)
                        {
                            MessageBox.Show("RESULTADO: El mayor es " + num1);
                        }
                        else
                        {
                            MessageBox.Show("RESULTADO: El mayor es " + num3);
                        }
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        MessageBox.Show("RESULTADO: El mayor es" + num2);
                    }
                    else
                    {
                        if (num2 == num3)
                        {
                            MessageBox.Show("RESULTADO: El mayor es " + num2);
                        }
                        else
                        {
                            MessageBox.Show("RESULTADO: El mayor es " + num3);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            num1 = 0;
            num2 = 0;
            num3 = 0;
        }
    }
}

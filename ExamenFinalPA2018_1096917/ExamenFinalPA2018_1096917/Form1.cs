using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EstrcuturasDinamicas;

namespace ExamenFinalPA2018_1096917
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile;
        StreamReader fileReader;
        MyLinkedList<string> fileNames = new MyLinkedList<string>();
        MyLinkedList<string> customers = new MyLinkedList<string>();
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Title = "SELECCIONE EL ARCHIVO PARA INGRESARLO AL SISTEMA";
            path = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
                path = openFile.FileName;
                if (path.Contains(".csv"))//verifica que sea el archivo necesario para el sistema
                {                                      
                    if (fileNames.isEmpty())
                    {
                        string line = "";
                        fileReader = new StreamReader(path);
                        line = fileReader.ReadLine();
                        while (line != null)
                        {
                            if (line != "ID,Nombre,Tel�fono,Edad,Direcci�n")
                            {
                                customers.addLast(line);                                
                            }
                            line = fileReader.ReadLine();
                        }
                    }
                    else
                    {
                        if (!fileNames.searchElement(path))//verifica si el archivo ya fue leído
                        {//lee el archivo linea por linea
                            string line = "";
                            fileReader = new StreamReader(path);
                            line = fileReader.ReadLine();
                            while (line != null)
                            {
                                if (line != "ID,Nombre,Tel�fono,Edad,Direcci�n")
                                {
                                    customers.addLast(line);
                                }
                                line = fileReader.ReadLine();
                            }                            
                        }
                        else//si el archivo ya fue leído
                        {
                            path = "";
                            textBox1.Text = "";
                            MessageBox.Show("EL ARCHIVO YA FUE INGRESADO");
                        }
                    }
                    fileNames.addLast(path);
                }
                else//si el formato es incorrecto no hará nada.
                {
                    MessageBox.Show("FORMATO INCORRECTO.");
                    textBox1.Text = "";
                    path = "";
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ARCHIVO.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileReader.Close();
            Depuration dForm = new Depuration(customers);
            dForm.Show();
        }
    }
}

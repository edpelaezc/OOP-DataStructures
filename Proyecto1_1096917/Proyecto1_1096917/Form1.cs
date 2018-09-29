using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using EstrcuturasDinamicas;
using System.Threading;

namespace Proyecto1_1096917
{
    public partial class Form1 : Form
    {
        LinkedQueue<string> newsFeed = new LinkedQueue<string>();
        LinkedStack<string> messenger = new LinkedStack<string>();
        MyLinkedList<string> friends = new MyLinkedList<string>();
        MyLinkedList<string> credentials = new MyLinkedList<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            pictureBox1.Image = Image.FromFile(@"C:\GitHub\OOP-DataStructures\Proyecto1_1096917\users_21937.png");
        }

        private void enterFile_Click(object sender, EventArgs e)
        {            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "SELECCIONE EL ARCHIVO PARA INICIAR SESIÓN";
            StreamReader fileReader;
            string path = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFile.FileName;
                path = openFile.FileName;
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ARCHIVO.");
            }

            string line = "";
            fileReader = new StreamReader(path);
            line = fileReader.ReadLine();
            while (line != null)
            {                
                if (line != null)
                {
                    if (line != "[NEWSFEED]" && line != "[MESSENGER]" && line != "[CONTACTOS]" && credentials.size() != 2)
                    {
                        credentials.addLast(line);
                        line = fileReader.ReadLine();
                    }
                    else if (line == "[NEWSFEED]")
                    {
                        while (line != "[MESSENGER]" && line != "[CONTACTOS]")
                        {
                            line = fileReader.ReadLine();
                            newsFeed.enqueue(line);
                        }
                    }
                    else if (line == "[MESSENGER]")
                    {
                        while (line != "[CONTACTOS]")
                        {
                            line = fileReader.ReadLine();
                            messenger.push(line);
                        }
                    }
                    else
                    {
                        while (line != null)
                        {
                            line = fileReader.ReadLine();
                            friends.addLast(line);
                        }
                    }
                }
            }

            fileReader.Close();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            logIn.Enabled = true;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            string userName = credentials.removeFirst();
            string password = credentials.removeFirst();

            if (userName == textBox1.Text && password == textBox2.Text)
            {
                using (Loading loadingForm = new Loading(saveData))
                {
                    loadingForm.ShowDialog(this);
                }
                MessageBox.Show("Se inició sesión correctamente. ¡Bienvenido!");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        void saveData()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(5);//Simulador
            }
        }
        
        /// <summary>
        /// validate
        /// </summary>
        /// <param name="_string">Cadena que se tratará de convertir a tipo entero. Índice que se utiliza en algunos métodos de la lista.</param>
        /// <returns>"True" si es posible convertir la cadena a entero, "False" si no es posible hacer la conversión.</returns>
        public static bool validate(string _string)
        {
            int numValue;
            return int.TryParse(_string, out numValue);
        }
    }
}

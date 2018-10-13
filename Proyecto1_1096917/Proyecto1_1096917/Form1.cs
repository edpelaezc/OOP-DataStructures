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
    /// <summary>
    /// Login de la red social. 
    /// </summary>
    public partial class Form1 : Form
    {
        MyLinkedList<string> newsFeed = new MyLinkedList<string>();//lista con disciplina de cola.
        MyLinkedList<string> messenger = new MyLinkedList<string>();//lista con disciplina de pila.
        MyLinkedList<string> friends = new MyLinkedList<string>();        
        OpenFileDialog openFile;
        StreamReader fileReader;
        string userName = "";
        string password = "";
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Botón utilizado para insertar y leer los archivos de texto correspondientes.
        /// </summary>
        private void enterFile_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Title = "SELECCIONE EL ARCHIVO PARA INICIAR SESIÓN";
            path = "";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (newsFeed.isEmpty() || messenger.isEmpty() || friends.isEmpty())//mientras que las estructuras estén vacías ejecutará el código.
                {
                    textBox3.Text = openFile.FileName;
                    path = openFile.FileName;
                    if (path.Contains(".txt"))//valida que sea el formato de archivo correcto
                    {
                        if (path.Contains("newsfeed") && newsFeed.isEmpty())
                        {
                            string line = "";
                            fileReader = new StreamReader(path);
                            line = fileReader.ReadLine();
                            while (line != null)
                            {
                                newsFeed.addLast(line);
                                line = fileReader.ReadLine();
                            }
                        }
                        else if (path.Contains("messenger") && messenger.isEmpty())
                        {
                            string line = "";
                            fileReader = new StreamReader(path);
                            line = fileReader.ReadLine();
                            while (line != null)
                            {
                                messenger.addFirst(line);
                                line = fileReader.ReadLine();
                            }
                        }
                        else if (path.Contains("contacts") && friends.isEmpty())
                        {
                            string line = "";
                            fileReader = new StreamReader(path);
                            line = fileReader.ReadLine();
                            while (line != null)
                            {
                                friends.addLast(line);
                                line = fileReader.ReadLine();
                            }
                        }
                        else if (path.Contains("config") && userName == "" && password == "")
                        {
                            string[] line;
                            fileReader = new StreamReader(path);
                            line = fileReader.ReadLine().Split('|');
                            userName = line[0];
                            password = line[1];
                        }
                        else//si el archivo ya fue ingresado.
                        {
                            MessageBox.Show("EL ARCHIVO ES INCORRECTO O YA FUE INGRESADO.");
                            textBox3.Clear();
                        }                        
                    }
                    else//si no es del formato correcto.
                    {
                        MessageBox.Show("FORMATO INCORRECTO.");
                        textBox3.Text = "";
                        path = "";
                    }
                    //si las estructuras ya están llenas permite el acceso a lo
                    if (!newsFeed.isEmpty() && !messenger.isEmpty() && !friends.isEmpty())
                    {
                        MessageBox.Show("TODOS LOS ARCHIVOS FUERON INGRESADOS.");
                        fileReader.Close();
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        logIn.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("SIGA INGRESANDO LOS DEMÁS ARCHIVOS.");
                    }                    
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ARCHIVO.");
            }
        }

        /// <summary>
        /// Botón para inicar sesión.
        /// </summary>
        private void logIn_Click(object sender, EventArgs e)
        {           
            if (userName == textBox1.Text && password == textBox2.Text)
            {
                using (Loading loadingForm = new Loading(saveData))
                {
                    loadingForm.ShowDialog(this);
                }
                MessageBox.Show("Se inició sesión correctamente. ¡Bienvenido!");
                MainPage formMainPage = new MainPage(newsFeed, messenger, friends);                
                formMainPage.Show();                
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
            for (int i = 0; i <= 250; i++)
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

        /// <summary>
        /// Después de cerrar "Main Page" reinicia todo.
        /// </summary>
        public void close()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            userName = "";
            password = "";
            newsFeed = new MyLinkedList<string>();
            messenger = new MyLinkedList<string>();
            friends = new MyLinkedList<string>();
            MessageBox.Show("SESIÓN CERRADA.");
        }
    }
}

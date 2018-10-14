using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstrcuturasDinamicas;

namespace Proyecto1_1096917
{
    /// <summary>
    /// "Main Page". Utilizado para mostrar newsfeed, messenger y la lista de amigos. 
    /// </summary>
    public partial class MainPage : Form
    {
        MyLinkedList<string> newsFeed = new MyLinkedList<string>();
        MyLinkedList<string> messenger = new MyLinkedList<string>();
        MyLinkedList<string> friends = new MyLinkedList<string>();
        News[] arrayNews;
        Message[] arrayMessages;
        Contact[] arrayFriends;
        int nFSize;
        int mSize;
        int fSize;
        string background = @"C:\GitHub\OOP-DataStructures\Proyecto1_1096917\fondo-blanco.jpg";//si no hay imagen en newsfeed

        //estructuras que se manipularán 
        MyLinkedList<News> news = new MyLinkedList<News>();
        MyLinkedList<Message> chat = new MyLinkedList<Message>();
        MyLinkedList<Contact> friendList = new MyLinkedList<Contact>();

        /// <summary>
        /// Constructor del fomulario. Recibe como parámetro las estructuras del Login para poder extraer los datos y manejarlos.
        /// </summary>
        /// <param name="newsFeed">Cola que contiene las líneas leídas en el archivo "newsfeed".</param>
        /// <param name="messenger">Pila que contiene las líneas leídas en el archivo "messenger".</param>
        /// <param name="friends">Cola que contiene las líneas leídas en el archivo "contact".</param>
        public MainPage(MyLinkedList<string> newsFeed, MyLinkedList<string> messenger, MyLinkedList<string> friends)
        {
            InitializeComponent();
            this.newsFeed = newsFeed;            
            this.messenger = messenger;
            this.friends = friends;            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            nFSize = newsFeed.size();//tamaño de la cola de newsfeed
            mSize = messenger.size();//tamaño de la pila de messenger
            fSize = friends.size();//tamaño de la lista de amigos

            //mostrar noticias, usar auxiliar para ir agregando a estructura de tipo "News"
            string[] aux;
            News auxNews;
            for (int i = 0; i < nFSize; i++)
            {
                aux = newsFeed.removeFirst().Split('│');
                auxNews = new News(aux[0], aux[1], aux[2], aux[3]);
                news.addLast(auxNews);
                auxNews = null;
            }

            //Pasar elementos de la lista a un arreglo para poder manipularlos y mostrarlos
            arrayNews = news.listToArray();                
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();//agrega toString de News
                if (arrayNews[i].getPath() != "")
                {
                    try//validación, por si no encuentra la direccion de la imagen
                    {
                        Image image = Image.FromFile(arrayNews[i].getPath());
                        Image newImage = resizeImage(image, new Size(169, 169));
                        dataGridView1.Rows[i].Cells[1].Value = newImage;
                    }
                    catch (Exception)//si no la encuentra muestra el fondo-blanco
                    {
                        Image image = Image.FromFile(background);
                        Image newImage = resizeImage(image, new Size(169, 169));
                        dataGridView1.Rows[i].Cells[1].Value = newImage;
                    }
                }
                else
                {
                    Image image = Image.FromFile(background);
                    Image newImage = resizeImage(image, new Size(169, 169));
                    dataGridView1.Rows[i].Cells[1].Value = newImage;
                }   
            }
            dataGridView1.Update();

            //mostrar contactos que enviaron mensajes, usando auxiliar para agregar a estructura de tipo "Message"
            string[] message;
            Message auxMessage;
            for (int i = 0; i < mSize; i++)
            {
                message = messenger.removeFirst().Split('│');
                auxMessage = new Message(message[0], message[1], message[2], message[3], message[4]);                
                chat.addLast(auxMessage);
                auxMessage = null;
            }

            //Metodo para mostrar una sola vez los contactos que enviaron un mensaje.
            int cont1 = 0;//elemento actual
            int cont2 = 2;//elemento siguiente 
            arrayMessages = chat.listToArray();
            listBox2.Items.Add(arrayMessages[0].getEmail());
            if (arrayMessages[1].getEmail() != arrayMessages[0].getEmail())
            {
                listBox2.Items.Add(arrayMessages[1].getEmail());
            }
            while (cont2 < mSize)
            {
                while (cont1 < cont2)
                {
                    if (arrayMessages[cont1].getEmail() != arrayMessages[cont2].getEmail())
                    {
                        cont1++;
                    }
                    else
                    {
                        cont1 = 0;
                        cont2++;
                    }
                    break;
                }

                if (cont1 == cont2)
                {
                    listBox2.Items.Add(arrayMessages[cont2].getEmail());
                    cont1 = 0;
                    cont2++;
                }
            }

            //mostrar lista de amigos, usando auxiliar para agregar lista de tipo "Contact"
            string[] friend;
            Contact auxContact;
            for (int i = 0; i < fSize; i++)
            {
                friend = friends.removeFirst().Split('│');
                auxContact = new Contact(friend[0], friend[1], friend[2], friend[3], friend[4], friend[5]);
                friendList.addLast(auxContact);
                auxContact = null;
            }

            arrayFriends = friendList.listToArray();
            for (int i = 0; i < fSize; i++)
            {
                listBox1.Items.Add(arrayFriends[i].getName() + " " + arrayFriends[i].getLastName());
            }
        }

        /// <summary>
        /// Si hace doble click en la listBox2 se muestran los mensajes correspondientes al contacto seleccionado.
        /// </summary>
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            //si hace doble click en el item de la lista, se muestran los mensajes correspondiente
            string name = listBox2.SelectedItem.ToString();
            for (int i = 0; i < mSize; i++)
            {
                if (arrayMessages[i].getEmail() == name)
                {
                    listBox3.Items.Add(arrayMessages[i].toString());
                }
            }
        }

        /// <summary>
        /// Limpia los mensajes de la bandeja de entrada
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            //limpia los mensajes que entraron
            listBox3.Items.Clear();
        }

        /// <summary>
        /// logOut, Cierra la sesión actual.
        /// </summary>
        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CERRANDO SESIÓN...");
            Application.Exit();            
        }

        /// <summary>
        /// block, Bloquea al amigo borrando sus noticias de la sección "NewsFeed"
        /// </summary>
        private void block_Click(object sender, EventArgs e)
        {
            string selected = "";
            string name = listBox1.SelectedItem.ToString();
            //recorrer lista para obtener email
            for (int i = 0; i < arrayFriends.Length; i++)
            {
                if (name == arrayFriends[i].getName() + " " + arrayFriends[i].getLastName())
                {
                    selected = arrayFriends[i].getEmail();
                }
            }

            Node<News> auxiliar = news.head;
            while (auxiliar != null)
            {
                if (auxiliar.getElement().getEmail() == selected)
                {
                    news.removeNode(auxiliar);
                }
                auxiliar = auxiliar.getNext();
            }

            nFSize = news.size();
            arrayNews = news.listToArray();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NOTICIAS", "NOTICIAS");
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "image";
            column.HeaderText = "IMÁGENES";
            dataGridView1.Columns.Add(column);
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
                if (arrayNews[i].getPath() != "")
                {
                    try
                    {
                        Image image = Image.FromFile(arrayNews[i].getPath());
                        Image newImage = resizeImage(image, new Size(169, 169));
                        dataGridView1.Rows[i].Cells[1].Value = newImage;
                    }
                    catch (Exception)
                    {
                        Image image = Image.FromFile(background);
                        Image newImage = resizeImage(image, new Size(169, 169));
                        dataGridView1.Rows[i].Cells[1].Value = newImage;
                    }
                }
                else
                {
                    Image image = Image.FromFile(background);
                    Image newImage = resizeImage(image, new Size(169, 169));
                    dataGridView1.Rows[i].Cells[1].Value = newImage;
                }
            }
            dataGridView1.Update();
        }

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            MessageBox.Show(arrayFriends[selected].toString());
        }

        /// <summary>
        /// delete, Elimina al amigo seleccionado en la listBox
        /// </summary>
        private void delete_Click(object sender, EventArgs e)
        {
            //eliminar noticias
            string selected = "";
            string name = listBox1.SelectedItem.ToString();
            //recorrer lista para obtener email
            for (int i = 0; i < arrayFriends.Length; i++)
            {
                if (name == arrayFriends[i].getName() + " " + arrayFriends[i].getLastName())
                {
                    selected = arrayFriends[i].getEmail();
                }
            }
            
            Node<News> newsAuxiliar = news.head;
            while (newsAuxiliar != null)
            {
                if (newsAuxiliar.getElement().getEmail() == selected)
                {
                    news.removeNode(newsAuxiliar);
                }
                newsAuxiliar = newsAuxiliar.getNext();
            }

            nFSize = news.size();
            arrayNews = news.listToArray();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NOTICIAS", "NOTICIAS");
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "image";
            column.HeaderText = "IMÁGENES";
            dataGridView1.Columns.Add(column);
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
                if (arrayNews[i].getPath() != "")
                {
                    try
                    {
                        Image image = Image.FromFile(arrayNews[i].getPath());
                        Image newImage = resizeImage(image, new Size(169, 169));
                        dataGridView1.Rows[i].Cells[1].Value = newImage;
                    }
                    catch (Exception)
                    {
                        Image image = Image.FromFile(background);
                        Image newImage = resizeImage(image, new Size(169, 169));
                        dataGridView1.Rows[i].Cells[1].Value = newImage;
                    }
                }
                else
                {
                    Image image = Image.FromFile(background);
                    Image newImage = resizeImage(image, new Size(169, 169));
                    dataGridView1.Rows[i].Cells[1].Value = newImage;
                }
            }
            dataGridView1.Update();

            //eliminar mensajes  
            Node<Message> chatAuxiliar = chat.head;
            while (chatAuxiliar != null)
            {
                if (chatAuxiliar.getElement().getEmail() == selected)
                {
                    chat.removeNode(chatAuxiliar);
                }
                chatAuxiliar = chatAuxiliar.getNext();
            }

            listBox2.Items.Clear();
            if (!chat.isEmpty())
            {
                mSize = chat.size();
                int cont1 = 0;
                int cont2 = 2;
                arrayMessages = chat.listToArray();
                listBox2.Items.Add(arrayMessages[0].getEmail());
                if (arrayMessages[1].getEmail() != arrayMessages[0].getEmail())
                {
                    listBox2.Items.Add(arrayMessages[1].getEmail());
                }
                while (cont2 < mSize)
                {
                    while (cont1 < cont2)
                    {
                        if (arrayMessages[cont1].getEmail() != arrayMessages[cont2].getEmail())
                        {
                            cont1++;
                        }
                        else
                        {
                            cont1 = 0;
                            cont2++;
                        }
                        break;
                    }

                    if (cont1 == cont2)
                    {
                        listBox2.Items.Add(arrayMessages[cont2].getEmail());
                        cont1 = 0;
                        cont2++;
                    }
                }
            }

            //eliminar amigo           
            Node<Contact> friendsAuxiliar = friendList.head;
            while (friendsAuxiliar != null)
            {
                if ((friendsAuxiliar.getElement().getEmail() == selected))
                {
                    friendList.removeNode(friendsAuxiliar);
                }
                friendsAuxiliar = friendsAuxiliar.getNext();
            }

            listBox1.Items.Clear();
            fSize = friendList.size();
            arrayFriends = friendList.listToArray();
            for (int i = 0; i < fSize; i++)
            {
                listBox1.Items.Add(arrayFriends[i].getName() + " " + arrayFriends[i].getLastName());
            }
        }

        /// <summary>
        /// resizeImage
        /// </summary>
        /// <param name="imageToResize">Imagen que será redimensionada</param>
        /// <param name="size">Nuevo tamaña para la imagen</param>
        /// <returns></returns>
        public static Image resizeImage(Image imageToResize, Size size)
        {
            return (Image)(new Bitmap(imageToResize, size));
        }
    }
}

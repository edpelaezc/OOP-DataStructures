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

        //estructuras que se manipularán 
        MyLinkedList<News> news = new MyLinkedList<News>();
        MyLinkedList<Message> chat = new MyLinkedList<Message>();
        MyLinkedList<Contact> friendList = new MyLinkedList<Contact>();

        public MainPage(MyLinkedList<string> newsFeed, MyLinkedList<string> messenger, MyLinkedList<string> friends)
        {
            InitializeComponent();
            this.newsFeed = newsFeed;            
            this.messenger = messenger;
            this.friends = friends;            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            nFSize = newsFeed.size();
            mSize = messenger.size();
            fSize = friends.size();

            //mostrar noticias
            string[] aux;
            News auxNews;
            for (int i = 0; i < nFSize; i++)
            {
                aux = newsFeed.removeFirst().Split('│');
                auxNews = new News(aux[0], aux[1], aux[2], aux[3]);
                news.addLast(auxNews);
                auxNews = null;
            }
            
            arrayNews = news.listToArray();                  
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
                if (arrayNews[i].getPath() != null)
                {
                    Image image = Image.FromFile(arrayNews[i].getPath());
                    Image newImage = resizeImage(image, new Size(125, 125));
                    dataGridView1.Rows[i].Cells[1].Value = newImage;
                }                
            }
            dataGridView1.Update();

            //mostrar contactos que enviaron mensajes
            string[] message;
            Message auxMessage;
            for (int i = 0; i < mSize; i++)
            {
                message = messenger.removeFirst().Split('│');
                auxMessage = new Message(message[0], message[1], message[2], message[3], message[4]);                
                chat.addLast(auxMessage);
                auxMessage = null;
            }

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

            //mostrar lista de amigos
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

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string name = listBox2.SelectedItem.ToString();
            for (int i = 0; i < mSize; i++)
            {
                if (arrayMessages[i].getEmail() == name)
                {
                    listBox3.Items.Add(arrayMessages[i].getHour() + " " + arrayMessages[i].getText());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.close(true);
            this.Close();
        }

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
                if (arrayNews[i].getPath() != null)
                {
                    Image image = Image.FromFile(arrayNews[i].getPath());
                    Image newImage = resizeImage(image, new Size(125, 125));
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
                if (arrayNews[i].getPath() != null)
                {
                    Image image = Image.FromFile(arrayNews[i].getPath());
                    Image newImage = resizeImage(image, new Size(125, 125));
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

        public static Image resizeImage(Image imageToResize, Size size)
        {
            return (Image)(new Bitmap(imageToResize, size));
        }        
    }
}

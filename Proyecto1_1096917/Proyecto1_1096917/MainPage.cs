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
            string[] aux = new string[2];
            News auxNews = new News();
            for (int i = 0; i < nFSize; i++)
            {
                aux = newsFeed.removeFirst().Split(',');
                auxNews.setName(aux[0]);
                auxNews.setActivity(aux[1]);
                news.addLast(auxNews);
                auxNews = new News();
            }

            arrayNews = news.listToArray();
            dataGridView1.Columns.Add("NOTICIAS", "NOTICIAS");
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
            }

            //mostrar contactos que enviaron mensajes
            string[] message = new string[2];
            Message auxMessage = new Message();
            for (int i = 0; i < mSize; i++)
            {
                message = messenger.removeFirst().Split(',');
                auxMessage.setContact(message[0]);
                auxMessage.setChat(message[1]);
                chat.addLast(auxMessage);
                auxMessage = new Message();
            }

            int cont1 = 0;
            int cont2 = 2;
            arrayMessages = chat.listToArray();
            listBox2.Items.Add(arrayMessages[0].getContact());
            if (arrayMessages[1].getContact() != arrayMessages[0].getContact())
            {
                listBox2.Items.Add(arrayMessages[1].getContact());
            }
            while (cont2 < mSize)
            {
                while (cont1 < cont2)
                {
                    if (arrayMessages[cont1].getContact() != arrayMessages[cont2].getContact())
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
                    listBox2.Items.Add(arrayMessages[cont2].getContact());
                    cont1 = 0;
                    cont2++;
                }
            }

            //mostrar lista de amigos
            string[] friend;
            Contact auxContact;
            for (int i = 0; i < fSize; i++)
            {
                friend = friends.removeFirst().Split(',');
                auxContact = new Contact(friend[0], friend[1], friend[2], friend[3]);
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
                if (arrayMessages[i].getContact() == name)
                {
                    listBox3.Items.Add(arrayMessages[i].getChat());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void block_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();
            for (int i = 0; i < nFSize; i++)
            {
                if (arrayNews[i].getName() == selected)
                {
                    news.removeElement(arrayNews[i]);
                }
            }

            nFSize = newsFeed.size();
            arrayNews = news.listToArray();
            dataGridView1.Columns.Add("NOTICIAS", "NOTICIAS");
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
            }
        }
    }
}

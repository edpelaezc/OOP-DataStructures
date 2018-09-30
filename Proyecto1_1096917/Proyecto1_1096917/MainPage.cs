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

        //estructuras que se manipularán 
        MyLinkedList<News> news = new MyLinkedList<News>();
        MyLinkedList<Message> chat = new MyLinkedList<Message>();

        public MainPage(MyLinkedList<string> newsFeed, MyLinkedList<string> messenger, MyLinkedList<string> friends)
        {
            InitializeComponent();
            this.newsFeed = newsFeed;            
            this.messenger = messenger;
            this.friends = friends;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            int nFSize = newsFeed.size();
            int mSize = messenger.size();
            int fSize = friends.size();

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

            News[] arrayNews = news.listToArray();                                   
            dataGridView1.Columns.Add("NOTICIAS", "NOTICIAS");            
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();                
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
            }

            //mostrar contacto que enviaron mensajes
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

            Message[] arrayMessages = chat.listToArray();
            for (int i = 0; i < mSize; i++)
            {
                listBox2.Items.Add(arrayMessages[i].getContact());
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

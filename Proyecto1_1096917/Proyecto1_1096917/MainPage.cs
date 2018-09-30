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
            //mostrar noticias                       
            dataGridView1.Columns.Add("NOTICIAS", "NOTICIAS");            
            for (int i = 0; i < nFSize; i++)
            {
                dataGridView1.Rows.Add();                
                dataGridView1.Rows[i].Cells[0].Value = arrayNews[i].toString();
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

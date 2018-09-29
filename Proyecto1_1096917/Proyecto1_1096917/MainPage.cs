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
        LinkedQueue<string> newsFeed = new LinkedQueue<string>();
        LinkedStack<string> messenger = new LinkedStack<string>();
        MyLinkedList<string> friends = new MyLinkedList<string>();        

        public MainPage(LinkedQueue<string> newsFeed, LinkedStack<string> messenger, MyLinkedList<string> friends)
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
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

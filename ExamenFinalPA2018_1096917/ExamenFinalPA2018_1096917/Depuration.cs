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

namespace ExamenFinalPA2018_1096917
{
    public partial class Depuration : Form
    {
        MyDoubleLinkedList<string> sCustomers = new MyDoubleLinkedList<string>();
        BinaryTree<Cliente> theStar = new BinaryTree<Cliente>();

        public Depuration(MyDoubleLinkedList<string> customers)
        {
            InitializeComponent();
            sCustomers = customers;            
        }

        private void Depuration_Load(object sender, EventArgs e)
        {
            int size = sCustomers.size();
            string[] aux;
            Cliente auxNews;
            for (int i = 0; i < size; i++)
            {
                aux = sCustomers.removeFirst().Split('│', '|');
                auxNews = new Cliente(aux[0], aux[1], aux[2], aux[3]);
                customers.addLast(auxNews);
                auxNews = null;
            }
        }
    }
}

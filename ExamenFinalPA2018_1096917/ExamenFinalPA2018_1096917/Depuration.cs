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
    public partial class Depuration : Form
    {
        MyLinkedList<string> sCustomers = new MyLinkedList<string>();
        BinaryTree<Cliente> theStar = new BinaryTree<Cliente>();

        public Depuration(MyLinkedList<string> customers)
        {
            InitializeComponent();
            sCustomers = customers;            
        }

        private void Depuration_Load(object sender, EventArgs e)
        {
            int size = sCustomers.size();
            string[] aux;
            Cliente auxC;
            for (int i = 0; i < size; i++)
            {                
                aux = sCustomers.removeFirst().Split(',');                
                auxC = new Cliente(int.Parse(aux[0]), aux[1].Substring(1), aux[2], aux[3], aux[4]);
                theStar.add(auxC, auxC.getID());
                auxC = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //theStar.removeD(compareByName, theStar.root);
            MyLinkedList<int> repeatedKeys = theStar.repeatedID();
            theStar.inOrder(theStar.root);//recorrer inorder el arbol para ingresar elementos a linkedlist
            MyLinkedList<TreeNode<Cliente>> refinedInformation = theStar.order;
            MyLinkedList<TreeNode<Cliente>> repeated = new MyLinkedList<TreeNode<Cliente>>();
            //uso de delegates para comparar los clientes por llave de nombre                        
            repeated = refinedInformation.purge(compareByName);
            MyLinkedList<TreeNode<Cliente>> newTree = refinedInformation;

            StreamWriter file = new StreamWriter(@"C:\Users\edanP\Desktop\Archivo1.txt");
            file.WriteLine("INFORMACION DEPURADA:");
            while (!refinedInformation.isEmpty())
            {
                TreeNode<Cliente> aux = refinedInformation.removeFirst();
                //delegate para mostrar elemento "Cliente"
                file.WriteLine(aux.toString(aux.getElement().toString));
            }
            file.Close();

            StreamWriter file2 = new StreamWriter(@"C:\Users\edanP\Desktop\Archivo2.txt");
            file2.WriteLine("LOS ID REPETIDOS SON:\n ");
            while (!repeatedKeys.isEmpty())
            {
                file2.WriteLine(repeatedKeys.removeFirst());
            }

            file2.WriteLine();
            file2.WriteLine("\nNODOS ELIMINADOS:");
            while (!repeated.isEmpty())
            {
                TreeNode<Cliente> aux = repeated.removeFirst();
                file2.WriteLine(aux.toString(aux.getElement().toString));
            }
            file2.Close();

            //volver a llenar arbol con información depurada
            BinaryTree<Cliente> nTree = new BinaryTree<Cliente>();
            int size = newTree.size();
            for (int i = 0; i < size; i++)
            {
                TreeNode<Cliente> aux = newTree.removeFirst();
                nTree.add(aux.getElement(), aux.getKey());
            }

            //depuración completada
            MessageBox.Show("INFORMACIÓN DEPURADA CORRECTAMENTE, LOS ARCHIVOS RESULTANTES SE ENCUENTRAN EN EL ESCRITORIO DE ESTE EQUIPO");
            this.Close();
        }

        //funcion que se enviará a un delegate para comparar los clientes.
        static bool compareByName(Node<TreeNode<Cliente>> customer1, Node<TreeNode<Cliente>> customer2)
        {
            if (customer1.getElement().getElement().getName() == customer2.getElement().getElement().getName() && customer1 != null && customer2 != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

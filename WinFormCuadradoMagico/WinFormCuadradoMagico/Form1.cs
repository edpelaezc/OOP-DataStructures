using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCuadradoMagico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leerDimensiones_Click(object sender, EventArgs e)
        {
            Random rNum = new Random(DateTime.Today.Millisecond);            
            int n = int.Parse(textBox1.Text);
            int[,] iMatrix = new int[n + 1, n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    iMatrix[i, j] = rNum.Next(1, 5);
                    dataGridView1.Rows[i].Cells[j].Value = iMatrix[i, j];
                }
            }


            int iCont = 0;
            bool bMagico = true;

            while ((iCont < n) && (bMagico))
            {

                int iContCols = 0;

                while ((iContCols < n) && (bMagico))
                {
                    iMatrix[iCont, n] += iMatrix[iCont, iContCols];
                    iMatrix[n, iCont] += iMatrix[iContCols, iCont];
                    iContCols++;
                }

                dataGridView1.Rows[iCont].Cells[n].Value = iMatrix[iCont, n];
                dataGridView1.Rows[n].Cells[iCont].Value = iMatrix[n, iCont];
                if (iCont > 0)
                {
                    if (iMatrix[iCont - 1, n] != iMatrix[iCont, n] || iMatrix[n, iCont - 1] != iMatrix[n, iCont])
                    {
                        MessageBox.Show("NO ES CUADRADO MAGICO");
                        bMagico = false;
                    }
                }

                iCont++;
            }

            if (bMagico)
            {
                MessageBox.Show("SI ES CUADRADO MAGICO"); 

            }

        }
    }
}

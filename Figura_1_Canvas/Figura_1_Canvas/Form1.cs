using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura_1_Canvas
{
    public partial class Form1 : Form
    {
        public PictureBox pictureBox1 = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            // Dock the PictureBox to the form and set its background to white.
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);

            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myDraw = e.Graphics;
            Pen myPen = new Pen(Color.FromArgb(255, 0, 0, 0));            
            int x = 10;
            int y = 100;
            for (int i = 0; i < 10; i++)
            {
                myDraw.DrawLine(myPen, 0, y, x, 0);
                x += 10;
                y -= 10;
            }
        }
    }
}

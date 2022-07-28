using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 100,100,100); // x  y  w  h
            g.DrawRectangle(blackPen, rect);
            g.FillRectangle(redBrush, rect);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush redBrush = new SolidBrush(Color.Blue);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(140, 100, 100, 100); // x  y  w  h
            g.DrawEllipse(blackPen, rect);
            g.FillEllipse(redBrush, rect);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Blue);
            g.DrawLine(blackPen,new Point(280,180),new Point (480,180));
        }
    }
}

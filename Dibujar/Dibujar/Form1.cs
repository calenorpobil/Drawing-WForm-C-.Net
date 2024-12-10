using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dibujar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Para trabajar con gráficos hay que realizar dos pasos: 
            //Crear un objeto Graphics, 
            Graphics g = CreateGraphics();
            g.DrawLine(new Pen(Color.Orange, 5), 50, 25, 300, 25);

            g.DrawEllipse(new Pen(Color.Black, 10), Left, Top, Right, 200);
            g.DrawPie(new Pen(Color.Blue, 7), 50, 350, 200, 200, 0, 120);
            Point[] puntos = { new Point(400, 340), new Point(341, 100), new Point(3, 111) };
            g.DrawPolygon(new Pen(Color.Bisque, Width), puntos);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}

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
    public partial class UserControl1 : UserControl
    {
        private Color colorSeleccionado;

        public Color ColorSeleccionado
        {
            get { return colorSeleccionado; }
            set { colorSeleccionado = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {            
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            colorSeleccionado = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            lbColor.BackColor = ColorSeleccionado;
            label4.Text = hScrollBar3.Value.ToString();
            label5.Text = hScrollBar3.Value.ToString();
            label6.Text = hScrollBar3.Value.ToString();
        }
    }
}

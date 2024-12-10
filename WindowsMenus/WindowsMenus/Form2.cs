using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMenus
{
    public partial class Form2 : Form
    {

        private int ancho, alto;

        public int Ancho
        {
            get
            {
                return int.Parse(tbAncho.Text);
            }
            set
            {
                tbAncho.Text = value.ToString();
            }
        }
        public int Alto
        {
            get
            {
                return int.Parse(tbAlto.Text);
            }
            set
            {
                tbAlto.Text = value.ToString();
            }
        }



        public Form2()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close ();
        }
    }
}
1
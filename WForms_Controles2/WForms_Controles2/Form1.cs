using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms_Controles2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.ToString();
            DirectoryInfo d = new DirectoryInfo("COLORES");
            FileInfo[] archivos = d.GetFiles("*.png");
            if (d.Exists)
            {
                for (int i = 0; i < archivos.Length; i++)
                {
                    listBox1.Items.Add(archivos[i].Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("COLORES\\" + listBox1.SelectedItem.ToString());
        }
    }
}

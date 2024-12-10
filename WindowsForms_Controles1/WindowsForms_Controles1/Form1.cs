using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Controles1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Prineros controles en Windows Forms";
            button1.Text = "Cerrar Formulario";
            button1.Width = 100;
            label1.Text = "Contraseña";
            lbNombre.Text = "Nombre";
            lbApellido.Text = "Apellido";
            groupBox1.Text = "Curso";
            radioButton1.Text = "1";
            radioButton2.Text = "2";
            groupBox2.Text = "GB2";
            checkBox1.Text = "DAM";
            checkBox2.Text = "DAW";
            button2.Text = "Mostrar matrícula";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Highlight;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbMatricula.Text = "MATRÍCULA: \n" + tvApellido.Text + ", " + tvNombre.Text;

            if (radioButton1.Checked)
            {
                lbMatricula.Text += "\nCurso: " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                lbMatricula.Text += "\nCurso: " + radioButton2.Text;
            }
            else
            {
                lbMatricula.Text = "ATENCIÓN, ¡FALTA SELECCIONAR EL CURSO!";
            }
            if (checkBox1.Checked)
            {
                lbMatricula.Text += "\nGrado: " + checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                lbMatricula.Text += "\nGrado: " + checkBox2.Text;
            }
            else
            {
                lbMatricula.Text = "ATENCIÓN, ¡FALTA SELECCIONAR EL CURSO!";
            }

        }

        private void lbMatricula_Click(object sender, EventArgs e)
        {
        }
    }
}

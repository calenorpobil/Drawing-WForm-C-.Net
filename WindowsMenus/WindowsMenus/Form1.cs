using System.Windows.Forms;

namespace WindowsMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader archivo = new StreamReader(ofd.FileName);
                    textBox1.Text = archivo.ReadToEnd();
                    archivo.Close();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amarilloClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
            toolStrip1.ForeColor = Color.Red;

        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
            toolStrip1.ForeColor = Color.Black;

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Cyan;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void maysculas_Click(object sender, EventArgs e)
        {
            maysculas.Text = maysculas.Text.ToUpper();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "(" + e.X + ", " + e.Y + ")";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter archivo = new StreamWriter(saveFileDialog.FileName);
                    archivo.WriteLine(textBox1.Text);
                    archivo.Close();
                    MessageBox.Show("Se ha guardado el archivo");
                }
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cambiarColorDelFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAyuda_Click(object sender, EventArgs e)
        {
            FormAyudaTexto formAyudaTexto = new FormAyudaTexto();
            formAyudaTexto.ShowDialog();
        }

        private void tbCambiarTamaño_Click(object sender, EventArgs e)
        {
            Form2 formCambiarTamaño = new Form2();
            formCambiarTamaño.ShowDialog();

            if(formCambiarTamaño.DialogResult == DialogResult.OK)
            {
                this.Width = formCambiarTamaño.Ancho;
                this.Height = formCambiarTamaño.Alto;
            }
        }
    }
}

namespace WindowsMenus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            colorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            amarilloClaroToolStripMenuItem = new ToolStripMenuItem();
            colorDelTextoToolStripMenuItem = new ToolStripMenuItem();
            rojoToolStripMenuItem = new ToolStripMenuItem();
            negroToolStripMenuItem = new ToolStripMenuItem();
            formularioToolStripMenuItem = new ToolStripMenuItem();
            tsCambiarTamaño = new ToolStripTextBox();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorDeFondoToolStripMenuItem1 = new ToolStripMenuItem();
            cyanToolStripMenuItem = new ToolStripMenuItem();
            verdeToolStripMenuItem = new ToolStripMenuItem();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            maysculas = new ToolStripTextBox();
            btAyuda = new ToolStripButton();
            textBox1 = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, abrirToolStripMenuItem, formularioToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, guardarToolStripMenuItem, toolStripMenuItem2, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(139, 22);
            toolStripMenuItem1.Text = "Abrir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(139, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(139, 22);
            toolStripMenuItem2.Text = "Fuente";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(136, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            salirToolStripMenuItem.Size = new Size(139, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorDeFondoToolStripMenuItem, colorDelTextoToolStripMenuItem });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(45, 20);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // colorDeFondoToolStripMenuItem
            // 
            colorDeFondoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { amarilloClaroToolStripMenuItem });
            colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            colorDeFondoToolStripMenuItem.Size = new Size(154, 22);
            colorDeFondoToolStripMenuItem.Text = "Color de fondo";
            // 
            // amarilloClaroToolStripMenuItem
            // 
            amarilloClaroToolStripMenuItem.Name = "amarilloClaroToolStripMenuItem";
            amarilloClaroToolStripMenuItem.Size = new Size(148, 22);
            amarilloClaroToolStripMenuItem.Text = "Amarillo claro";
            amarilloClaroToolStripMenuItem.Click += amarilloClaroToolStripMenuItem_Click;
            // 
            // colorDelTextoToolStripMenuItem
            // 
            colorDelTextoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rojoToolStripMenuItem, negroToolStripMenuItem });
            colorDelTextoToolStripMenuItem.Name = "colorDelTextoToolStripMenuItem";
            colorDelTextoToolStripMenuItem.Size = new Size(154, 22);
            colorDelTextoToolStripMenuItem.Text = "Color del texto";
            // 
            // rojoToolStripMenuItem
            // 
            rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            rojoToolStripMenuItem.Size = new Size(107, 22);
            rojoToolStripMenuItem.Text = "Rojo";
            rojoToolStripMenuItem.Click += rojoToolStripMenuItem_Click;
            // 
            // negroToolStripMenuItem
            // 
            negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            negroToolStripMenuItem.Size = new Size(107, 22);
            negroToolStripMenuItem.Text = "Negro";
            negroToolStripMenuItem.Click += negroToolStripMenuItem_Click;
            // 
            // formularioToolStripMenuItem
            // 
            formularioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsCambiarTamaño });
            formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            formularioToolStripMenuItem.Size = new Size(77, 20);
            formularioToolStripMenuItem.Text = "Formulario";
            // 
            // tsCambiarTamaño
            // 
            tsCambiarTamaño.Name = "tsCambiarTamaño";
            tsCambiarTamaño.Size = new Size(100, 23);
            tsCambiarTamaño.Text = "Cambiar tamaño a ka ventana";
            tsCambiarTamaño.Click += tbCambiarTamaño_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            toolStrip1.ContextMenuStrip = contextMenuStrip1;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1, toolStripButton1, toolStripSeparator2, toolStripButton2, maysculas, btAyuda });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { colorDeFondoToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 26);
            // 
            // colorDeFondoToolStripMenuItem1
            // 
            colorDeFondoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cyanToolStripMenuItem, verdeToolStripMenuItem });
            colorDeFondoToolStripMenuItem1.Name = "colorDeFondoToolStripMenuItem1";
            colorDeFondoToolStripMenuItem1.Size = new Size(154, 22);
            colorDeFondoToolStripMenuItem1.Text = "Color de fondo";
            // 
            // cyanToolStripMenuItem
            // 
            cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            cyanToolStripMenuItem.Size = new Size(103, 22);
            cyanToolStripMenuItem.Text = "Cyan";
            cyanToolStripMenuItem.Click += cyanToolStripMenuItem_Click;
            // 
            // verdeToolStripMenuItem
            // 
            verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            verdeToolStripMenuItem.Size = new Size(103, 22);
            verdeToolStripMenuItem.Text = "Verde";
            verdeToolStripMenuItem.Click += verdeToolStripMenuItem_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(48, 22);
            toolStripLabel1.Text = "BREEEH";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // maysculas
            // 
            maysculas.Name = "maysculas";
            maysculas.Size = new Size(100, 25);
            maysculas.Click += maysculas_Click;
            // 
            // btAyuda
            // 
            btAyuda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btAyuda.Image = (Image)resources.GetObject("btAyuda.Image");
            btAyuda.ImageTransparentColor = Color.Magenta;
            btAyuda.Name = "btAyuda";
            btAyuda.Size = new Size(23, 22);
            btAyuda.Text = "Ayuda";
            btAyuda.Click += btAyuda_Click;
            // 
            // textBox1
            // 
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 401);
            textBox1.TabIndex = 2;
            textBox1.MouseMove += toolStripStatusLabel1_MouseMove;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(32, 17);
            toolStripStatusLabel1.Text = "Hola";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            toolStripStatusLabel1.MouseMove += toolStripStatusLabel1_MouseMove;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(statusStrip1);
            Controls.Add(textBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private ToolStripMenuItem amarilloClaroToolStripMenuItem;
        private ToolStripMenuItem colorDelTextoToolStripMenuItem;
        private ToolStripMenuItem rojoToolStripMenuItem;
        private ToolStripMenuItem negroToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem1;
        private ToolStripMenuItem cyanToolStripMenuItem;
        private ToolStripMenuItem verdeToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton2;
        private ToolStripTextBox maysculas;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem toolStripMenuItem2;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripButton btAyuda;
        private ToolStripMenuItem formularioToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripTextBox tsCambiarTamaño;
    }
}

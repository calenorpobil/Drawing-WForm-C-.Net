namespace WindowsMenus
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            btAceptar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(762, 46);
            label1.TabIndex = 0;
            label1.Text = "Cambiar el alto y el ancho del formulario principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(107, 150);
            label2.Name = "label2";
            label2.Size = new Size(98, 46);
            label2.TabIndex = 1;
            label2.Text = "Alto: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(107, 255);
            label3.Name = "label3";
            label3.Size = new Size(132, 46);
            label3.TabIndex = 2;
            label3.Text = "Ancho: ";
            // 
            // tbAlto
            // 
            tbAlto.Font = new Font("Microsoft Sans Serif", 25F);
            tbAlto.Location = new Point(283, 150);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(146, 45);
            tbAlto.TabIndex = 3;
            // 
            // tbAncho
            // 
            tbAncho.Font = new Font("Microsoft Sans Serif", 25F);
            tbAncho.Location = new Point(283, 257);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(146, 45);
            tbAncho.TabIndex = 4;
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(443, 371);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(75, 23);
            btAceptar.TabIndex = 5;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            btAceptar.Click += btAceptar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(613, 371);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 6;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btAceptar);
            Controls.Add(tbAncho);
            Controls.Add(tbAlto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAlto;
        private TextBox tbAncho;
        private Button btAceptar;
        private Button btCancelar;
    }
}
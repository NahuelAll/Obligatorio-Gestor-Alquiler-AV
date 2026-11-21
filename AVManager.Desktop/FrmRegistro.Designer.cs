namespace AVManager.Desktop
{
    partial class FrmRegistro
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
            btnCerrar = new Button();
            textBoxCorreo = new TextBox();
            RegistroTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxContraseña = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(61, 284);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(102, 24);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(61, 110);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(252, 23);
            textBoxCorreo.TabIndex = 1;
            // 
            // RegistroTitulo
            // 
            RegistroTitulo.AutoSize = true;
            RegistroTitulo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistroTitulo.Location = new Point(128, 23);
            RegistroTitulo.Name = "RegistroTitulo";
            RegistroTitulo.Size = new Size(110, 29);
            RegistroTitulo.TabIndex = 2;
            RegistroTitulo.Text = "Registro";
            RegistroTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 88);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 3;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 165);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(61, 187);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(252, 23);
            textBoxContraseña.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(211, 284);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 24);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 366);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(textBoxContraseña);
            Controls.Add(label1);
            Controls.Add(RegistroTitulo);
            Controls.Add(textBoxCorreo);
            Controls.Add(btnCerrar);
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private TextBox textBoxCorreo;
        private Label RegistroTitulo;
        private Label label1;
        private Label label2;
        private TextBox textBoxContraseña;
        private Button btnRegistrar;
    }
}

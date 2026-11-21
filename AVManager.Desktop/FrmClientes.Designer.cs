namespace AVManager.Desktop
{
    partial class FrmClientes
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
            btnRegresar = new Button();
            linkRegresar = new LinkLabel();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(88, 340);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(116, 24);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // linkRegresar
            // 
            linkRegresar.AutoSize = true;
            linkRegresar.LinkColor = Color.FromArgb(64, 64, 64);
            linkRegresar.Location = new Point(55, 34);
            linkRegresar.Name = "linkRegresar";
            linkRegresar.Size = new Size(68, 15);
            linkRegresar.TabIndex = 1;
            linkRegresar.TabStop = true;
            linkRegresar.Text = "<<Regresar";
            linkRegresar.LinkClicked += linkRegresar_LinkClicked;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkRegresar);
            Controls.Add(btnRegresar);
            Name = "FrmClientes";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private LinkLabel linkRegresar;
    }
}
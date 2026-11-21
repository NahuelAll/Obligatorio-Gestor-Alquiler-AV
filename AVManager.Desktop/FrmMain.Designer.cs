namespace AVManager.Desktop
{
    partial class FrmMain
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
            btnClientes = new Button();
            panelForms = new Panel();
            label1 = new Label();
            btnEquipo = new Button();
            btnEvento = new Button();
            btnSolicitud = new Button();
            btnPago = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.PaleGreen;
            btnClientes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ControlText;
            btnClientes.Location = new Point(35, 241);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(187, 26);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panelForms
            // 
            panelForms.Location = new Point(265, -3);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(1104, 835);
            panelForms.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(235, 74);
            label1.TabIndex = 2;
            label1.Text = "Alquiler\r\nAudiovisuales";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEquipo
            // 
            btnEquipo.BackColor = Color.PaleGreen;
            btnEquipo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipo.ForeColor = SystemColors.ControlText;
            btnEquipo.Location = new Point(35, 515);
            btnEquipo.Name = "btnEquipo";
            btnEquipo.Size = new Size(187, 26);
            btnEquipo.TabIndex = 3;
            btnEquipo.Text = "Equipo";
            btnEquipo.UseVisualStyleBackColor = false;
            btnEquipo.Click += button1_Click;
            // 
            // btnEvento
            // 
            btnEvento.BackColor = Color.PaleGreen;
            btnEvento.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvento.ForeColor = SystemColors.ControlText;
            btnEvento.Location = new Point(35, 420);
            btnEvento.Name = "btnEvento";
            btnEvento.Size = new Size(187, 26);
            btnEvento.TabIndex = 4;
            btnEvento.Text = "Evento";
            btnEvento.UseVisualStyleBackColor = false;
            // 
            // btnSolicitud
            // 
            btnSolicitud.BackColor = Color.PaleGreen;
            btnSolicitud.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolicitud.ForeColor = SystemColors.ControlText;
            btnSolicitud.Location = new Point(35, 334);
            btnSolicitud.Name = "btnSolicitud";
            btnSolicitud.Size = new Size(187, 26);
            btnSolicitud.TabIndex = 5;
            btnSolicitud.Text = "Solicitud";
            btnSolicitud.UseVisualStyleBackColor = false;
            btnSolicitud.Click += button3_Click;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.PaleGreen;
            btnPago.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPago.ForeColor = SystemColors.ControlText;
            btnPago.Location = new Point(35, 614);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(187, 26);
            btnPago.TabIndex = 7;
            btnPago.Text = "Pago";
            btnPago.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.PaleGreen;
            btnCerrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlText;
            btnCerrar.Location = new Point(35, 709);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(187, 26);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmMain
            // 
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1367, 829);
            Controls.Add(btnCerrar);
            Controls.Add(btnPago);
            Controls.Add(btnSolicitud);
            Controls.Add(btnEvento);
            Controls.Add(btnEquipo);
            Controls.Add(label1);
            Controls.Add(panelForms);
            Controls.Add(btnClientes);
            MaximizeBox = false;
            Name = "FrmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnClientes;
        private Panel panelForms;
        private Label label1;
        private Button btnEquipo;
        private Button btnEvento;
        private Button btnSolicitud;
        private Button btnPago;
        private Button btnCerrar;
    }
}
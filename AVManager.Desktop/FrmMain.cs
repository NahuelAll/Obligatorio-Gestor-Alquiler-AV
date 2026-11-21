using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AVManager.Desktop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            AbrirFormulario(new FrmClientes());
        }

        private void AbrirFormulario(Form formulario)
        {
            panelForms.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelForms.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmClientes());

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSolicitud());
        }
    }
}

using AV.Entities;
using AV.Persistencia;
namespace AVManager.Desktop
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<Administrador> admins = GestorAdmins.LeerAdmin();
            if(admins == null)
            {
                admins = [];
            }

            Guid id = Guid.CreateVersion7();
            var correo = textBoxCorreo.Text;
            var contraseña = textBoxContraseña.Text;

            Administrador admin = new()
            {
                Id = id,
                Email = correo,
                Password = contraseña
            };

            admins.Add(admin);
            GestorAdmins.GuardarRegistroAdmin(admins);
            textBoxCorreo.Text = string.Empty;
            textBoxContraseña.Text = string.Empty;
            MessageBox.Show("Se ha registrado correctamente");

            
        }
    }
}

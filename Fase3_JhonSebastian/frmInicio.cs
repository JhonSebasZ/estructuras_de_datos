namespace Fase3_JhonSebastian
{
    public partial class frmAutenticacion : Form
    {
        public frmAutenticacion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Ingrese la contraseña", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text != "123")
            {
                MessageBox.Show("Contraseña Incorrecta", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            frmEstructura menu = new frmEstructura();
            this.Hide();
            menu.Show();
        }

        private void frmAutenticacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
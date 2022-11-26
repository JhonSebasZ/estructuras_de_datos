using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3_JhonSebastian
{
    public partial class frmEstructura : Form
    {
        public frmEstructura()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmar", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                frmAutenticacion autenticacion = new frmAutenticacion();
                this.Close();
                autenticacion.Show();
            }
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            this.Hide();
            pila.Show();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            frmjuventud juventud = new frmjuventud();
            this.Hide();
            juventud.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmEstudiantes estudiante = new frmEstudiantes();
            this.Hide();
            estudiante.Show();
        }
    }
}

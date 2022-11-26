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
    public partial class frmjuventud : Form
    {
        ColaJuventud jovenes = new ColaJuventud();
        public frmjuventud()
        {
            InitializeComponent();
        }

        //Eventos de los botones
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "" || txtNombre.Text == "" || cmbDireccion.Text == "" || cmbSexo.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                txtIdentificacion.Focus();
                return;
            }

            if (errorIdenticacion.GetError(txtIdentificacion) != "" || errorNombre.GetError(txtNombre) != "")
            {
                MessageBox.Show("Tiene errores en algunos campos");
                return;
            }

            Juventud joven = new Juventud(txtIdentificacion.Text, txtNombre.Text, cmbDireccion.Text, cmbSexo.Text, dtpActualizacion.Value);
            jovenes.agregarJoven(joven);
            agregarFilas();
            limpiarCampos();
            txtIdentificacion.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                jovenes.eliminarJoven();
                agregarFilas();
                txtIdentificacion.Focus();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No tiene registros");
                txtIdentificacion.Focus();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int cantidaRegistros = jovenes.getCantidadRegistros();
            MessageBox.Show("Se encuentran " + cantidaRegistros + " registrados.", "Jovenes registrados");
            txtIdentificacion.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmEstructura estructura = new frmEstructura();
            this.Close();
            estructura.Show();
        }

        // eventos change
        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            isNumero(txtIdentificacion, errorIdenticacion);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            isLetra(txtNombre, errorNombre);
        }

        // funciones
        private void agregarFilas()
        {
            dgvJovenes.Rows.Clear();
            Queue<Juventud> j = jovenes.getJovenes();
            foreach (Juventud jv in j)
            {
                int fila = dgvJovenes.Rows.Count;
                dgvJovenes.Rows.Add();
                dgvJovenes[0, fila].Value = jv.identificaion;
                dgvJovenes[1, fila].Value = jv.nombreApellido;
                dgvJovenes[2, fila].Value = jv.sexo;
                dgvJovenes[3, fila].Value = jv.direccion;
                dgvJovenes[4, fila].Value = jv.getAuxilio().ToString();
                dgvJovenes[5, fila].Value = jv.fechaActualizacion.ToString();
            }

        }

        private bool isNumero(TextBox txtBox, ErrorProvider error)
        {
            if (txtBox.Text.Length > 0)
            {
                foreach (char caracter in txtBox.Text)
                {
                    if (!char.IsNumber(caracter))
                    {
                        error.SetError(txtBox, "Solo se admiten números");
                        return false;
                    }
                    else
                    {
                        error.Clear();
                    }
                }
            }
            else
            {
                error.SetError(txtBox, "Campo obligatorio");
                return false;
            }
            return true;
        }

        private bool isLetra(TextBox txtBox, ErrorProvider error)
        {
            if (txtBox.Text.Length > 0)
            {
                foreach (char caracter in txtBox.Text)
                {
                    if (!char.IsLetter(caracter) && caracter != ' ')
                    {
                        error.SetError(txtBox, "Solo se aceptan letras a - z ");
                        return false;
                    }
                    else
                    {
                        error.Clear();
                    }
                }
            }
            else
            {
                error.SetError(txtBox, "Campo obligatorio");
                return false;
            }
            return true;
        }

        private void limpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            cmbSexo.SelectedItem = -1;
            cmbDireccion.SelectedItem = -1;
            errorIdenticacion.Clear();
            errorNombre.Clear();
        }
    }
}

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
    public partial class frmPila : Form
    {
        PilaCDT cdts = new PilaCDT();
        int idCDT = 1;
        public frmPila()
        {
            InitializeComponent();
        }

        //Eventos Botones
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.Text.Length == 0 || cmbMesApertura.Text.Length == 0)
                {
                    throw new FormatException();
                }

                if (errorIdentificacion.GetError(txtIdCliente) != "" || errorNombre.GetError(txtNombre) != "" ||
                    errorValorCDT.GetError(txtValorCDT) != "" || errorTiempo.GetError(txtTiempo) != "")
                {
                    MessageBox.Show("Errores en algunos campos");
                    return;
                }

                CDT cdt = new CDT(idCDT, txtIdCliente.Text, txtNombre.Text, txtDireccion.Text, Convert.ToInt32(cmbEstrato.Text), cmbCategoria.Text, cmbMesApertura.Text, Convert.ToInt32(txtTiempo.Text), Convert.ToDouble(txtValorCDT.Text), dtpFechaPago.Value);
                cdts.agregarCDT(cdt);
                idCDT += 1;
                CDT.reporte += cdt.valorTotal;
                AgregarFilas();
                limpiar();
                txtIdCliente.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor total en pagos de los CDTs \n " + CDT.reporte.ToString(), "Reporte");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CDT primerCDT = cdts.obtenerPrimerCDT();
                cdts.eliminarCDT();
                CDT.reporte -= primerCDT.valorTotal;
                AgregarFilas();
                txtIdCliente.Focus();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No hay elementos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmEstructura estructura = new frmEstructura();
            this.Close();
            estructura.Show();
        }

        //Eventos cambio te texto
        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            if (isNumero(txtTiempo, errorTiempo))
            {
                if (txtValorCDT.Text.Length > 0 && errorValorCDT.GetError(txtValorCDT) == "" && errorTiempo.GetError(txtTiempo) == "")
                {
                    calcularValorTotal();
                }
                else
                {
                    txtValorTotal.Clear();
                }
            }
            else
            {
                txtValorTotal.Clear();
            }
        }

        private void txtValorCDT_TextChanged(object sender, EventArgs e)
        {
            if (isNumero(txtValorCDT, errorValorCDT))
            {
                if (txtTiempo.Text.Length > 0 && errorValorCDT.GetError(txtValorCDT) == "" && errorTiempo.GetError(txtTiempo) == "")
                {
                    calcularValorTotal();
                }
                else
                {
                    txtValorTotal.Clear();
                }
            }
            else
            {
                txtValorTotal.Clear();
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            isNumero(txtIdCliente, errorIdentificacion);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            isLetra(txtNombre, errorNombre);
        }

        //Funciones
        private void AgregarFilas()
        {
            dgvCDTs.Rows.Clear();
            Stack<CDT> listaCDTS = cdts.getCdts();
            foreach (var cdt in listaCDTS)
            {
                int fila = dgvCDTs.Rows.Count;
                dgvCDTs.Rows.Add();
                dgvCDTs[0, fila].Value = cdt.idCDT.ToString();
                dgvCDTs[1, fila].Value = cdt.idCliente;
                dgvCDTs[2, fila].Value = cdt.nombreCliente;
                dgvCDTs[3, fila].Value = cdt.estratoCliente.ToString();
                dgvCDTs[4, fila].Value = cdt.direccionCliente;
                dgvCDTs[5, fila].Value = cdt.valorCDT.ToString();
                dgvCDTs[6, fila].Value = cdt.categoria;
                dgvCDTs[7, fila].Value = cdt.mesApertura;
                dgvCDTs[8, fila].Value = cdt.tiempoMeses.ToString();
                dgvCDTs[9, fila].Value = cdt.valorTotal.ToString();
                dgvCDTs[10, fila].Value = cdt.fechaPago.ToString();
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
                        error.SetError(txtBox, "Solo se admiten numeros");
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
                foreach (char cararter in txtBox.Text)
                {
                    if (!char.IsLetter(cararter) && cararter != ' ')
                    {
                        error.SetError(txtBox, "Solo se aceptan letras");
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

        private void calcularValorTotal()
        {
            float valorTotal = 0;
            if ((Convert.ToInt32(txtTiempo.Text) > 0) && (Convert.ToInt32(txtTiempo.Text) < 12))
            {
                valorTotal = (Convert.ToInt64(txtValorCDT.Text)) + (Convert.ToInt64(txtValorCDT.Text) * 0.002f * Convert.ToInt32(txtTiempo.Text));
            }
            else if ((Convert.ToInt32(txtTiempo.Text) >= 12) && (Convert.ToInt32(txtTiempo.Text) < 26))
            {
                valorTotal = (Convert.ToInt64(txtValorCDT.Text)) + (Convert.ToInt64(txtValorCDT.Text) * 0.002f * Convert.ToInt32(txtTiempo.Text));
            }
            else if (Convert.ToInt32(txtTiempo.Text) > 25)
            {
                valorTotal = (Convert.ToInt64(txtValorCDT.Text)) + (Convert.ToInt64(txtValorCDT.Text) * 0.002f * Convert.ToInt32(txtTiempo.Text));
            }

            txtValorTotal.Text = valorTotal.ToString();
        }

        private void limpiar()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtValorCDT.Clear();
            txtTiempo.Clear();
            txtValorCDT.Clear();
            cmbEstrato.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbMesApertura.SelectedIndex = -1;

            errorIdentificacion.Clear();
            errorNombre.Clear();
            errorValorCDT.Clear();
            errorTiempo.Clear();
        }

    }
}

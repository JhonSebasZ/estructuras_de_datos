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
    public partial class frmEstudiantes : Form
    {
        ListaEstudiante estudiantes = new ListaEstudiante();
        string idEstudiante = "";
        public frmEstudiantes()
        {
            InitializeComponent();
            lbEliminar.Enabled = false;
            txtBuscar.Enabled = false;

            tsMenu.Cursor = Cursors.Hand;
        }

        // Eventos click
        private void lbRegistrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string tipoID = cmbTipoID.Text;
                string ID = txtID.Text;
                string nombre = txtNombre.Text;
                int estrato = Convert.ToInt32(cmbEstrato.Text);
                int edad = Convert.ToInt32(txtEdad.Text);
                string voto = rdbSi.Checked ? "Si" : "No";
                DateTime fecha = dtpFecha.Value;

                Estudiante estudiante = new Estudiante(tipoID, ID, nombre, edad, estrato, voto, fecha);
                if (estudiantes.Consultar(ID) != null)
                {
                    MessageBox.Show("El Estudiante ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                estudiantes.Registrar(estudiante);
                mostrar();
                limpiarDatos();
                txtBuscar.Enabled = true;
                txtBuscar.BackColor = Color.AliceBlue;
            }
        }

        private void lbEliminar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = estudiantes.Consultar(idEstudiante);
            DialogResult resultado = MessageBox.Show("Confirmar eliminación", "eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                estudiantes.Eliminar(estudiante);
                limpiarDatos();
                txtBuscar.Clear();
                lbEliminar.Enabled = false;
                mostrar();
            }
            else
            {
                txtBuscar.Clear();
                limpiarDatos();
            }
            limpiarDatos();
        }

        private void lbSalir_Click(object sender, EventArgs e)
        {
            frmEstructura estructura = new frmEstructura();
            this.Close();
            estructura.Show();
        }

        // Evento Enter txtBuscar
        private void txtBusrcar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    int id = Convert.ToInt32(txtBuscar.Text);
                    Estudiante estudiante = estudiantes.Consultar(txtBuscar.Text);
                    if (estudiante != null)
                    {
                        cmbTipoID.Text = estudiante.TipoID;
                        txtID.Text = estudiante.ID;
                        txtNombre.Text = estudiante.NombreApellido;
                        cmbEstrato.Text = estudiante.Estrato.ToString();
                        txtEdad.Text = estudiante.Edad.ToString();
                        dtpFecha.Value = estudiante.FechaRegistro;
                        if (estudiante.Voto == "si")
                        {
                            rdbSi.Checked = true;
                        }
                        else
                        {
                            rdbNo.Checked = true;
                        }
                        lbEliminar.Enabled = true;
                        idEstudiante = txtBuscar.Text;
                        txtBuscar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("estudiante no encontrado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarDatos();
                        txtBuscar.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Identificación invalida", "fallo identificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarDatos();
                    txtBuscar.Focus();
                }
            }
        }

        // Evento Change del campo cmbTipoID
        private void cmbTipoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoID.Text == "TI")
            {
                grbVoto.Enabled = false;
            }
            else
            {
                grbVoto.Enabled = true;
            }
        }

        // Validaciones de los campos
        private bool validarCampoTxt(TextBox txtBox, ErrorProvider err)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                err.SetError(txtBox, "Campo obligatorio");
                return false;
            }
            else
            {
                err.Clear();
            }
            return true;
        }

        private bool validarCampoCmb(ComboBox cmbBox, ErrorProvider err)
        {
            if (string.IsNullOrEmpty(cmbBox.Text))
            {
                err.SetError(cmbBox, "Campo obligatorio");
                return false;
            }
            else
            {
                err.Clear();
            }
            return true;
        }

        private bool validar()
        {
            bool tipoid;
            bool id = false;
            bool nombre = false;
            bool estrato;
            bool edad = false;
            bool voto = false;
            if (validarCampoTxt(txtID, errorID))
            {
                if (isNumero(txtID, errorID))
                {
                    id = isNumero(txtID, errorID);
                }
                else
                {
                    txtID.Focus();
                }
            }

            if (validarCampoTxt(txtEdad, errorEdad) && validarEdad())
            {
                edad = isNumero(txtEdad, errorEdad);
            }

            if (validarCampoTxt(txtNombre, errorNombre))
            {
                nombre = isLetra(txtNombre, errorNombre);
            }

            tipoid = validarCampoCmb(cmbTipoID, errorTipoID);
            estrato = validarCampoCmb(cmbEstrato, errorEstrato);

            if (cmbTipoID.Text != "TI")
            {
                if (rdbSi.Checked == false && rdbNo.Checked == false)
                {
                    errorVoto.SetError(grbVoto, "Campo Obligatorio");
                }
                else
                {
                    errorVoto.Clear();
                    voto = true;
                }
            }
            else
            {
                voto = true;
            }
            return (tipoid && id && nombre && estrato && edad && voto);
        }
        // validacion de edad
        private bool validarEdad()
        {
            if (Convert.ToInt32(txtEdad.Text) < 1)
            {
                errorEdad.SetError(txtEdad, "Edad incorrecta");
                return false;
            }
            else if (cmbTipoID.Text == "TI" && Convert.ToInt32(txtEdad.Text) > 17)
            {
                errorEdad.SetError(txtEdad, "La edad deve ser menor a 18");
                return false;
            }
            else if (cmbTipoID.Text != "TI" && Convert.ToInt32(txtEdad.Text) < 18)
            {
                errorEdad.SetError(txtEdad, "La edad deve ser mayor a 17");
                return false;
            }
            errorEdad.Clear();
            return true;
        }

        // Funciones
        private void mostrar()
        {
            dgvDatos.Rows.Clear();
            foreach (Estudiante es in estudiantes.GetEstudiantes())
            {
                int fila = dgvDatos.Rows.Count;
                dgvDatos.Rows.Add();
                dgvDatos[0, fila].Value = es.TipoID;
                dgvDatos[1, fila].Value = es.ID;
                dgvDatos[2, fila].Value = es.NombreApellido;
                dgvDatos[3, fila].Value = es.Edad;
                dgvDatos[4, fila].Value = es.Estrato;
                dgvDatos[5, fila].Value = es.Voto;
                dgvDatos[6, fila].Value = es.FechaRegistro.ToString();
            }
        }

        private bool isNumero(TextBox txtBox, ErrorProvider err)
        {
            foreach (char caracter in txtBox.Text)
            {
                if (!char.IsNumber(caracter))
                {
                    err.SetError(txtBox, "Solo se aceptan números");
                    return false;
                }
                else
                {
                    err.Clear();
                }
            }
            return true;
        }

        private bool isLetra(TextBox txtBox, ErrorProvider err)
        {
            foreach (char caracter in txtBox.Text)
            {
                if (!char.IsLetter(caracter) && caracter != ' ')
                {
                    err.SetError(txtBox, "Solo aceptan letras");
                    return false;
                }
                else
                {
                    err.Clear();
                }
            }
            return true;
        }

        private void limpiarDatos()
        {
            cmbTipoID.SelectedIndex = -1;
            txtID.Clear();
            txtNombre.Clear();
            cmbEstrato.SelectedIndex = -1;
            txtEdad.Clear();
            rdbSi.Checked = false;
            rdbNo.Checked = false;
            txtID.Focus();
        }
    }
}

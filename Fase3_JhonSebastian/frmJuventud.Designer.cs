namespace Fase3_JhonSebastian
{
    partial class frmjuventud
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
            this.components = new System.ComponentModel.Container();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.dtpActualizacion = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dgvJovenes = new System.Windows.Forms.DataGridView();
            this.colIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuxilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorIdenticacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJovenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdenticacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(130, 64);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(208, 23);
            this.txtIdentificacion.TabIndex = 0;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(212, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(453, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Maculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(82, 113);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(108, 23);
            this.cmbSexo.TabIndex = 6;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Items.AddRange(new object[] {
            "Comuna 1",
            "Comuna 2",
            "Comuna 3",
            "Comuna 4",
            "Comuna 5",
            "Comuna 6",
            "Comuna 7",
            "Comuna 8",
            "Comuna 9",
            "Comuna 10"});
            this.cmbDireccion.Location = new System.Drawing.Point(289, 113);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(121, 23);
            this.cmbDireccion.TabIndex = 7;
            // 
            // dtpActualizacion
            // 
            this.dtpActualizacion.Location = new System.Drawing.Point(498, 113);
            this.dtpActualizacion.Name = "dtpActualizacion";
            this.dtpActualizacion.Size = new System.Drawing.Size(200, 23);
            this.dtpActualizacion.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(15, 203);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 34);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(130, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReporte.Location = new System.Drawing.Point(226, 203);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 34);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dgvJovenes
            // 
            this.dgvJovenes.AllowUserToAddRows = false;
            this.dgvJovenes.AllowUserToDeleteRows = false;
            this.dgvJovenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJovenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdentificacion,
            this.colNombre,
            this.colSexo,
            this.colDireccion,
            this.colAuxilio,
            this.colFechaActualizacion});
            this.dgvJovenes.Location = new System.Drawing.Point(15, 259);
            this.dgvJovenes.Name = "dgvJovenes";
            this.dgvJovenes.ReadOnly = true;
            this.dgvJovenes.RowTemplate.Height = 25;
            this.dgvJovenes.Size = new System.Drawing.Size(754, 228);
            this.dgvJovenes.TabIndex = 12;
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.HeaderText = "Identificacion";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 170;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // colAuxilio
            // 
            this.colAuxilio.HeaderText = "Auxilio";
            this.colAuxilio.Name = "colAuxilio";
            this.colAuxilio.ReadOnly = true;
            // 
            // colFechaActualizacion
            // 
            this.colFechaActualizacion.HeaderText = "Actualización";
            this.colFechaActualizacion.Name = "colFechaActualizacion";
            this.colFechaActualizacion.ReadOnly = true;
            this.colFechaActualizacion.Width = 140;
            // 
            // errorIdenticacion
            // 
            this.errorIdenticacion.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(263, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Secretaria de juventud";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(623, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmjuventud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(781, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvJovenes);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpActualizacion);
            this.Controls.Add(this.cmbDireccion);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificacion);
            this.MaximizeBox = false;
            this.Name = "frmjuventud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alcaldia Huila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJovenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdenticacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIdentificacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private ComboBox cmbSexo;
        private ComboBox cmbDireccion;
        private DateTimePicker dtpActualizacion;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnReporte;
        private DataGridView dgvJovenes;
        private DataGridViewTextBoxColumn colIdentificacion;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colAuxilio;
        private DataGridViewTextBoxColumn colFechaActualizacion;
        private ErrorProvider errorIdenticacion;
        private ErrorProvider errorNombre;
        private Label label5;
        private Button btnSalir;
    }
}
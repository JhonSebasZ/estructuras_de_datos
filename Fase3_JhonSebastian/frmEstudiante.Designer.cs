namespace Fase3_JhonSebastian
{
    partial class frmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.lbRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbEliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbSalir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grbVoto = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colTipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errorTipoID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstrato = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEdad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorVoto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsMenu.SuspendLayout();
            this.grbVoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbRegistrar,
            this.toolStripSeparator3,
            this.lbEliminar,
            this.toolStripSeparator2,
            this.lbSalir,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.txtBuscar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenu.Size = new System.Drawing.Size(764, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // lbRegistrar
            // 
            this.lbRegistrar.Name = "lbRegistrar";
            this.lbRegistrar.Size = new System.Drawing.Size(78, 22);
            this.lbRegistrar.Text = "Registrar";
            this.lbRegistrar.Click += new System.EventHandler(this.lbRegistrar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lbEliminar
            // 
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(74, 22);
            this.lbEliminar.Text = "Eliminar";
            this.lbEliminar.Click += new System.EventHandler(this.lbEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbSalir
            // 
            this.lbSalir.Name = "lbSalir";
            this.lbSalir.Size = new System.Drawing.Size(44, 22);
            this.lbSalir.Text = "Salir";
            this.lbSalir.Click += new System.EventHandler(this.lbSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(398, 22);
            this.toolStripLabel1.Text = "                                                                                 " +
    "                ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Lupa";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 25);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusrcar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo ID";
            // 
            // cmbTipoID
            // 
            this.cmbTipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT"});
            this.cmbTipoID.Location = new System.Drawing.Point(96, 66);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(67, 23);
            this.cmbTipoID.TabIndex = 2;
            this.cmbTipoID.SelectedIndexChanged += new System.EventHandler(this.cmbTipoID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(217, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(184, 23);
            this.txtID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(217, 122);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(76, 23);
            this.txtEdad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estrato";
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbEstrato.Location = new System.Drawing.Point(96, 122);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(67, 23);
            this.cmbEstrato.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(476, 119);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 9;
            // 
            // grbVoto
            // 
            this.grbVoto.Controls.Add(this.rdbNo);
            this.grbVoto.Controls.Add(this.rdbSi);
            this.grbVoto.Location = new System.Drawing.Point(336, 114);
            this.grbVoto.Name = "grbVoto";
            this.grbVoto.Size = new System.Drawing.Size(117, 58);
            this.grbVoto.TabIndex = 10;
            this.grbVoto.TabStop = false;
            this.grbVoto.Text = "Votó";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(58, 22);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(41, 19);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(15, 22);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 19);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoID,
            this.colID,
            this.colNombre,
            this.colEdad,
            this.colEstrato,
            this.colVoto,
            this.colRegistro});
            this.dgvDatos.Location = new System.Drawing.Point(0, 192);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(764, 246);
            this.dgvDatos.TabIndex = 11;
            // 
            // colTipoID
            // 
            this.colTipoID.HeaderText = "Tipo ID";
            this.colTipoID.Name = "colTipoID";
            this.colTipoID.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 120;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 120;
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            // 
            // colEstrato
            // 
            this.colEstrato.HeaderText = "Estrato";
            this.colEstrato.Name = "colEstrato";
            this.colEstrato.ReadOnly = true;
            // 
            // colVoto
            // 
            this.colVoto.HeaderText = "Votó";
            this.colVoto.Name = "colVoto";
            this.colVoto.ReadOnly = true;
            // 
            // colRegistro
            // 
            this.colRegistro.HeaderText = "F. Registro";
            this.colRegistro.Name = "colRegistro";
            this.colRegistro.ReadOnly = true;
            this.colRegistro.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(492, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 23);
            this.txtNombre.TabIndex = 13;
            // 
            // errorTipoID
            // 
            this.errorTipoID.ContainerControl = this;
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorEstrato
            // 
            this.errorEstrato.ContainerControl = this;
            // 
            // errorEdad
            // 
            this.errorEdad.ContainerControl = this;
            // 
            // errorVoto
            // 
            this.errorVoto.ContainerControl = this;
            // 
            // errorBuscar
            // 
            this.errorBuscar.ContainerControl = this;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 441);
            this.ControlBox = false;
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.grbVoto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmEstudiantes";
            this.Text = "Estudiantes";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grbVoto.ResumeLayout(false);
            this.grbVoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsMenu;
        private ToolStripLabel lbRegistrar;
        private ToolStripLabel lbEliminar;
        private Label label1;
        private ComboBox cmbTipoID;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private ComboBox cmbEstrato;
        private DateTimePicker dtpFecha;
        private GroupBox grbVoto;
        private RadioButton rdbNo;
        private RadioButton rdbSi;
        private DataGridView dgvDatos;
        private Label label5;
        private TextBox txtNombre;
        private DataGridViewTextBoxColumn colTipoID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colEstrato;
        private DataGridViewTextBoxColumn colVoto;
        private DataGridViewTextBoxColumn colRegistro;
        private ErrorProvider errorTipoID;
        private ErrorProvider errorID;
        private ErrorProvider errorNombre;
        private ErrorProvider errorEstrato;
        private ErrorProvider errorEdad;
        private ErrorProvider errorVoto;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox txtBuscar;
        private ErrorProvider errorBuscar;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel lbSalir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
    }
}
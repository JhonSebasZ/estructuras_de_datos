namespace Fase3_JhonSebastian
{
    partial class frmPila
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dgvCDTs = new System.Windows.Forms.DataGridView();
            this.colCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMesApertura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorCDT = new System.Windows.Forms.TextBox();
            this.errorIdentificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorValorCDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTiempo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValorCDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(30, 188);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 34);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(136, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Blue;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReporte.Location = new System.Drawing.Point(242, 188);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 34);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(548, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes Apertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(296, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(670, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(548, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estrato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(295, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 38);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tiempo \r\n(meses)";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdCliente.BackColor = System.Drawing.Color.White;
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdCliente.Location = new System.Drawing.Point(126, 30);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(147, 22);
            this.txtIdCliente.TabIndex = 0;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(365, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 22);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
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
            this.cmbEstrato.Location = new System.Drawing.Point(609, 31);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(46, 23);
            this.cmbEstrato.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Residencia",
            "Comercial",
            "Urbano"});
            this.cmbCategoria.Location = new System.Drawing.Point(365, 81);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(147, 25);
            this.cmbCategoria.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(739, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(124, 22);
            this.txtDireccion.TabIndex = 16;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaPago.Location = new System.Drawing.Point(548, 129);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(315, 27);
            this.dtpFechaPago.TabIndex = 18;
            // 
            // dgvCDTs
            // 
            this.dgvCDTs.AllowUserToAddRows = false;
            this.dgvCDTs.AllowUserToDeleteRows = false;
            this.dgvCDTs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCDTs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCDTs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCDTs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDTs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCDT,
            this.colIdentificacion,
            this.colNombre,
            this.colEstrato,
            this.colDireccion,
            this.colValorCDT,
            this.colCategoria,
            this.colMesApertura,
            this.colTiempo,
            this.colValorTotal,
            this.colPago});
            this.dgvCDTs.Location = new System.Drawing.Point(2, 242);
            this.dgvCDTs.Name = "dgvCDTs";
            this.dgvCDTs.ReadOnly = true;
            this.dgvCDTs.RowHeadersVisible = false;
            this.dgvCDTs.RowTemplate.Height = 25;
            this.dgvCDTs.Size = new System.Drawing.Size(932, 276);
            this.dgvCDTs.TabIndex = 19;
            // 
            // colCDT
            // 
            this.colCDT.HeaderText = "#CDT";
            this.colCDT.Name = "colCDT";
            this.colCDT.ReadOnly = true;
            this.colCDT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCDT.Width = 50;
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.HeaderText = "Identificación";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.ReadOnly = true;
            this.colIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEstrato
            // 
            this.colEstrato.HeaderText = "Estrato";
            this.colEstrato.Name = "colEstrato";
            this.colEstrato.ReadOnly = true;
            this.colEstrato.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEstrato.Width = 50;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDireccion.Width = 90;
            // 
            // colValorCDT
            // 
            this.colValorCDT.HeaderText = "ValorCDT";
            this.colValorCDT.Name = "colValorCDT";
            this.colValorCDT.ReadOnly = true;
            this.colValorCDT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCategoria.Width = 90;
            // 
            // colMesApertura
            // 
            this.colMesApertura.HeaderText = "Apertura";
            this.colMesApertura.Name = "colMesApertura";
            this.colMesApertura.ReadOnly = true;
            this.colMesApertura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMesApertura.Width = 70;
            // 
            // colTiempo
            // 
            this.colTiempo.HeaderText = "T. Meses";
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            this.colTiempo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTiempo.Width = 50;
            // 
            // colValorTotal
            // 
            this.colValorTotal.HeaderText = "V. Total";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            this.colValorTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPago
            // 
            this.colPago.HeaderText = "F. Pago";
            this.colPago.Name = "colPago";
            this.colPago.ReadOnly = true;
            this.colPago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPago.Width = 130;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(365, 129);
            this.txtValorTotal.Multiline = true;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 20;
            // 
            // txtTiempo
            // 
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTiempo.Location = new System.Drawing.Point(126, 126);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(75, 22);
            this.txtTiempo.TabIndex = 21;
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(286, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Valor Total";
            // 
            // cmbMesApertura
            // 
            this.cmbMesApertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesApertura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMesApertura.FormattingEnabled = true;
            this.cmbMesApertura.Items.AddRange(new object[] {
            "Enero",
            "Febreo",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto ",
            "Septiembre",
            "Octubre",
            "Nobiembre",
            "Diciembre"});
            this.cmbMesApertura.Location = new System.Drawing.Point(644, 81);
            this.cmbMesApertura.Name = "cmbMesApertura";
            this.cmbMesApertura.Size = new System.Drawing.Size(219, 25);
            this.cmbMesApertura.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Valor CDT";
            // 
            // txtValorCDT
            // 
            this.txtValorCDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorCDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorCDT.Location = new System.Drawing.Point(126, 81);
            this.txtValorCDT.Name = "txtValorCDT";
            this.txtValorCDT.Size = new System.Drawing.Size(146, 22);
            this.txtValorCDT.TabIndex = 25;
            this.txtValorCDT.TextChanged += new System.EventHandler(this.txtValorCDT_TextChanged);
            // 
            // errorIdentificacion
            // 
            this.errorIdentificacion.ContainerControl = this;
            // 
            // errorValorCDT
            // 
            this.errorValorCDT.ContainerControl = this;
            // 
            // errorTiempo
            // 
            this.errorTiempo.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(788, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(936, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtValorCDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMesApertura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.dgvCDTs);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.MaximizeBox = false;
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos Aliados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDTs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValorCDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnReporte;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtIdCliente;
        private TextBox txtNombre;
        private ComboBox cmbEstrato;
        private ComboBox cmbCategoria;
        private TextBox txtDireccion;
        private DateTimePicker dtpFechaPago;
        private DataGridView dgvCDTs;
        private TextBox txtValorTotal;
        private TextBox txtTiempo;
        private Label label9;
        private ComboBox cmbMesApertura;
        private Label label1;
        private TextBox txtValorCDT;
        private ErrorProvider errorIdentificacion;
        private ErrorProvider errorValorCDT;
        private ErrorProvider errorTiempo;
        private ErrorProvider errorNombre;
        private DataGridViewTextBoxColumn colCDT;
        private DataGridViewTextBoxColumn colIdentificacion;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colEstrato;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colValorCDT;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colMesApertura;
        private DataGridViewTextBoxColumn colTiempo;
        private DataGridViewTextBoxColumn colValorTotal;
        private DataGridViewTextBoxColumn colPago;
        private Button btnSalir;
    }
}
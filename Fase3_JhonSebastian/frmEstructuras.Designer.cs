namespace Fase3_JhonSebastian
{
    partial class frmEstructura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPila = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPila
            // 
            this.btnPila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPila.FlatAppearance.BorderSize = 0;
            this.btnPila.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPila.Location = new System.Drawing.Point(36, 86);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(75, 33);
            this.btnPila.TabIndex = 0;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnCola
            // 
            this.btnCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCola.FlatAppearance.BorderSize = 0;
            this.btnCola.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCola.Location = new System.Drawing.Point(149, 86);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(75, 33);
            this.btnCola.TabIndex = 1;
            this.btnCola.Text = "Cola";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnLista
            // 
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLista.Location = new System.Drawing.Point(261, 86);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 33);
            this.btnLista.TabIndex = 2;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(289, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escoja una opción del menú";
            // 
            // frmEstructura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnPila);
            this.Name = "frmEstructura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPila;
        private Button btnCola;
        private Button btnLista;
        private Button btnSalir;
        private Label label1;
    }
}
namespace clienteEscritorio.Usuario
{
    partial class frmPantalla
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlertas = new System.Windows.Forms.DataGridView();
            this.lblMensajeUno = new System.Windows.Forms.Label();
            this.lblMensajeDos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(16, 128);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "No. Artículos";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(13, 147);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(72, 20);
            this.nudCantidad.TabIndex = 12;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(16, 89);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(175, 20);
            this.txtArticulo.TabIndex = 11;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(13, 72);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(100, 13);
            this.lblArticulo.TabIndex = 10;
            this.lblArticulo.Text = "Nombre del artículo";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Location = new System.Drawing.Point(13, 17);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(119, 13);
            this.lblCombo.TabIndex = 9;
            this.lblCombo.Text = "Opción de visualización";
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "Ventas por artículo",
            "Ventas globales",
            "Artículos más vendidos",
            "Productos existentes"});
            this.cmbOpciones.Location = new System.Drawing.Point(13, 36);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(232, 21);
            this.cmbOpciones.TabIndex = 8;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(19, 173);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.ReadOnly = true;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(567, 278);
            this.dataGridViewPrincipal.TabIndex = 7;
            // 
            // dataGridViewAlertas
            // 
            this.dataGridViewAlertas.AllowUserToDeleteRows = false;
            this.dataGridViewAlertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAlertas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlertas.Location = new System.Drawing.Point(592, 89);
            this.dataGridViewAlertas.Name = "dataGridViewAlertas";
            this.dataGridViewAlertas.ReadOnly = true;
            this.dataGridViewAlertas.Size = new System.Drawing.Size(313, 362);
            this.dataGridViewAlertas.TabIndex = 14;
            // 
            // lblMensajeUno
            // 
            this.lblMensajeUno.AutoSize = true;
            this.lblMensajeUno.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeUno.Location = new System.Drawing.Point(653, 36);
            this.lblMensajeUno.Name = "lblMensajeUno";
            this.lblMensajeUno.Size = new System.Drawing.Size(190, 13);
            this.lblMensajeUno.TabIndex = 15;
            this.lblMensajeUno.Text = "Hay menos de 100 productos en stock";
            // 
            // lblMensajeDos
            // 
            this.lblMensajeDos.AutoSize = true;
            this.lblMensajeDos.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDos.Location = new System.Drawing.Point(664, 60);
            this.lblMensajeDos.Name = "lblMensajeDos";
            this.lblMensajeDos.Size = new System.Drawing.Size(154, 13);
            this.lblMensajeDos.TabIndex = 16;
            this.lblMensajeDos.Text = "Realiza un pedido al proveedor";
            // 
            // frmPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 463);
            this.Controls.Add(this.lblMensajeDos);
            this.Controls.Add(this.lblMensajeUno);
            this.Controls.Add(this.dataGridViewAlertas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Name = "frmPantalla";
            this.Text = "Pantalla principal";
            this.Load += new System.EventHandler(this.frmPantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.DataGridView dataGridViewAlertas;
        private System.Windows.Forms.Label lblMensajeUno;
        private System.Windows.Forms.Label lblMensajeDos;
    }
}
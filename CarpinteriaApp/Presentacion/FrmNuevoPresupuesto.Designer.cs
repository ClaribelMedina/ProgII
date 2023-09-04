namespace CarpinteriaApp.Presentacion
{
    partial class FrmNuevoPresupuesto
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
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Location = new System.Drawing.Point(46, 22);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(81, 13);
            this.lblPresupuesto.TabIndex = 0;
            this.lblPresupuesto.Text = "Presupuesto N°";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(46, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(46, 101);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(46, 146);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(70, 13);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "Descuento %";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(146, 62);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(444, 190);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(146, 143);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(146, 105);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colid,
            this.ColProducto,
            this.ColPrecio,
            this.ColCantidad,
            this.ColAcciones});
            this.dgvDetalle.Location = new System.Drawing.Point(26, 229);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(639, 102);
            this.dgvDetalle.TabIndex = 8;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(26, 190);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(396, 21);
            this.cboProducto.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(565, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(565, 381);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(565, 355);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 12;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(485, 362);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(485, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(244, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(359, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Colid
            // 
            this.Colid.HeaderText = "Id";
            this.Colid.Name = "Colid";
            this.Colid.ReadOnly = true;
            this.Colid.Visible = false;
            this.Colid.Width = 200;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 290;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Quitar";
            this.ColAcciones.Width = 105;
            // 
            // FrmNuevoPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPresupuesto);
            this.Name = "FrmNuevoPresupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.FrmPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}
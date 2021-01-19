namespace Tarea5_Facturador
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCajero = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descuento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.codigoProducto = new System.Windows.Forms.TextBox();
            this.dataGridViewFacturador = new System.Windows.Forms.DataGridView();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.totalCantidadProductos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.totalITBIS = new System.Windows.Forms.TextBox();
            this.Descuentos = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cajero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código Producto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(879, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio";
            // 
            // cboCajero
            // 
            this.cboCajero.FormattingEnabled = true;
            this.cboCajero.Items.AddRange(new object[] {
            "Carme Soto",
            "Natalia Sanchez",
            "Fernando Bordas",
            "Miguel Beltre",
            "Angel Luna"});
            this.cboCajero.Location = new System.Drawing.Point(152, 26);
            this.cboCajero.Name = "cboCajero";
            this.cboCajero.Size = new System.Drawing.Size(135, 24);
            this.cboCajero.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(152, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(135, 22);
            this.dtpFecha.TabIndex = 8;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Items.AddRange(new object[] {
            "Caja",
            "Virtual"});
            this.cboTipoCliente.Location = new System.Drawing.Point(152, 103);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(135, 24);
            this.cboTipoCliente.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descuento);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nombreProducto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.precio);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.cantidad);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.descripcion);
            this.panel1.Controls.Add(this.codigoProducto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 183);
            this.panel1.TabIndex = 10;
            // 
            // descuento
            // 
            this.descuento.Location = new System.Drawing.Point(507, 73);
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(133, 22);
            this.descuento.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(406, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Descuento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Precio";
            // 
            // nombreProducto
            // 
            this.nombreProducto.Location = new System.Drawing.Point(160, 79);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(171, 22);
            this.nombreProducto.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre Comercial";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(507, 136);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(133, 22);
            this.precio.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(913, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 44);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(160, 133);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(171, 22);
            this.cantidad.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(913, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 45);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(507, 23);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(336, 22);
            this.descripcion.TabIndex = 12;
            // 
            // codigoProducto
            // 
            this.codigoProducto.Location = new System.Drawing.Point(160, 23);
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Size = new System.Drawing.Size(171, 22);
            this.codigoProducto.TabIndex = 11;
            // 
            // dataGridViewFacturador
            // 
            this.dataGridViewFacturador.AllowUserToAddRows = false;
            this.dataGridViewFacturador.AllowUserToDeleteRows = false;
            this.dataGridViewFacturador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCantidad,
            this.dgvCodigo,
            this.dgvNombreProducto,
            this.dgvDescripcion,
            this.dgvDescuento,
            this.dgvPrecio,
            this.dgvITBIS});
            this.dataGridViewFacturador.Location = new System.Drawing.Point(12, 377);
            this.dataGridViewFacturador.Name = "dataGridViewFacturador";
            this.dataGridViewFacturador.ReadOnly = true;
            this.dataGridViewFacturador.Size = new System.Drawing.Size(869, 274);
            this.dataGridViewFacturador.TabIndex = 11;
            this.dataGridViewFacturador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvCantidad
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCantidad.HeaderText = "Cantidad";
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.ReadOnly = true;
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Código";
            this.dgvCodigo.Name = "dgvCodigo";
            this.dgvCodigo.ReadOnly = true;
            // 
            // dgvNombreProducto
            // 
            this.dgvNombreProducto.HeaderText = "Nombre Comercial";
            this.dgvNombreProducto.Name = "dgvNombreProducto";
            this.dgvNombreProducto.ReadOnly = true;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "Descripción";
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            // 
            // dgvDescuento
            // 
            this.dgvDescuento.HeaderText = "Descuento";
            this.dgvDescuento.Name = "dgvDescuento";
            this.dgvDescuento.ReadOnly = true;
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.ReadOnly = true;
            // 
            // dgvITBIS
            // 
            this.dgvITBIS.HeaderText = "ITBIS";
            this.dgvITBIS.Name = "dgvITBIS";
            this.dgvITBIS.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea5_Facturador.Properties.Resources.icono;
            this.pictureBox1.Location = new System.Drawing.Point(855, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(926, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 44);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(926, 552);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 44);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 729);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cantidad de Productos:";
            // 
            // totalCantidadProductos
            // 
            this.totalCantidadProductos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.totalCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCantidadProductos.ForeColor = System.Drawing.Color.Blue;
            this.totalCantidadProductos.Location = new System.Drawing.Point(208, 707);
            this.totalCantidadProductos.Name = "totalCantidadProductos";
            this.totalCantidadProductos.Size = new System.Drawing.Size(136, 42);
            this.totalCantidadProductos.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 676);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Subtotal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(408, 705);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total ITBIS (18%):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(448, 742);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Descuentos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(487, 797);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Total:";
            // 
            // subTotal
            // 
            this.subTotal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.subTotal.ForeColor = System.Drawing.Color.Red;
            this.subTotal.Location = new System.Drawing.Point(547, 670);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(138, 22);
            this.subTotal.TabIndex = 25;
            // 
            // totalITBIS
            // 
            this.totalITBIS.BackColor = System.Drawing.SystemColors.MenuBar;
            this.totalITBIS.ForeColor = System.Drawing.Color.Red;
            this.totalITBIS.Location = new System.Drawing.Point(547, 702);
            this.totalITBIS.Name = "totalITBIS";
            this.totalITBIS.Size = new System.Drawing.Size(138, 22);
            this.totalITBIS.TabIndex = 26;
            // 
            // Descuentos
            // 
            this.Descuentos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Descuentos.ForeColor = System.Drawing.Color.Red;
            this.Descuentos.Location = new System.Drawing.Point(548, 736);
            this.Descuentos.Name = "Descuentos";
            this.Descuentos.Size = new System.Drawing.Size(138, 22);
            this.Descuentos.TabIndex = 27;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.MenuBar;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Green;
            this.total.Location = new System.Drawing.Point(547, 794);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(138, 22);
            this.total.TabIndex = 28;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Green;
            this.labelTotal.Location = new System.Drawing.Point(823, 721);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 44);
            this.labelTotal.TabIndex = 29;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 836);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Descuentos);
            this.Controls.Add(this.totalITBIS);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalCantidadProductos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewFacturador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboCajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facturacion";
            this.Text = "Facturacion  -  Punto de Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCajero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox codigoProducto;
        private System.Windows.Forms.DataGridView dataGridViewFacturador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalCantidadProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox subTotal;
        private System.Windows.Forms.TextBox totalITBIS;
        private System.Windows.Forms.TextBox Descuentos;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox descuento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvITBIS;
        private System.Windows.Forms.Label labelTotal;
    }
}


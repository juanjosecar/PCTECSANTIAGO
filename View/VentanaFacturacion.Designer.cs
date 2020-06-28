namespace PCTECSANTIAGO.View
{
    partial class VentanaFacturacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFacturacion));
            this.dtgTablaFacturacion = new System.Windows.Forms.DataGridView();
            this.tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescripcionServicio = new LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion();
            this.txtCantidad = new LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion();
            this.txtPrecio = new LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion();
            this.txtTecnico = new LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion();
            this.txtCliente = new LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblIDTecnico = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFacturar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscarTecnico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cartaTotalFacturas = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblUserEnSesion = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cartaTotalFacturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTablaFacturacion
            // 
            this.dtgTablaFacturacion.AllowUserToAddRows = false;
            this.dtgTablaFacturacion.AllowUserToDeleteRows = false;
            this.dtgTablaFacturacion.AllowUserToResizeColumns = false;
            this.dtgTablaFacturacion.AllowUserToResizeRows = false;
            this.dtgTablaFacturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTablaFacturacion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgTablaFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTablaFacturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgTablaFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 14.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablaFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTablaFacturacion.ColumnHeadersHeight = 30;
            this.dtgTablaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgTablaFacturacion.ColumnHeadersVisible = false;
            this.dtgTablaFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoServicio,
            this.ColDescripcion,
            this.ColCantidad,
            this.ColPrecio,
            this.ColImporte});
            this.dtgTablaFacturacion.EnableHeadersVisualStyles = false;
            this.dtgTablaFacturacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.dtgTablaFacturacion.Location = new System.Drawing.Point(33, 415);
            this.dtgTablaFacturacion.Name = "dtgTablaFacturacion";
            this.dtgTablaFacturacion.ReadOnly = true;
            this.dtgTablaFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTablaFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTablaFacturacion.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgTablaFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTablaFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTablaFacturacion.Size = new System.Drawing.Size(859, 198);
            this.dtgTablaFacturacion.TabIndex = 33;
            // 
            // tipoServicio
            // 
            this.tipoServicio.HeaderText = "tipoServicio";
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.ReadOnly = true;
            this.tipoServicio.Width = 80;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 423;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 113;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 128;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 34);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sistema de facturacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 42);
            this.label4.TabIndex = 34;
            this.label4.Text = "Facturacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(545, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 37);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tecnico";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(33, 255);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(266, 38);
            this.cmbTipoServicio.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 37);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tipo de servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(322, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 37);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 37);
            this.label7.TabIndex = 53;
            this.label7.Text = "Descripcion del servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(625, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 37);
            this.label8.TabIndex = 55;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label9.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 37);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tipo de servicio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label10.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(112, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(423, 37);
            this.label10.TabIndex = 57;
            this.label10.Text = "Descripcion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label11.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(533, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 37);
            this.label11.TabIndex = 58;
            this.label11.Text = "Cantidad ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label12.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(644, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 37);
            this.label12.TabIndex = 59;
            this.label12.Text = "Precio";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.label13.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(775, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 37);
            this.label13.TabIndex = 60;
            this.label13.Text = "Importe";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(636, 619);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 37);
            this.label14.TabIndex = 67;
            this.label14.Text = "Total";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtDescripcionServicio
            // 
            this.txtDescripcionServicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcionServicio.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionServicio.Location = new System.Drawing.Point(33, 334);
            this.txtDescripcionServicio.Name = "txtDescripcionServicio";
            this.txtDescripcionServicio.Size = new System.Drawing.Size(859, 33);
            this.txtDescripcionServicio.SoloNumeros = false;
            this.txtDescripcionServicio.TabIndex = 74;
            this.txtDescripcionServicio.Validacion = true;
            this.txtDescripcionServicio.TextChanged += new System.EventHandler(this.txtDescripcionServicio_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCantidad.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(329, 255);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(260, 33);
            this.txtCantidad.SoloNumeros = true;
            this.txtCantidad.TabIndex = 73;
            this.txtCantidad.Validacion = true;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(632, 255);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(260, 33);
            this.txtPrecio.SoloNumeros = true;
            this.txtPrecio.TabIndex = 72;
            this.txtPrecio.Validacion = true;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtTecnico
            // 
            this.txtTecnico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTecnico.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnico.Location = new System.Drawing.Point(552, 153);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.ReadOnly = true;
            this.txtTecnico.Size = new System.Drawing.Size(413, 33);
            this.txtTecnico.SoloNumeros = false;
            this.txtTecnico.TabIndex = 71;
            this.txtTecnico.Validacion = true;
            this.txtTecnico.TextChanged += new System.EventHandler(this.txtTecnico_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCliente.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(33, 153);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(413, 33);
            this.txtCliente.SoloNumeros = false;
            this.txtCliente.TabIndex = 70;
            this.txtCliente.Validacion = true;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblValorTotal.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.lblValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.lblValorTotal.Location = new System.Drawing.Point(711, 619);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(181, 37);
            this.lblValorTotal.TabIndex = 75;
            this.lblValorTotal.Text = "COP$ 0";
            // 
            // lblIDTecnico
            // 
            this.lblIDTecnico.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblIDTecnico.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.lblIDTecnico.ForeColor = System.Drawing.Color.White;
            this.lblIDTecnico.Location = new System.Drawing.Point(673, 99);
            this.lblIDTecnico.Name = "lblIDTecnico";
            this.lblIDTecnico.Size = new System.Drawing.Size(99, 37);
            this.lblIDTecnico.TabIndex = 76;
            this.lblIDTecnico.Visible = false;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblIDCliente.Font = new System.Drawing.Font("Poppins Light", 15.25F);
            this.lblIDCliente.ForeColor = System.Drawing.Color.White;
            this.lblIDCliente.Location = new System.Drawing.Point(171, 99);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(99, 37);
            this.lblIDCliente.TabIndex = 77;
            this.lblIDCliente.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PCTECSANTIAGO.Properties.Resources.Imagen_Facturar;
            this.pictureBox2.Location = new System.Drawing.Point(917, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnFacturar.BackColor = System.Drawing.Color.White;
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturar.BorderRadius = 7;
            this.btnFacturar.ButtonText = "        Facturar";
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFacturar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFacturar.Iconimage = global::PCTECSANTIAGO.Properties.Resources.facturar;
            this.btnFacturar.Iconimage_right = null;
            this.btnFacturar.Iconimage_right_Selected = null;
            this.btnFacturar.Iconimage_Selected = null;
            this.btnFacturar.IconMarginLeft = 8;
            this.btnFacturar.IconMarginRight = 0;
            this.btnFacturar.IconRightVisible = true;
            this.btnFacturar.IconRightZoom = 0D;
            this.btnFacturar.IconVisible = true;
            this.btnFacturar.IconZoom = 40D;
            this.btnFacturar.IsTab = false;
            this.btnFacturar.Location = new System.Drawing.Point(918, 566);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Normalcolor = System.Drawing.Color.White;
            this.btnFacturar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnFacturar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFacturar.selected = false;
            this.btnFacturar.Size = new System.Drawing.Size(168, 47);
            this.btnFacturar.TabIndex = 69;
            this.btnFacturar.Text = "        Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnFacturar.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 7;
            this.btnNuevo.ButtonText = "        Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = global::PCTECSANTIAGO.Properties.Resources.erase_50px;
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 8;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 40D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(918, 503);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.White;
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(168, 47);
            this.btnNuevo.TabIndex = 66;
            this.btnNuevo.Text = "        Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnNuevo.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.ButtonText = "            Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::PCTECSANTIAGO.Properties.Resources.deleteItem;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 8;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 25D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(918, 440);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.White;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(168, 47);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "            Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnEliminar.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarItem.BackColor = System.Drawing.Color.White;
            this.btnAgregarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarItem.BorderRadius = 7;
            this.btnAgregarItem.ButtonText = "            Agregar";
            this.btnAgregarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarItem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarItem.Iconimage = global::PCTECSANTIAGO.Properties.Resources.agregarItem;
            this.btnAgregarItem.Iconimage_right = null;
            this.btnAgregarItem.Iconimage_right_Selected = null;
            this.btnAgregarItem.Iconimage_Selected = null;
            this.btnAgregarItem.IconMarginLeft = 8;
            this.btnAgregarItem.IconMarginRight = 0;
            this.btnAgregarItem.IconRightVisible = true;
            this.btnAgregarItem.IconRightZoom = 0D;
            this.btnAgregarItem.IconVisible = true;
            this.btnAgregarItem.IconZoom = 35D;
            this.btnAgregarItem.IsTab = false;
            this.btnAgregarItem.Location = new System.Drawing.Point(917, 377);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Normalcolor = System.Drawing.Color.White;
            this.btnAgregarItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAgregarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarItem.selected = false;
            this.btnAgregarItem.Size = new System.Drawing.Size(168, 47);
            this.btnAgregarItem.TabIndex = 64;
            this.btnAgregarItem.Text = "            Agregar";
            this.btnAgregarItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarItem.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnAgregarItem.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // btnBuscarTecnico
            // 
            this.btnBuscarTecnico.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarTecnico.BackColor = System.Drawing.Color.White;
            this.btnBuscarTecnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTecnico.BorderRadius = 7;
            this.btnBuscarTecnico.ButtonText = "";
            this.btnBuscarTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTecnico.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarTecnico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTecnico.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarTecnico.Iconimage = global::PCTECSANTIAGO.Properties.Resources.find_user_male_60px;
            this.btnBuscarTecnico.Iconimage_right = null;
            this.btnBuscarTecnico.Iconimage_right_Selected = null;
            this.btnBuscarTecnico.Iconimage_Selected = null;
            this.btnBuscarTecnico.IconMarginLeft = 8;
            this.btnBuscarTecnico.IconMarginRight = 0;
            this.btnBuscarTecnico.IconRightVisible = true;
            this.btnBuscarTecnico.IconRightZoom = 0D;
            this.btnBuscarTecnico.IconVisible = true;
            this.btnBuscarTecnico.IconZoom = 25D;
            this.btnBuscarTecnico.IsTab = false;
            this.btnBuscarTecnico.Location = new System.Drawing.Point(984, 153);
            this.btnBuscarTecnico.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBuscarTecnico.Name = "btnBuscarTecnico";
            this.btnBuscarTecnico.Normalcolor = System.Drawing.Color.White;
            this.btnBuscarTecnico.OnHovercolor = System.Drawing.Color.White;
            this.btnBuscarTecnico.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarTecnico.selected = false;
            this.btnBuscarTecnico.Size = new System.Drawing.Size(43, 37);
            this.btnBuscarTecnico.TabIndex = 63;
            this.btnBuscarTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTecnico.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnBuscarTecnico.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTecnico.Click += new System.EventHandler(this.btnBuscarTecnico_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.BorderRadius = 7;
            this.btnBuscarCliente.ButtonText = "";
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.Iconimage = global::PCTECSANTIAGO.Properties.Resources.find_user_male_60px;
            this.btnBuscarCliente.Iconimage_right = null;
            this.btnBuscarCliente.Iconimage_right_Selected = null;
            this.btnBuscarCliente.Iconimage_Selected = null;
            this.btnBuscarCliente.IconMarginLeft = 8;
            this.btnBuscarCliente.IconMarginRight = 0;
            this.btnBuscarCliente.IconRightVisible = true;
            this.btnBuscarCliente.IconRightZoom = 0D;
            this.btnBuscarCliente.IconVisible = true;
            this.btnBuscarCliente.IconZoom = 25D;
            this.btnBuscarCliente.IsTab = false;
            this.btnBuscarCliente.Location = new System.Drawing.Point(464, 153);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Normalcolor = System.Drawing.Color.White;
            this.btnBuscarCliente.OnHovercolor = System.Drawing.Color.White;
            this.btnBuscarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarCliente.selected = false;
            this.btnBuscarCliente.Size = new System.Drawing.Size(43, 37);
            this.btnBuscarCliente.TabIndex = 62;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnBuscarCliente.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cartaTotalFacturas
            // 
            this.cartaTotalFacturas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cartaTotalFacturas.BackgroundImage")));
            this.cartaTotalFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartaTotalFacturas.Controls.Add(this.lblUserEnSesion);
            this.cartaTotalFacturas.Controls.Add(this.label16);
            this.cartaTotalFacturas.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cartaTotalFacturas.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cartaTotalFacturas.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cartaTotalFacturas.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cartaTotalFacturas.Location = new System.Drawing.Point(569, 12);
            this.cartaTotalFacturas.Name = "cartaTotalFacturas";
            this.cartaTotalFacturas.Quality = 10;
            this.cartaTotalFacturas.Size = new System.Drawing.Size(516, 79);
            this.cartaTotalFacturas.TabIndex = 79;
            // 
            // lblUserEnSesion
            // 
            this.lblUserEnSesion.AutoSize = true;
            this.lblUserEnSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblUserEnSesion.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.lblUserEnSesion.ForeColor = System.Drawing.Color.White;
            this.lblUserEnSesion.Location = new System.Drawing.Point(201, 23);
            this.lblUserEnSesion.Name = "lblUserEnSesion";
            this.lblUserEnSesion.Size = new System.Drawing.Size(0, 34);
            this.lblUserEnSesion.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 34);
            this.label16.TabIndex = 16;
            this.label16.Text = "Usuario en sesion :";
            // 
            // VentanaFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1129, 730);
            this.Controls.Add(this.cartaTotalFacturas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.lblIDTecnico);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtDescripcionServicio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.btnBuscarTecnico);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgTablaFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaFacturacion";
            this.Text = "VentanaFacturacion";
            this.Load += new System.EventHandler(this.VentanaFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cartaTotalFacturas.ResumeLayout(false);
            this.cartaTotalFacturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTablaFacturacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarTecnico;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuFlatButton btnFacturar;
        private LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion txtCliente;
        private LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion txtTecnico;
        private LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion txtPrecio;
        private LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion txtCantidad;
        private LibreriaValidaciones_PCTECSANTIAGO.TextBoxValidacion txtDescripcionServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblIDTecnico;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuGradientPanel cartaTotalFacturas;
        private System.Windows.Forms.Label lblUserEnSesion;
        private System.Windows.Forms.Label label16;
    }
}
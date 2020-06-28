namespace PCTECSANTIAGO
{
    partial class VentanaServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaServicios));
            this.txtBuscarClienteFiltrado = new System.Windows.Forms.TextBox();
            this.dtgServiciosRealizados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cartaTotalFacturas = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTotalServicios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radio_carta_totalServicios = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServiciosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cartaTotalFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarClienteFiltrado
            // 
            this.txtBuscarClienteFiltrado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarClienteFiltrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarClienteFiltrado.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClienteFiltrado.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarClienteFiltrado.Location = new System.Drawing.Point(75, 129);
            this.txtBuscarClienteFiltrado.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtBuscarClienteFiltrado.Multiline = true;
            this.txtBuscarClienteFiltrado.Name = "txtBuscarClienteFiltrado";
            this.txtBuscarClienteFiltrado.Size = new System.Drawing.Size(281, 37);
            this.txtBuscarClienteFiltrado.TabIndex = 51;
            this.txtBuscarClienteFiltrado.Text = "Buscar cliente";
            this.txtBuscarClienteFiltrado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarClienteFiltrado_MouseClick);
            this.txtBuscarClienteFiltrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarClienteFiltrado_KeyPress);
            // 
            // dtgServiciosRealizados
            // 
            this.dtgServiciosRealizados.AllowUserToAddRows = false;
            this.dtgServiciosRealizados.AllowUserToDeleteRows = false;
            this.dtgServiciosRealizados.AllowUserToResizeColumns = false;
            this.dtgServiciosRealizados.AllowUserToResizeRows = false;
            this.dtgServiciosRealizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgServiciosRealizados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgServiciosRealizados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgServiciosRealizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgServiciosRealizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 14.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServiciosRealizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgServiciosRealizados.ColumnHeadersHeight = 30;
            this.dtgServiciosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgServiciosRealizados.EnableHeadersVisualStyles = false;
            this.dtgServiciosRealizados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.dtgServiciosRealizados.Location = new System.Drawing.Point(31, 199);
            this.dtgServiciosRealizados.Name = "dtgServiciosRealizados";
            this.dtgServiciosRealizados.ReadOnly = true;
            this.dtgServiciosRealizados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServiciosRealizados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgServiciosRealizados.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgServiciosRealizados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgServiciosRealizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgServiciosRealizados.Size = new System.Drawing.Size(1020, 405);
            this.dtgServiciosRealizados.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Servicios realizados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 42);
            this.label4.TabIndex = 52;
            this.label4.Text = "Servicios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PCTECSANTIAGO.Properties.Resources.SoporteCliente_376_png;
            this.pictureBox2.Location = new System.Drawing.Point(466, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // cartaTotalFacturas
            // 
            this.cartaTotalFacturas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cartaTotalFacturas.BackgroundImage")));
            this.cartaTotalFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartaTotalFacturas.Controls.Add(this.lblTotalServicios);
            this.cartaTotalFacturas.Controls.Add(this.label2);
            this.cartaTotalFacturas.Controls.Add(this.label3);
            this.cartaTotalFacturas.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cartaTotalFacturas.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cartaTotalFacturas.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cartaTotalFacturas.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cartaTotalFacturas.Location = new System.Drawing.Point(711, 32);
            this.cartaTotalFacturas.Name = "cartaTotalFacturas";
            this.cartaTotalFacturas.Quality = 10;
            this.cartaTotalFacturas.Size = new System.Drawing.Size(340, 111);
            this.cartaTotalFacturas.TabIndex = 55;
            // 
            // lblTotalServicios
            // 
            this.lblTotalServicios.AutoSize = true;
            this.lblTotalServicios.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalServicios.Font = new System.Drawing.Font("Poppins Light", 30F);
            this.lblTotalServicios.ForeColor = System.Drawing.Color.White;
            this.lblTotalServicios.Location = new System.Drawing.Point(211, 23);
            this.lblTotalServicios.Name = "lblTotalServicios";
            this.lblTotalServicios.Size = new System.Drawing.Size(77, 70);
            this.lblTotalServicios.TabIndex = 18;
            this.lblTotalServicios.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Realizadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total facturas";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "        Imprimir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PCTECSANTIAGO.Properties.Resources.pdf_50px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 8;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(586, 628);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(215, 52);
            this.bunifuFlatButton1.TabIndex = 54;
            this.bunifuFlatButton1.Text = "        Imprimir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::PCTECSANTIAGO.Properties.Resources.search_50px;
            this.pictureBox1.Location = new System.Drawing.Point(40, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.ButtonText = "        Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::PCTECSANTIAGO.Properties.Resources.eliminar_50px;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 8;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 40D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(266, 628);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.White;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(215, 52);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "        Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnEliminar.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // radio_carta_totalServicios
            // 
            this.radio_carta_totalServicios.ElipseRadius = 10;
            this.radio_carta_totalServicios.TargetControl = this.cartaTotalFacturas;
            // 
            // VentanaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1129, 730);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cartaTotalFacturas);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarClienteFiltrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgServiciosRealizados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaServicios";
            this.Text = "VentanaServicios";
            this.Load += new System.EventHandler(this.VentanaServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServiciosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cartaTotalFacturas.ResumeLayout(false);
            this.cartaTotalFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarClienteFiltrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private System.Windows.Forms.DataGridView dtgServiciosRealizados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel cartaTotalFacturas;
        private System.Windows.Forms.Label lblTotalServicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse radio_carta_totalServicios;
    }
}
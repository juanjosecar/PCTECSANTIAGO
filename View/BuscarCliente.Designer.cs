namespace PCTECSANTIAGO.View
{
    partial class BuscarCliente
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
            this.CurvaBuscarCliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtBuscarClienteFiltrado = new System.Windows.Forms.TextBox();
            this.TablaBuscarCliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioTablaBuscarCliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSeleccionarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TablaBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CurvaBuscarCliente
            // 
            this.CurvaBuscarCliente.ElipseRadius = 20;
            this.CurvaBuscarCliente.TargetControl = this;
            // 
            // txtBuscarClienteFiltrado
            // 
            this.txtBuscarClienteFiltrado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarClienteFiltrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarClienteFiltrado.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClienteFiltrado.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarClienteFiltrado.Location = new System.Drawing.Point(126, 91);
            this.txtBuscarClienteFiltrado.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtBuscarClienteFiltrado.Multiline = true;
            this.txtBuscarClienteFiltrado.Name = "txtBuscarClienteFiltrado";
            this.txtBuscarClienteFiltrado.Size = new System.Drawing.Size(678, 37);
            this.txtBuscarClienteFiltrado.TabIndex = 52;
            this.txtBuscarClienteFiltrado.Text = "Buscar cliente";
            this.txtBuscarClienteFiltrado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarClienteFiltrado_MouseClick);
            this.txtBuscarClienteFiltrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarClienteFiltrado_KeyPress);
            // 
            // TablaBuscarCliente
            // 
            this.TablaBuscarCliente.AllowUserToAddRows = false;
            this.TablaBuscarCliente.AllowUserToDeleteRows = false;
            this.TablaBuscarCliente.AllowUserToResizeColumns = false;
            this.TablaBuscarCliente.AllowUserToResizeRows = false;
            this.TablaBuscarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaBuscarCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TablaBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaBuscarCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TablaBuscarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 14.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaBuscarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaBuscarCliente.ColumnHeadersHeight = 30;
            this.TablaBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaBuscarCliente.EnableHeadersVisualStyles = false;
            this.TablaBuscarCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.TablaBuscarCliente.Location = new System.Drawing.Point(91, 154);
            this.TablaBuscarCliente.Name = "TablaBuscarCliente";
            this.TablaBuscarCliente.ReadOnly = true;
            this.TablaBuscarCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaBuscarCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaBuscarCliente.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.TablaBuscarCliente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaBuscarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaBuscarCliente.Size = new System.Drawing.Size(713, 320);
            this.TablaBuscarCliente.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 42);
            this.label4.TabIndex = 53;
            this.label4.Text = "Clientes";
            // 
            // RadioTablaBuscarCliente
            // 
            this.RadioTablaBuscarCliente.ElipseRadius = 8;
            this.RadioTablaBuscarCliente.TargetControl = this.TablaBuscarCliente;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::PCTECSANTIAGO.Properties.Resources.search_50px;
            this.pictureBox1.Location = new System.Drawing.Point(91, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.BorderRadius = 7;
            this.btnRegresar.ButtonText = "       Salir";
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegresar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegresar.Iconimage = global::PCTECSANTIAGO.Properties.Resources.btnRegresar;
            this.btnRegresar.Iconimage_right = null;
            this.btnRegresar.Iconimage_right_Selected = null;
            this.btnRegresar.Iconimage_Selected = null;
            this.btnRegresar.IconMarginLeft = 8;
            this.btnRegresar.IconMarginRight = 0;
            this.btnRegresar.IconRightVisible = true;
            this.btnRegresar.IconRightZoom = 0D;
            this.btnRegresar.IconVisible = true;
            this.btnRegresar.IconZoom = 40D;
            this.btnRegresar.IsTab = false;
            this.btnRegresar.Location = new System.Drawing.Point(493, 493);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Normalcolor = System.Drawing.Color.White;
            this.btnRegresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnRegresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegresar.selected = false;
            this.btnRegresar.Size = new System.Drawing.Size(195, 47);
            this.btnRegresar.TabIndex = 50;
            this.btnRegresar.Text = "       Salir";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnRegresar.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnSeleccionarCliente.BackColor = System.Drawing.Color.White;
            this.btnSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarCliente.BorderRadius = 7;
            this.btnSeleccionarCliente.ButtonText = "        Seleccionar";
            this.btnSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeleccionarCliente.Iconimage = global::PCTECSANTIAGO.Properties.Resources.btnSeleccionar;
            this.btnSeleccionarCliente.Iconimage_right = null;
            this.btnSeleccionarCliente.Iconimage_right_Selected = null;
            this.btnSeleccionarCliente.Iconimage_Selected = null;
            this.btnSeleccionarCliente.IconMarginLeft = 8;
            this.btnSeleccionarCliente.IconMarginRight = 0;
            this.btnSeleccionarCliente.IconRightVisible = true;
            this.btnSeleccionarCliente.IconRightZoom = 0D;
            this.btnSeleccionarCliente.IconVisible = true;
            this.btnSeleccionarCliente.IconZoom = 40D;
            this.btnSeleccionarCliente.IsTab = false;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(162, 493);
            this.btnSeleccionarCliente.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Normalcolor = System.Drawing.Color.White;
            this.btnSeleccionarCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSeleccionarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSeleccionarCliente.selected = false;
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(195, 47);
            this.btnSeleccionarCliente.TabIndex = 49;
            this.btnSeleccionarCliente.Text = "        Seleccionar";
            this.btnSeleccionarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarCliente.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnSeleccionarCliente.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // MoverForm
            // 
            this.MoverForm.Fixed = true;
            this.MoverForm.Horizontal = true;
            this.MoverForm.TargetControl = this;
            this.MoverForm.Vertical = true;
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(889, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarClienteFiltrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.TablaBuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse CurvaBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarClienteFiltrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegresar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeleccionarCliente;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse RadioTablaBuscarCliente;
        public System.Windows.Forms.DataGridView TablaBuscarCliente;
        private Bunifu.Framework.UI.BunifuDragControl MoverForm;
    }
}
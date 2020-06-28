namespace PCTECSANTIAGO.View
{
    partial class BuscarTecnico
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarTecnicoFiltrado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSeleccionaTecnico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TablaBuscarTecnico = new System.Windows.Forms.DataGridView();
            this.CurvaBuscarTecnico = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.radioTablaTecnicos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.moverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBuscarTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 42);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tecnicos";
            // 
            // txtBuscarTecnicoFiltrado
            // 
            this.txtBuscarTecnicoFiltrado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarTecnicoFiltrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarTecnicoFiltrado.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTecnicoFiltrado.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarTecnicoFiltrado.Location = new System.Drawing.Point(126, 87);
            this.txtBuscarTecnicoFiltrado.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtBuscarTecnicoFiltrado.Multiline = true;
            this.txtBuscarTecnicoFiltrado.Name = "txtBuscarTecnicoFiltrado";
            this.txtBuscarTecnicoFiltrado.Size = new System.Drawing.Size(678, 37);
            this.txtBuscarTecnicoFiltrado.TabIndex = 58;
            this.txtBuscarTecnicoFiltrado.Text = "Buscar tecnico";
            this.txtBuscarTecnicoFiltrado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarTecnicoFiltrado_MouseClick);
            this.txtBuscarTecnicoFiltrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarTecnicoFiltrado_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::PCTECSANTIAGO.Properties.Resources.search_50px;
            this.pictureBox1.Location = new System.Drawing.Point(91, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
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
            this.btnRegresar.Location = new System.Drawing.Point(493, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Normalcolor = System.Drawing.Color.White;
            this.btnRegresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnRegresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegresar.selected = false;
            this.btnRegresar.Size = new System.Drawing.Size(195, 47);
            this.btnRegresar.TabIndex = 56;
            this.btnRegresar.Text = "       Salir";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnRegresar.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSeleccionaTecnico
            // 
            this.btnSeleccionaTecnico.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnSeleccionaTecnico.BackColor = System.Drawing.Color.White;
            this.btnSeleccionaTecnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionaTecnico.BorderRadius = 7;
            this.btnSeleccionaTecnico.ButtonText = "        Seleccionar";
            this.btnSeleccionaTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionaTecnico.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeleccionaTecnico.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionaTecnico.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeleccionaTecnico.Iconimage = global::PCTECSANTIAGO.Properties.Resources.btnSeleccionar;
            this.btnSeleccionaTecnico.Iconimage_right = null;
            this.btnSeleccionaTecnico.Iconimage_right_Selected = null;
            this.btnSeleccionaTecnico.Iconimage_Selected = null;
            this.btnSeleccionaTecnico.IconMarginLeft = 8;
            this.btnSeleccionaTecnico.IconMarginRight = 0;
            this.btnSeleccionaTecnico.IconRightVisible = true;
            this.btnSeleccionaTecnico.IconRightZoom = 0D;
            this.btnSeleccionaTecnico.IconVisible = true;
            this.btnSeleccionaTecnico.IconZoom = 40D;
            this.btnSeleccionaTecnico.IsTab = false;
            this.btnSeleccionaTecnico.Location = new System.Drawing.Point(162, 489);
            this.btnSeleccionaTecnico.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSeleccionaTecnico.Name = "btnSeleccionaTecnico";
            this.btnSeleccionaTecnico.Normalcolor = System.Drawing.Color.White;
            this.btnSeleccionaTecnico.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSeleccionaTecnico.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSeleccionaTecnico.selected = false;
            this.btnSeleccionaTecnico.Size = new System.Drawing.Size(195, 47);
            this.btnSeleccionaTecnico.TabIndex = 55;
            this.btnSeleccionaTecnico.Text = "        Seleccionar";
            this.btnSeleccionaTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionaTecnico.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btnSeleccionaTecnico.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionaTecnico.Click += new System.EventHandler(this.btnSeleccionaTecnico_Click);
            // 
            // TablaBuscarTecnico
            // 
            this.TablaBuscarTecnico.AllowUserToAddRows = false;
            this.TablaBuscarTecnico.AllowUserToDeleteRows = false;
            this.TablaBuscarTecnico.AllowUserToResizeColumns = false;
            this.TablaBuscarTecnico.AllowUserToResizeRows = false;
            this.TablaBuscarTecnico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaBuscarTecnico.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TablaBuscarTecnico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaBuscarTecnico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TablaBuscarTecnico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 14.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaBuscarTecnico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaBuscarTecnico.ColumnHeadersHeight = 30;
            this.TablaBuscarTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaBuscarTecnico.EnableHeadersVisualStyles = false;
            this.TablaBuscarTecnico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.TablaBuscarTecnico.Location = new System.Drawing.Point(91, 150);
            this.TablaBuscarTecnico.Name = "TablaBuscarTecnico";
            this.TablaBuscarTecnico.ReadOnly = true;
            this.TablaBuscarTecnico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaBuscarTecnico.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaBuscarTecnico.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(126)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.TablaBuscarTecnico.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaBuscarTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaBuscarTecnico.Size = new System.Drawing.Size(713, 320);
            this.TablaBuscarTecnico.TabIndex = 54;
            // 
            // CurvaBuscarTecnico
            // 
            this.CurvaBuscarTecnico.ElipseRadius = 20;
            this.CurvaBuscarTecnico.TargetControl = this;
            // 
            // radioTablaTecnicos
            // 
            this.radioTablaTecnicos.ElipseRadius = 8;
            this.radioTablaTecnicos.TargetControl = this.TablaBuscarTecnico;
            // 
            // moverForm
            // 
            this.moverForm.Fixed = true;
            this.moverForm.Horizontal = true;
            this.moverForm.TargetControl = this;
            this.moverForm.Vertical = true;
            // 
            // BuscarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(889, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarTecnicoFiltrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSeleccionaTecnico);
            this.Controls.Add(this.TablaBuscarTecnico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarTecnico";
            this.Load += new System.EventHandler(this.BuscarTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBuscarTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarTecnicoFiltrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegresar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeleccionaTecnico;
        private Bunifu.Framework.UI.BunifuElipse CurvaBuscarTecnico;
        private Bunifu.Framework.UI.BunifuElipse radioTablaTecnicos;
        public System.Windows.Forms.DataGridView TablaBuscarTecnico;
        private Bunifu.Framework.UI.BunifuDragControl moverForm;
    }
}
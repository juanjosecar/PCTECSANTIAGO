namespace PCTECSANTIAGO
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnMenuSidebar = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GraficoIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.SidebarGradient = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PCTEC_SANTIAGO_logoMini_ = new System.Windows.Forms.PictureBox();
            this.btnFacturas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTecnicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.ImgenSidebarLogo = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RadioButton_Dashboard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSidebar)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoIngresos)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.SidebarGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCTEC_SANTIAGO_logoMini_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgenSidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.btnRestaurar);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnSalir);
            this.panelTop.Controls.Add(this.btnMenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1400, 80);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.AnimacionSidebar1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::PCTECSANTIAGO.Properties.Resources.TEXTO_PCTEC_SANTIAGO;
            this.pictureBox2.Location = new System.Drawing.Point(77, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar1.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurar.Image = global::PCTECSANTIAGO.Properties.Resources.restore_window_50px;
            this.btnRestaurar.Location = new System.Drawing.Point(1285, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(35, 35);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar1.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = global::PCTECSANTIAGO.Properties.Resources.minimize_window_50px;
            this.btnMinimizar.Location = new System.Drawing.Point(1244, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar1.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Image = global::PCTECSANTIAGO.Properties.Resources.maximize_window_50px;
            this.btnMaximizar.Location = new System.Drawing.Point(1285, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar1.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.btnSalir.Image = global::PCTECSANTIAGO.Properties.Resources.close_window_50px;
            this.btnSalir.Location = new System.Drawing.Point(1326, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 35);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenuSidebar
            // 
            this.AnimacionSidebar1.SetDecoration(this.btnMenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnMenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuSidebar.Image = global::PCTECSANTIAGO.Properties.Resources.menu_50px;
            this.btnMenuSidebar.Location = new System.Drawing.Point(31, 31);
            this.btnMenuSidebar.Name = "btnMenuSidebar";
            this.btnMenuSidebar.Size = new System.Drawing.Size(29, 22);
            this.btnMenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenuSidebar.TabIndex = 0;
            this.btnMenuSidebar.TabStop = false;
            this.btnMenuSidebar.Click += new System.EventHandler(this.btnMenuSidebar_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Wrapper.Controls.Add(this.panelChart);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1100, 714);
            this.Wrapper.TabIndex = 1;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelChart.Controls.Add(this.label1);
            this.panelChart.Controls.Add(this.label2);
            this.panelChart.Controls.Add(this.GraficoIngresos);
            this.AnimacionSidebarBack.SetDecoration(this.panelChart, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.panelChart, BunifuAnimatorNS.DecorationType.None);
            this.panelChart.Location = new System.Drawing.Point(20, 17);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1058, 646);
            this.panelChart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Poppins Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Presentacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Ingresos";
            // 
            // GraficoIngresos
            // 
            this.GraficoIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraficoIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.GraficoIngresos.BorderlineWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.GraficoIngresos.ChartAreas.Add(chartArea1);
            this.AnimacionSidebarBack.SetDecoration(this.GraficoIngresos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.GraficoIngresos, BunifuAnimatorNS.DecorationType.None);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.GraficoIngresos.Legends.Add(legend1);
            this.GraficoIngresos.Location = new System.Drawing.Point(53, 100);
            this.GraficoIngresos.Name = "GraficoIngresos";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.Name = "ChartLinea";
            this.GraficoIngresos.Series.Add(series1);
            this.GraficoIngresos.Size = new System.Drawing.Size(954, 458);
            this.GraficoIngresos.TabIndex = 0;
            this.GraficoIngresos.Text = "chart1";
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.SidebarWrapper.Controls.Add(this.SidebarGradient);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 714);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // SidebarGradient
            // 
            this.SidebarGradient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidebarGradient.BackColor = System.Drawing.Color.Transparent;
            this.SidebarGradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidebarGradient.BackgroundImage")));
            this.SidebarGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidebarGradient.Controls.Add(this.PCTEC_SANTIAGO_logoMini_);
            this.SidebarGradient.Controls.Add(this.btnFacturas);
            this.SidebarGradient.Controls.Add(this.btnServicios);
            this.SidebarGradient.Controls.Add(this.btnTecnicos);
            this.SidebarGradient.Controls.Add(this.btnClientes);
            this.SidebarGradient.Controls.Add(this.btnDashboard);
            this.SidebarGradient.Controls.Add(this.lineaSidebar);
            this.SidebarGradient.Controls.Add(this.ImgenSidebarLogo);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarGradient, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.SidebarGradient, BunifuAnimatorNS.DecorationType.None);
            this.SidebarGradient.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.SidebarGradient.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.SidebarGradient.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.SidebarGradient.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.SidebarGradient.Location = new System.Drawing.Point(12, 28);
            this.SidebarGradient.Name = "SidebarGradient";
            this.SidebarGradient.Quality = 10;
            this.SidebarGradient.Size = new System.Drawing.Size(270, 614);
            this.SidebarGradient.TabIndex = 0;
            this.SidebarGradient.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarGradient_Paint);
            // 
            // PCTEC_SANTIAGO_logoMini_
            // 
            this.PCTEC_SANTIAGO_logoMini_.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar1.SetDecoration(this.PCTEC_SANTIAGO_logoMini_, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.PCTEC_SANTIAGO_logoMini_, BunifuAnimatorNS.DecorationType.None);
            this.PCTEC_SANTIAGO_logoMini_.Image = global::PCTECSANTIAGO.Properties.Resources.LOGO_PCTEC_SANTIAGO_FONT_WHITE2;
            this.PCTEC_SANTIAGO_logoMini_.Location = new System.Drawing.Point(0, 53);
            this.PCTEC_SANTIAGO_logoMini_.Name = "PCTEC_SANTIAGO_logoMini_";
            this.PCTEC_SANTIAGO_logoMini_.Size = new System.Drawing.Size(67, 67);
            this.PCTEC_SANTIAGO_logoMini_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCTEC_SANTIAGO_logoMini_.TabIndex = 13;
            this.PCTEC_SANTIAGO_logoMini_.TabStop = false;
            this.PCTEC_SANTIAGO_logoMini_.Visible = false;
            // 
            // btnFacturas
            // 
            this.btnFacturas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnFacturas.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturas.BorderRadius = 0;
            this.btnFacturas.ButtonText = "           FACTURAS";
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar1.SetDecoration(this.btnFacturas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnFacturas, BunifuAnimatorNS.DecorationType.None);
            this.btnFacturas.DisabledColor = System.Drawing.Color.Gray;
            this.btnFacturas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFacturas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFacturas.Iconimage")));
            this.btnFacturas.Iconimage_right = null;
            this.btnFacturas.Iconimage_right_Selected = null;
            this.btnFacturas.Iconimage_Selected = null;
            this.btnFacturas.IconMarginLeft = 8;
            this.btnFacturas.IconMarginRight = 0;
            this.btnFacturas.IconRightVisible = true;
            this.btnFacturas.IconRightZoom = 0D;
            this.btnFacturas.IconVisible = true;
            this.btnFacturas.IconZoom = 75D;
            this.btnFacturas.IsTab = false;
            this.btnFacturas.Location = new System.Drawing.Point(0, 432);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnFacturas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnFacturas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFacturas.selected = false;
            this.btnFacturas.Size = new System.Drawing.Size(270, 47);
            this.btnFacturas.TabIndex = 12;
            this.btnFacturas.Text = "           FACTURAS";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Textcolor = System.Drawing.Color.LightGray;
            this.btnFacturas.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicios.BorderRadius = 0;
            this.btnServicios.ButtonText = "           SERVICIOS";
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar1.SetDecoration(this.btnServicios, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnServicios, BunifuAnimatorNS.DecorationType.None);
            this.btnServicios.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicios.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnServicios.Iconimage")));
            this.btnServicios.Iconimage_right = null;
            this.btnServicios.Iconimage_right_Selected = null;
            this.btnServicios.Iconimage_Selected = null;
            this.btnServicios.IconMarginLeft = 8;
            this.btnServicios.IconMarginRight = 0;
            this.btnServicios.IconRightVisible = true;
            this.btnServicios.IconRightZoom = 0D;
            this.btnServicios.IconVisible = true;
            this.btnServicios.IconZoom = 75D;
            this.btnServicios.IsTab = false;
            this.btnServicios.Location = new System.Drawing.Point(0, 383);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnServicios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnServicios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicios.selected = false;
            this.btnServicios.Size = new System.Drawing.Size(270, 47);
            this.btnServicios.TabIndex = 11;
            this.btnServicios.Text = "           SERVICIOS";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Textcolor = System.Drawing.Color.LightGray;
            this.btnServicios.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnTecnicos.BackColor = System.Drawing.Color.Transparent;
            this.btnTecnicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTecnicos.BorderRadius = 0;
            this.btnTecnicos.ButtonText = "           TECNICOS";
            this.btnTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar1.SetDecoration(this.btnTecnicos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnTecnicos, BunifuAnimatorNS.DecorationType.None);
            this.btnTecnicos.DisabledColor = System.Drawing.Color.Gray;
            this.btnTecnicos.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnicos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTecnicos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTecnicos.Iconimage")));
            this.btnTecnicos.Iconimage_right = null;
            this.btnTecnicos.Iconimage_right_Selected = null;
            this.btnTecnicos.Iconimage_Selected = null;
            this.btnTecnicos.IconMarginLeft = 8;
            this.btnTecnicos.IconMarginRight = 0;
            this.btnTecnicos.IconRightVisible = true;
            this.btnTecnicos.IconRightZoom = 0D;
            this.btnTecnicos.IconVisible = true;
            this.btnTecnicos.IconZoom = 75D;
            this.btnTecnicos.IsTab = false;
            this.btnTecnicos.Location = new System.Drawing.Point(0, 324);
            this.btnTecnicos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTecnicos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnTecnicos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTecnicos.selected = false;
            this.btnTecnicos.Size = new System.Drawing.Size(270, 47);
            this.btnTecnicos.TabIndex = 10;
            this.btnTecnicos.Text = "           TECNICOS";
            this.btnTecnicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTecnicos.Textcolor = System.Drawing.Color.LightGray;
            this.btnTecnicos.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "           CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar1.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 8;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 75D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(0, 265);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(270, 47);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "           CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.LightGray;
            this.btnClientes.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "           DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar1.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 8;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 75D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 206);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(270, 47);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "           DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.LightGray;
            this.btnDashboard.TextFont = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lineaSidebar
            // 
            this.lineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.lineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this.lineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.lineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineaSidebar.LineThickness = 1;
            this.lineaSidebar.Location = new System.Drawing.Point(9, 182);
            this.lineaSidebar.Name = "lineaSidebar";
            this.lineaSidebar.Size = new System.Drawing.Size(252, 2);
            this.lineaSidebar.TabIndex = 7;
            this.lineaSidebar.Transparency = 255;
            this.lineaSidebar.Vertical = false;
            // 
            // ImgenSidebarLogo
            // 
            this.ImgenSidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar1.SetDecoration(this.ImgenSidebarLogo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.ImgenSidebarLogo, BunifuAnimatorNS.DecorationType.None);
            this.ImgenSidebarLogo.Image = global::PCTECSANTIAGO.Properties.Resources.LOGO_PCTEC_SANTIAGO_FONT_WHITE2;
            this.ImgenSidebarLogo.Location = new System.Drawing.Point(19, 1);
            this.ImgenSidebarLogo.Name = "ImgenSidebarLogo";
            this.ImgenSidebarLogo.Size = new System.Drawing.Size(237, 166);
            this.ImgenSidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgenSidebarLogo.TabIndex = 6;
            this.ImgenSidebarLogo.TabStop = false;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.SidebarGradient;
            // 
            // AnimacionSidebar1
            // 
            this.AnimacionSidebar1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar1.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // RadioChart
            // 
            this.RadioChart.ElipseRadius = 9;
            this.RadioChart.TargetControl = this.panelChart;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.panelTop;
            this.MoverDashboard.Vertical = true;
            // 
            // RadioButton_Dashboard
            // 
            this.RadioButton_Dashboard.ElipseRadius = 6;
            this.RadioButton_Dashboard.TargetControl = this.btnDashboard;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 794);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.panelTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSidebar)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoIngresos)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.SidebarGradient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCTEC_SANTIAGO_logoMini_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgenSidebarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMenuSidebar;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel SidebarGradient;
        private System.Windows.Forms.PictureBox ImgenSidebarLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuSeparator lineaSidebar;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar1;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private System.Windows.Forms.Panel panelChart;
        private Bunifu.Framework.UI.BunifuElipse RadioChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoIngresos;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse RadioButton_Dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private System.Windows.Forms.PictureBox PCTEC_SANTIAGO_logoMini_;
        private Bunifu.Framework.UI.BunifuFlatButton btnFacturas;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicios;
        private Bunifu.Framework.UI.BunifuFlatButton btnTecnicos;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


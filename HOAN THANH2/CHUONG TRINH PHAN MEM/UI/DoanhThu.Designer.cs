namespace UI
{
    partial class DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation border3DAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.button_dt_quaylai = new System.Windows.Forms.Button();
            this.chart_bh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_theohang = new System.Windows.Forms.RadioButton();
            this.radioButton_theothoigian = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_theohang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bH = new UI.BanHang();
            this.radioButton_dt_bd = new System.Windows.Forms.RadioButton();
            this.comboBox_dt_loinhuan = new System.Windows.Forms.ComboBox();
            this.dataGridView_theothang = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton_tn = new System.Windows.Forms.RadioButton();
            this.radioButton_tt = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_tn = new System.Windows.Forms.DateTimePicker();
            this.label_tongloinhuan = new System.Windows.Forms.Label();
            this.pictureBox_bd = new System.Windows.Forms.PictureBox();
            this.pictureBox_tg = new System.Windows.Forms.PictureBox();
            this.pictureBox_mh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_theohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.bH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_theothang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mh)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dt_quaylai
            // 
            this.button_dt_quaylai.BackColor = System.Drawing.Color.Transparent;
            this.button_dt_quaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dt_quaylai.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_dt_quaylai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_dt_quaylai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_dt_quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dt_quaylai.ForeColor = System.Drawing.Color.Lime;
            this.button_dt_quaylai.Image = global::UI.Properties.Resources._48px_Crystal_Clear_action_reload;
            this.button_dt_quaylai.Location = new System.Drawing.Point(1256, 663);
            this.button_dt_quaylai.Name = "button_dt_quaylai";
            this.button_dt_quaylai.Size = new System.Drawing.Size(85, 55);
            this.button_dt_quaylai.TabIndex = 34;
            this.button_dt_quaylai.UseVisualStyleBackColor = false;
            this.button_dt_quaylai.Click += new System.EventHandler(this.button_nh_quaylai_Click);
            // 
            // chart_bh
            // 
            border3DAnnotation1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            border3DAnnotation1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            border3DAnnotation1.LineColor = System.Drawing.Color.Empty;
            border3DAnnotation1.Name = "Border3DAnnotation1";
            border3DAnnotation1.Text = "Border3DAnnotation1";
            this.chart_bh.Annotations.Add(border3DAnnotation1);
            this.chart_bh.BackColor = System.Drawing.Color.Transparent;
            this.chart_bh.CausesValidation = false;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkViolet;
            chartArea1.AxisX.LineWidth = 5;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Tháng";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkViolet;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.Title = "Tiền ( VNĐ )";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart_bh.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Ký hiệu :";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_bh.Legends.Add(legend1);
            this.chart_bh.Location = new System.Drawing.Point(-1, 47);
            this.chart_bh.Name = "chart_bh";
            this.chart_bh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.CustomProperties = "LabelStyle=Center";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelAngle = 90;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Nhập";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.CustomProperties = "LabelStyle=Center";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.LabelBorderWidth = 2;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Bán";
            series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Turquoise;
            series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Round;
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series2.YValuesPerPoint = 2;
            this.chart_bh.Series.Add(series1);
            this.chart_bh.Series.Add(series2);
            this.chart_bh.Size = new System.Drawing.Size(1251, 684);
            this.chart_bh.TabIndex = 35;
            this.chart_bh.Text = "chart_dt";
            this.chart_bh.Click += new System.EventHandler(this.chart_bh_Click);
            this.chart_bh.DoubleClick += new System.EventHandler(this.chart_bh_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 619);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton_theohang
            // 
            this.radioButton_theohang.AutoSize = true;
            this.radioButton_theohang.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_theohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_theohang.ForeColor = System.Drawing.Color.Chartreuse;
            this.radioButton_theohang.Location = new System.Drawing.Point(1142, 258);
            this.radioButton_theohang.Name = "radioButton_theohang";
            this.radioButton_theohang.Size = new System.Drawing.Size(187, 29);
            this.radioButton_theohang.TabIndex = 48;
            this.radioButton_theohang.TabStop = true;
            this.radioButton_theohang.Text = "Theo mặt hàng";
            this.radioButton_theohang.UseVisualStyleBackColor = false;
            this.radioButton_theohang.CheckedChanged += new System.EventHandler(this.radioButton_theohang_CheckedChanged);
            // 
            // radioButton_theothoigian
            // 
            this.radioButton_theothoigian.AutoSize = true;
            this.radioButton_theothoigian.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_theothoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_theothoigian.ForeColor = System.Drawing.Color.Chartreuse;
            this.radioButton_theothoigian.Location = new System.Drawing.Point(1142, 305);
            this.radioButton_theothoigian.Name = "radioButton_theothoigian";
            this.radioButton_theothoigian.Size = new System.Drawing.Size(181, 29);
            this.radioButton_theothoigian.TabIndex = 49;
            this.radioButton_theothoigian.TabStop = true;
            this.radioButton_theothoigian.Text = "Theo thời gian";
            this.radioButton_theothoigian.UseVisualStyleBackColor = false;
            this.radioButton_theothoigian.CheckedChanged += new System.EventHandler(this.radioButton_theothoigian_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1098, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Báo cáo doanh thu :";
            // 
            // dataGridView_theohang
            // 
            this.dataGridView_theohang.AllowUserToAddRows = false;
            this.dataGridView_theohang.AllowUserToDeleteRows = false;
            this.dataGridView_theohang.AllowUserToOrderColumns = true;
            this.dataGridView_theohang.AllowUserToResizeColumns = false;
            this.dataGridView_theohang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_theohang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_theohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_theohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_theohang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_theohang.Location = new System.Drawing.Point(-1, 166);
            this.dataGridView_theohang.Name = "dataGridView_theohang";
            this.dataGridView_theohang.ReadOnly = true;
            this.dataGridView_theohang.Size = new System.Drawing.Size(1093, 565);
            this.dataGridView_theohang.TabIndex = 52;
            this.dataGridView_theohang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hh_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenSP";
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "SoLuongNhap";
            this.Column2.HeaderText = "Số lượng nhập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SoLuongBan";
            this.Column3.HeaderText = "Số lượng bán";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TongTienNhap";
            this.Column4.HeaderText = "Tổng tiền nhập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TongTienBan";
            this.Column5.HeaderText = "Tổng tiền bán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "LoiNhuan";
            this.Column6.HeaderText = "Lợi nhuận";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // bHBindingSource
            // 
            this.bHBindingSource.DataSource = this.bH;
            this.bHBindingSource.Position = 0;
            // 
            // 
            // radioButton_dt_bd
            // 
            this.radioButton_dt_bd.AutoSize = true;
            this.radioButton_dt_bd.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_dt_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_dt_bd.ForeColor = System.Drawing.Color.Chartreuse;
            this.radioButton_dt_bd.Location = new System.Drawing.Point(1142, 352);
            this.radioButton_dt_bd.Name = "radioButton_dt_bd";
            this.radioButton_dt_bd.Size = new System.Drawing.Size(168, 29);
            this.radioButton_dt_bd.TabIndex = 53;
            this.radioButton_dt_bd.TabStop = true;
            this.radioButton_dt_bd.Text = "Theo biểu đồ";
            this.radioButton_dt_bd.UseVisualStyleBackColor = false;
            this.radioButton_dt_bd.CheckedChanged += new System.EventHandler(this.radioButton_dt_bd_CheckedChanged);
            // 
            // comboBox_dt_loinhuan
            // 
            this.comboBox_dt_loinhuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_dt_loinhuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_dt_loinhuan.BackColor = System.Drawing.Color.Silver;
            this.comboBox_dt_loinhuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_dt_loinhuan.Enabled = false;
            this.comboBox_dt_loinhuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_dt_loinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dt_loinhuan.ForeColor = System.Drawing.Color.Lime;
            this.comboBox_dt_loinhuan.FormattingEnabled = true;
            this.comboBox_dt_loinhuan.IntegralHeight = false;
            this.comboBox_dt_loinhuan.ItemHeight = 29;
            this.comboBox_dt_loinhuan.Location = new System.Drawing.Point(1103, 576);
            this.comboBox_dt_loinhuan.Name = "comboBox_dt_loinhuan";
            this.comboBox_dt_loinhuan.Size = new System.Drawing.Size(238, 32);
            this.comboBox_dt_loinhuan.TabIndex = 55;
            // 
            // dataGridView_theothang
            // 
            this.dataGridView_theothang.AllowUserToAddRows = false;
            this.dataGridView_theothang.AllowUserToDeleteRows = false;
            this.dataGridView_theothang.AllowUserToOrderColumns = true;
            this.dataGridView_theothang.AllowUserToResizeColumns = false;
            this.dataGridView_theothang.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_theothang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_theothang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_theothang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_theothang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_theothang.Location = new System.Drawing.Point(-1, 166);
            this.dataGridView_theothang.Name = "dataGridView_theothang";
            this.dataGridView_theothang.ReadOnly = true;
            this.dataGridView_theothang.Size = new System.Drawing.Size(1093, 565);
            this.dataGridView_theothang.TabIndex = 56;
            this.dataGridView_theothang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_theothoigian_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "ThoiGian";
            this.Column7.HeaderText = "Tháng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoLuongNhap";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng nhập";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuongBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng bán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TongTienNhap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền nhập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TongTienBan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền bán";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LoiNhuan";
            this.dataGridViewTextBoxColumn6.HeaderText = "Lợi nhuận";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // radioButton_tn
            // 
            this.radioButton_tn.AutoSize = true;
            this.radioButton_tn.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_tn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_tn.ForeColor = System.Drawing.Color.Chartreuse;
            this.radioButton_tn.Location = new System.Drawing.Point(230, 121);
            this.radioButton_tn.Name = "radioButton_tn";
            this.radioButton_tn.Size = new System.Drawing.Size(141, 29);
            this.radioButton_tn.TabIndex = 59;
            this.radioButton_tn.TabStop = true;
            this.radioButton_tn.Text = "Theo ngày";
            this.radioButton_tn.UseVisualStyleBackColor = false;
            this.radioButton_tn.CheckedChanged += new System.EventHandler(this.radioButton_tn_CheckedChanged);
            // 
            // radioButton_tt
            // 
            this.radioButton_tt.AutoSize = true;
            this.radioButton_tt.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_tt.ForeColor = System.Drawing.Color.Chartreuse;
            this.radioButton_tt.Location = new System.Drawing.Point(34, 121);
            this.radioButton_tt.Name = "radioButton_tt";
            this.radioButton_tt.Size = new System.Drawing.Size(149, 29);
            this.radioButton_tt.TabIndex = 60;
            this.radioButton_tt.TabStop = true;
            this.radioButton_tt.Text = "Theo tháng";
            this.radioButton_tt.UseVisualStyleBackColor = false;
            this.radioButton_tt.CheckedChanged += new System.EventHandler(this.radioButton_tt_CheckedChanged);
            // 
            // dateTimePicker_tn
            // 
            this.dateTimePicker_tn.Checked = false;
            this.dateTimePicker_tn.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_tn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_tn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_tn.Location = new System.Drawing.Point(410, 112);
            this.dateTimePicker_tn.Name = "dateTimePicker_tn";
            this.dateTimePicker_tn.Size = new System.Drawing.Size(190, 38);
            this.dateTimePicker_tn.TabIndex = 57;
            this.dateTimePicker_tn.UseWaitCursor = true;
            this.dateTimePicker_tn.ValueChanged += new System.EventHandler(this.dateTimePicker_tn_ValueChanged);
            this.dateTimePicker_tn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker_tn_KeyPress);
            // 
            // label_tongloinhuan
            // 
            this.label_tongloinhuan.AutoSize = true;
            this.label_tongloinhuan.BackColor = System.Drawing.Color.Transparent;
            this.label_tongloinhuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_tongloinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tongloinhuan.ForeColor = System.Drawing.Color.Red;
            this.label_tongloinhuan.Location = new System.Drawing.Point(1129, 528);
            this.label_tongloinhuan.Name = "label_tongloinhuan";
            this.label_tongloinhuan.Size = new System.Drawing.Size(194, 29);
            this.label_tongloinhuan.TabIndex = 62;
            this.label_tongloinhuan.Text = "Tổng lợi nhuận ";
            // 
            // pictureBox_bd
            // 
            this.pictureBox_bd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_bd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_bd.Image = global::UI.Properties.Resources.coollogo_com_204993751;
            this.pictureBox_bd.Location = new System.Drawing.Point(239, -20);
            this.pictureBox_bd.Name = "pictureBox_bd";
            this.pictureBox_bd.Size = new System.Drawing.Size(828, 88);
            this.pictureBox_bd.TabIndex = 63;
            this.pictureBox_bd.TabStop = false;
            // 
            // pictureBox_tg
            // 
            this.pictureBox_tg.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_tg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_tg.Image = global::UI.Properties.Resources.coollogo_com_289184551;
            this.pictureBox_tg.Location = new System.Drawing.Point(178, 10);
            this.pictureBox_tg.Name = "pictureBox_tg";
            this.pictureBox_tg.Size = new System.Drawing.Size(833, 96);
            this.pictureBox_tg.TabIndex = 64;
            this.pictureBox_tg.TabStop = false;
            // 
            // pictureBox_mh
            // 
            this.pictureBox_mh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_mh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_mh.Image = global::UI.Properties.Resources.coollogo_com_40634744;
            this.pictureBox_mh.Location = new System.Drawing.Point(178, 10);
            this.pictureBox_mh.Name = "pictureBox_mh";
            this.pictureBox_mh.Size = new System.Drawing.Size(833, 96);
            this.pictureBox_mh.TabIndex = 65;
            this.pictureBox_mh.TabStop = false;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.gray;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.pictureBox_mh);
            this.Controls.Add(this.pictureBox_tg);
            this.Controls.Add(this.pictureBox_bd);
            this.Controls.Add(this.label_tongloinhuan);
            this.Controls.Add(this.radioButton_tt);
            this.Controls.Add(this.radioButton_tn);
            this.Controls.Add(this.dateTimePicker_tn);
            this.Controls.Add(this.dataGridView_theothang);
            this.Controls.Add(this.comboBox_dt_loinhuan);
            this.Controls.Add(this.radioButton_dt_bd);
            this.Controls.Add(this.dataGridView_theohang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_theothoigian);
            this.Controls.Add(this.radioButton_theohang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart_bh);
            this.Controls.Add(this.button_dt_quaylai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoanhThu";
            this.Text = "DOANH THU";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_bh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_theohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHBindingSource)).EndInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.bH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_theothang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dt_quaylai;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_theohang;
        private System.Windows.Forms.RadioButton radioButton_theothoigian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_theohang;
    //    private System.Windows.Forms.BindingSource dOANHTHUBindingSource;
        private System.Windows.Forms.BindingSource bHBindingSource;
        private BanHang bH;
        private System.Windows.Forms.RadioButton radioButton_dt_bd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comboBox_dt_loinhuan;
        private System.Windows.Forms.DataGridView dataGridView_theothang;
        private System.Windows.Forms.RadioButton radioButton_tn;
        private System.Windows.Forms.RadioButton radioButton_tt;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label_tongloinhuan;
        private System.Windows.Forms.PictureBox pictureBox_bd;
        private System.Windows.Forms.PictureBox pictureBox_tg;
        private System.Windows.Forms.PictureBox pictureBox_mh;

    }
}
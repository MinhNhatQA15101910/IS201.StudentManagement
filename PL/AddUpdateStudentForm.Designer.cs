namespace PL
{
    partial class AddUpdateStudentForm
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
            this.plt1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblHoSoSinhVien = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMSSV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXacNhan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpickerNgaySinh = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblNganh = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // plt1
            // 
            this.plt1.ButtonSpecs.FormClose.Image = global::PL.Properties.Resources.img_orange_circle_20;
            this.plt1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::PL.Properties.Resources.img_orange_circle_201;
            this.plt1.ButtonSpecs.FormMax.Image = global::PL.Properties.Resources.img_yellow_circle_20;
            this.plt1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::PL.Properties.Resources.img_yellow_circle_20;
            this.plt1.ButtonSpecs.FormMin.Image = global::PL.Properties.Resources.img_green_circle_20;
            this.plt1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::PL.Properties.Resources.img_green_circle_20;
            this.plt1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.plt1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.plt1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.plt1.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.plt1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.plt1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            // 
            // lblHoSoSinhVien
            // 
            this.lblHoSoSinhVien.AutoSize = false;
            this.lblHoSoSinhVien.Location = new System.Drawing.Point(360, 1);
            this.lblHoSoSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHoSoSinhVien.Name = "lblHoSoSinhVien";
            this.lblHoSoSinhVien.Size = new System.Drawing.Size(259, 44);
            this.lblHoSoSinhVien.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblHoSoSinhVien.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.lblHoSoSinhVien.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoSoSinhVien.TabIndex = 85;
            this.lblHoSoSinhVien.Values.Text = "HỒ SƠ SINH VIÊN";
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(693, 159);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(51, 23);
            this.rbtnNu.TabIndex = 92;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(609, 159);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(62, 23);
            this.rbtnNam.TabIndex = 91;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(191, 152);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(259, 33);
            this.txtHoTen.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHoTen.StateActive.Border.Rounding = 15;
            this.txtHoTen.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.txtHoTen.TabIndex = 90;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(191, 83);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(259, 33);
            this.txtMSSV.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMSSV.StateActive.Border.Rounding = 15;
            this.txtMSSV.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.txtMSSV.TabIndex = 89;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(81, 159);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(78, 19);
            this.lblHoTen.TabIndex = 88;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(498, 90);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 19);
            this.lblNgaySinh.TabIndex = 94;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(81, 90);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(57, 19);
            this.lblMSSV.TabIndex = 87;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(498, 159);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(75, 19);
            this.lblGioiTinh.TabIndex = 93;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(704, 297);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(109)))), ((int)(((byte)(69)))));
            this.btnClear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(124)))));
            this.btnClear.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnClear.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnClear.OverrideDefault.Border.Rounding = 18;
            this.btnClear.Size = new System.Drawing.Size(146, 52);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(109)))), ((int)(((byte)(69)))));
            this.btnClear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(124)))));
            this.btnClear.StateCommon.Border.ColorAngle = 45F;
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnClear.StateCommon.Border.Rounding = 20;
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnClear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnClear.StatePressed.Back.ColorAngle = 130F;
            this.btnClear.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnClear.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.btnClear.StatePressed.Border.ColorAngle = 130F;
            this.btnClear.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StatePressed.Border.Rounding = 20;
            this.btnClear.StatePressed.Border.Width = 1;
            this.btnClear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnClear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnClear.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateTracking.Border.Rounding = 20;
            this.btnClear.StateTracking.Border.Width = 1;
            this.btnClear.TabIndex = 109;
            this.btnClear.Values.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Location = new System.Drawing.Point(502, 297);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.btnXacNhan.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.btnXacNhan.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXacNhan.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXacNhan.OverrideDefault.Border.Rounding = 18;
            this.btnXacNhan.Size = new System.Drawing.Size(161, 52);
            this.btnXacNhan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.btnXacNhan.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.btnXacNhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.btnXacNhan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.btnXacNhan.StateCommon.Border.ColorAngle = 45F;
            this.btnXacNhan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXacNhan.StateCommon.Border.Rounding = 20;
            this.btnXacNhan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.btnXacNhan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.btnXacNhan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.btnXacNhan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.btnXacNhan.StatePressed.Back.ColorAngle = 130F;
            this.btnXacNhan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.btnXacNhan.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.btnXacNhan.StatePressed.Border.ColorAngle = 130F;
            this.btnXacNhan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.StatePressed.Border.Rounding = 20;
            this.btnXacNhan.StatePressed.Border.Width = 1;
            this.btnXacNhan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.btnXacNhan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.btnXacNhan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXacNhan.StateTracking.Border.Rounding = 20;
            this.btnXacNhan.StateTracking.Border.Width = 1;
            this.btnXacNhan.TabIndex = 108;
            this.btnXacNhan.Values.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dtpickerNgaySinh
            // 
            this.dtpickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpickerNgaySinh.Location = new System.Drawing.Point(609, 88);
            this.dtpickerNgaySinh.MaxDate = new System.DateTime(2023, 6, 14, 0, 0, 0, 0);
            this.dtpickerNgaySinh.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpickerNgaySinh.Name = "dtpickerNgaySinh";
            this.dtpickerNgaySinh.Size = new System.Drawing.Size(259, 28);
            this.dtpickerNgaySinh.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpickerNgaySinh.TabIndex = 126;
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNganh.Location = new System.Drawing.Point(81, 226);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(57, 19);
            this.lblNganh.TabIndex = 98;
            this.lblNganh.Text = "Ngành:";
            this.lblNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(191, 226);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(259, 33);
            this.kryptonTextBox1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateActive.Border.Rounding = 15;
            this.kryptonTextBox1.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.kryptonTextBox1.TabIndex = 127;
            // 
            // AddUpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 371);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.dtpickerNgaySinh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblNganh);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoSoSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddUpdateStudentForm";
            this.Palette = this.plt1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemSuaSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.ThemSuaSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette plt1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHoSoSinhVien;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHoTen;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXacNhan;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpickerNgaySinh;
        private System.Windows.Forms.Label lblNganh;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}
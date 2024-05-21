
namespace PL
{
    partial class StudentManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.majorLabel = new System.Windows.Forms.Label();
            this.plt1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.studentListDgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.genderLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.studentListLabel = new System.Windows.Forms.Label();
            this.detailInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.majorTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateOfBirthTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.fullNameTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.studentIdTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.featuresPanel = new System.Windows.Forms.Panel();
            this.updateBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.studentListGroupBox = new System.Windows.Forms.GroupBox();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.plt2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.picBoLoc = new System.Windows.Forms.PictureBox();
            this.filterPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDgv)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.detailInfoGroupBox.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.featuresPanel.SuspendLayout();
            this.studentListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(45, 138);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(57, 19);
            this.majorLabel.TabIndex = 33;
            this.majorLabel.Text = "Ngành:";
            this.majorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plt1
            // 
            this.plt1.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.plt1.Common.StateCommon.Border.Rounding = 12;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(604, 30);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(81, 19);
            this.dateOfBirthLabel.TabIndex = 25;
            this.dateOfBirthLabel.Text = "Ngày sinh:";
            // 
            // studentListDgv
            // 
            this.studentListDgv.AllowUserToAddRows = false;
            this.studentListDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.studentListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.studentListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentListDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentListDgv.Location = new System.Drawing.Point(3, 22);
            this.studentListDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListDgv.MultiSelect = false;
            this.studentListDgv.Name = "studentListDgv";
            this.studentListDgv.ReadOnly = true;
            this.studentListDgv.RowHeadersVisible = false;
            this.studentListDgv.RowHeadersWidth = 51;
            this.studentListDgv.RowTemplate.Height = 24;
            this.studentListDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentListDgv.Size = new System.Drawing.Size(1087, 383);
            this.studentListDgv.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.studentListDgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.studentListDgv.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.studentListDgv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.studentListDgv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.studentListDgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.studentListDgv.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListDgv.StateCommon.HeaderColumn.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.studentListDgv.TabIndex = 46;
            this.studentListDgv.SelectionChanged += new System.EventHandler(this.OnStudentsGridViewSelectionChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(604, 101);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(75, 19);
            this.genderLabel.TabIndex = 24;
            this.genderLabel.Text = "Giới tính:";
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.studentListLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1093, 54);
            this.titlePanel.TabIndex = 51;
            // 
            // studentListLabel
            // 
            this.studentListLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListLabel.Location = new System.Drawing.Point(384, 9);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(346, 34);
            this.studentListLabel.TabIndex = 0;
            this.studentListLabel.Text = "QUẢN LÝ SINH VIÊN\r\n";
            // 
            // detailInfoGroupBox
            // 
            this.detailInfoGroupBox.Controls.Add(this.majorTxt);
            this.detailInfoGroupBox.Controls.Add(this.dateOfBirthTxt);
            this.detailInfoGroupBox.Controls.Add(this.majorLabel);
            this.detailInfoGroupBox.Controls.Add(this.femaleRBtn);
            this.detailInfoGroupBox.Controls.Add(this.maleRBtn);
            this.detailInfoGroupBox.Controls.Add(this.fullNameTxt);
            this.detailInfoGroupBox.Controls.Add(this.studentIdTxt);
            this.detailInfoGroupBox.Controls.Add(this.fullNameLabel);
            this.detailInfoGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.detailInfoGroupBox.Controls.Add(this.studentIdLabel);
            this.detailInfoGroupBox.Controls.Add(this.genderLabel);
            this.detailInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailInfoGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailInfoGroupBox.Location = new System.Drawing.Point(0, 54);
            this.detailInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailInfoGroupBox.Name = "detailInfoGroupBox";
            this.detailInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailInfoGroupBox.Size = new System.Drawing.Size(1093, 199);
            this.detailInfoGroupBox.TabIndex = 52;
            this.detailInfoGroupBox.TabStop = false;
            this.detailInfoGroupBox.Text = "Thông tin chi tiết";
            // 
            // majorTxt
            // 
            this.majorTxt.Location = new System.Drawing.Point(152, 130);
            this.majorTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.majorTxt.Name = "majorTxt";
            this.majorTxt.ReadOnly = true;
            this.majorTxt.Size = new System.Drawing.Size(229, 33);
            this.majorTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.majorTxt.StateActive.Border.Rounding = 15;
            this.majorTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.majorTxt.TabIndex = 52;
            // 
            // dateOfBirthTxt
            // 
            this.dateOfBirthTxt.Location = new System.Drawing.Point(715, 23);
            this.dateOfBirthTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfBirthTxt.Name = "dateOfBirthTxt";
            this.dateOfBirthTxt.ReadOnly = true;
            this.dateOfBirthTxt.Size = new System.Drawing.Size(229, 33);
            this.dateOfBirthTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateOfBirthTxt.StateActive.Border.Rounding = 15;
            this.dateOfBirthTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.dateOfBirthTxt.TabIndex = 50;
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Enabled = false;
            this.femaleRBtn.Location = new System.Drawing.Point(836, 101);
            this.femaleRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(51, 23);
            this.femaleRBtn.TabIndex = 17;
            this.femaleRBtn.TabStop = true;
            this.femaleRBtn.Text = "Nữ";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Enabled = false;
            this.maleRBtn.Location = new System.Drawing.Point(715, 101);
            this.maleRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(62, 23);
            this.maleRBtn.TabIndex = 16;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Nam";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Location = new System.Drawing.Point(149, 78);
            this.fullNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.ReadOnly = true;
            this.fullNameTxt.Size = new System.Drawing.Size(236, 33);
            this.fullNameTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fullNameTxt.StateActive.Border.Rounding = 15;
            this.fullNameTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.fullNameTxt.TabIndex = 15;
            // 
            // studentIdTxt
            // 
            this.studentIdTxt.Location = new System.Drawing.Point(152, 23);
            this.studentIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentIdTxt.Name = "studentIdTxt";
            this.studentIdTxt.ReadOnly = true;
            this.studentIdTxt.Size = new System.Drawing.Size(229, 33);
            this.studentIdTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.studentIdTxt.StateActive.Border.Rounding = 15;
            this.studentIdTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.studentIdTxt.TabIndex = 11;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(45, 84);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(78, 19);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "Họ và tên:";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(45, 30);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(57, 19);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "MSSV:";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.picBoLoc);
            this.searchPanel.Controls.Add(this.filterPictureBox);
            this.searchPanel.Controls.Add(this.searchTxt);
            this.searchPanel.Location = new System.Drawing.Point(0, 258);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(779, 126);
            this.searchPanel.TabIndex = 53;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(25, 38);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(612, 31);
            this.searchTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.searchTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchTxt.StateCommon.Border.Rounding = 14;
            this.searchTxt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.TabIndex = 10;
            this.searchTxt.Text = "🔎 Tìm kiếm";
            this.searchTxt.Enter += new System.EventHandler(this.OnSearchTxtEntered);
            this.searchTxt.Leave += new System.EventHandler(this.OnSearchTxtLeft);
            // 
            // featuresPanel
            // 
            this.featuresPanel.Controls.Add(this.updateBtn);
            this.featuresPanel.Controls.Add(this.deleteBtn);
            this.featuresPanel.Controls.Add(this.addBtn);
            this.featuresPanel.Location = new System.Drawing.Point(811, 260);
            this.featuresPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.featuresPanel.Name = "featuresPanel";
            this.featuresPanel.Size = new System.Drawing.Size(277, 124);
            this.featuresPanel.TabIndex = 54;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(77, 64);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.updateBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.updateBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.updateBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.updateBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.Size = new System.Drawing.Size(125, 52);
            this.updateBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.updateBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.updateBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.StateCommon.Border.Rounding = 15;
            this.updateBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.updateBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.updateBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.updateBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.updateBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.updateBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.updateBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.updateBtn.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.updateBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Values.Text = " SỬA";
            this.updateBtn.Click += new System.EventHandler(this.OnUpdateBtnClicked);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(143, 6);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.deleteBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.deleteBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.deleteBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.deleteBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.Size = new System.Drawing.Size(125, 52);
            this.deleteBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.deleteBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.StateCommon.Border.Rounding = 15;
            this.deleteBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.deleteBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.deleteBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deleteBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deleteBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.deleteBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.deleteBtn.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Values.Text = " XÓA";
            this.deleteBtn.Click += new System.EventHandler(this.OnDeleteBtnClicked);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(8, 6);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.addBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.addBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.addBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.addBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addBtn.Size = new System.Drawing.Size(125, 52);
            this.addBtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.addBtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.addBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.addBtn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.addBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addBtn.StateCommon.Border.Rounding = 15;
            this.addBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addBtn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.addBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.addBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.addBtn.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.addBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addBtn.TabIndex = 39;
            this.addBtn.Values.Text = "THÊM";
            this.addBtn.Click += new System.EventHandler(this.OnAddBtnClicked);
            // 
            // studentListGroupBox
            // 
            this.studentListGroupBox.Controls.Add(this.studentListDgv);
            this.studentListGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListGroupBox.Location = new System.Drawing.Point(0, 382);
            this.studentListGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListGroupBox.Name = "studentListGroupBox";
            this.studentListGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListGroupBox.Size = new System.Drawing.Size(1093, 407);
            this.studentListGroupBox.TabIndex = 55;
            this.studentListGroupBox.TabStop = false;
            this.studentListGroupBox.Text = "Danh sách sinh viên";
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separatorPanel.Location = new System.Drawing.Point(792, 266);
            this.separatorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(3, 110);
            this.separatorPanel.TabIndex = 47;
            // 
            // plt2
            // 
            this.plt2.ButtonSpecs.FormClose.Image = global::PL.Properties.Resources.img_orange_circle_20;
            this.plt2.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::PL.Properties.Resources.img_orange_circle_201;
            this.plt2.ButtonSpecs.FormMax.Image = global::PL.Properties.Resources.img_yellow_circle_20;
            this.plt2.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::PL.Properties.Resources.img_yellow_circle_20;
            this.plt2.ButtonSpecs.FormMin.Image = global::PL.Properties.Resources.img_green_circle_20;
            this.plt2.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::PL.Properties.Resources.img_green_circle_20;
            this.plt2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.plt2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.plt2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.plt2.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.plt2.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.plt2.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            // 
            // picBoLoc
            // 
            this.picBoLoc.BackgroundImage = global::PL.Properties.Resources.img_cancel_filter;
            this.picBoLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoLoc.Location = new System.Drawing.Point(715, 38);
            this.picBoLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoLoc.Name = "picBoLoc";
            this.picBoLoc.Size = new System.Drawing.Size(40, 38);
            this.picBoLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoLoc.TabIndex = 24;
            this.picBoLoc.TabStop = false;
            this.picBoLoc.Click += new System.EventHandler(this.OnCancelFilterClicked);
            // 
            // filterPictureBox
            // 
            this.filterPictureBox.BackgroundImage = global::PL.Properties.Resources.img_filter;
            this.filterPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filterPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterPictureBox.InitialImage = null;
            this.filterPictureBox.Location = new System.Drawing.Point(669, 31);
            this.filterPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterPictureBox.Name = "filterPictureBox";
            this.filterPictureBox.Size = new System.Drawing.Size(40, 46);
            this.filterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterPictureBox.TabIndex = 23;
            this.filterPictureBox.TabStop = false;
            this.filterPictureBox.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 801);
            this.Controls.Add(this.separatorPanel);
            this.Controls.Add(this.studentListGroupBox);
            this.Controls.Add(this.featuresPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.detailInfoGroupBox);
            this.Controls.Add(this.titlePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StudentManagementForm";
            this.Palette = this.plt2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.studentListDgv)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.detailInfoGroupBox.ResumeLayout(false);
            this.detailInfoGroupBox.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.featuresPanel.ResumeLayout(false);
            this.studentListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label majorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette plt1;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView studentListDgv;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label studentListLabel;
        private System.Windows.Forms.GroupBox detailInfoGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fullNameTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox studentIdTxt;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.Panel searchPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchTxt;
        private System.Windows.Forms.Panel featuresPanel;
        private System.Windows.Forms.GroupBox studentListGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox dateOfBirthTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox majorTxt;
        private System.Windows.Forms.Panel separatorPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette plt2;
        private System.Windows.Forms.PictureBox filterPictureBox;
        private System.Windows.Forms.PictureBox picBoLoc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateBtn;
    }
}
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
            this.titleLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.fullNameTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.studentIdTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.clearBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.verifyBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dobDatePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.majorLabel = new System.Windows.Forms.Label();
            this.majorTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = false;
            this.titleLabel.Location = new System.Drawing.Point(313, -3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 44);
            this.titleLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.titleLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.titleLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.TabIndex = 85;
            this.titleLabel.Values.Text = "THÊM SINH VIÊN";
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Location = new System.Drawing.Point(625, 145);
            this.femaleRBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(51, 23);
            this.femaleRBtn.TabIndex = 92;
            this.femaleRBtn.TabStop = true;
            this.femaleRBtn.Text = "Nữ";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Location = new System.Drawing.Point(541, 145);
            this.maleRBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(62, 23);
            this.maleRBtn.TabIndex = 91;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Nam";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Location = new System.Drawing.Point(123, 145);
            this.fullNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(259, 33);
            this.fullNameTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fullNameTxt.StateActive.Border.Rounding = 15;
            this.fullNameTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.fullNameTxt.TabIndex = 90;
            // 
            // studentIdTxt
            // 
            this.studentIdTxt.Location = new System.Drawing.Point(123, 76);
            this.studentIdTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentIdTxt.Name = "studentIdTxt";
            this.studentIdTxt.Size = new System.Drawing.Size(259, 33);
            this.studentIdTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.studentIdTxt.StateActive.Border.Rounding = 15;
            this.studentIdTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.studentIdTxt.TabIndex = 89;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(13, 152);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(78, 19);
            this.fullNameLabel.TabIndex = 88;
            this.fullNameLabel.Text = "Họ và tên:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(430, 76);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(81, 19);
            this.dateOfBirthLabel.TabIndex = 94;
            this.dateOfBirthLabel.Text = "Ngày sinh:";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.Location = new System.Drawing.Point(13, 83);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(57, 19);
            this.studentIdLabel.TabIndex = 87;
            this.studentIdLabel.Text = "MSSV:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(430, 145);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(75, 19);
            this.genderLabel.TabIndex = 93;
            this.genderLabel.Text = "Giới tính:";
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Location = new System.Drawing.Point(550, 297);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(109)))), ((int)(((byte)(69)))));
            this.clearBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(124)))));
            this.clearBtn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.clearBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.clearBtn.OverrideDefault.Border.Rounding = 18;
            this.clearBtn.Size = new System.Drawing.Size(146, 52);
            this.clearBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.clearBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.clearBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(109)))), ((int)(((byte)(69)))));
            this.clearBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(124)))));
            this.clearBtn.StateCommon.Border.ColorAngle = 45F;
            this.clearBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.clearBtn.StateCommon.Border.Rounding = 20;
            this.clearBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.clearBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.clearBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.clearBtn.StatePressed.Back.ColorAngle = 130F;
            this.clearBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.clearBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.clearBtn.StatePressed.Border.ColorAngle = 130F;
            this.clearBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearBtn.StatePressed.Border.Rounding = 20;
            this.clearBtn.StatePressed.Border.Width = 1;
            this.clearBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.clearBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.clearBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clearBtn.StateTracking.Border.Rounding = 20;
            this.clearBtn.StateTracking.Border.Width = 1;
            this.clearBtn.TabIndex = 109;
            this.clearBtn.Values.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.OnClearBtnClicked);
            // 
            // verifyBtn
            // 
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.Location = new System.Drawing.Point(360, 297);
            this.verifyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.verifyBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.verifyBtn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.verifyBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.verifyBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.verifyBtn.OverrideDefault.Border.Rounding = 18;
            this.verifyBtn.Size = new System.Drawing.Size(161, 52);
            this.verifyBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.verifyBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.verifyBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.verifyBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.verifyBtn.StateCommon.Border.ColorAngle = 45F;
            this.verifyBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.verifyBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.verifyBtn.StateCommon.Border.Rounding = 20;
            this.verifyBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.verifyBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SeaShell;
            this.verifyBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.verifyBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.verifyBtn.StatePressed.Back.ColorAngle = 130F;
            this.verifyBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.verifyBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(226)))), ((int)(((byte)(192)))));
            this.verifyBtn.StatePressed.Border.ColorAngle = 130F;
            this.verifyBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.verifyBtn.StatePressed.Border.Rounding = 20;
            this.verifyBtn.StatePressed.Border.Width = 1;
            this.verifyBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.verifyBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(136)))), ((int)(((byte)(61)))));
            this.verifyBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.verifyBtn.StateTracking.Border.Rounding = 20;
            this.verifyBtn.StateTracking.Border.Width = 1;
            this.verifyBtn.TabIndex = 108;
            this.verifyBtn.Values.Text = "XÁC NHẬN";
            this.verifyBtn.Click += new System.EventHandler(this.OnVerifyBtnClicked);
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.CustomFormat = "dd/MM/yyyy";
            this.dobDatePicker.Location = new System.Drawing.Point(541, 74);
            this.dobDatePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dobDatePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(259, 28);
            this.dobDatePicker.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dobDatePicker.TabIndex = 126;
            this.dobDatePicker.ValueNullable = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(13, 219);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(57, 19);
            this.majorLabel.TabIndex = 98;
            this.majorLabel.Text = "Ngành:";
            this.majorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // majorTxt
            // 
            this.majorTxt.Location = new System.Drawing.Point(123, 219);
            this.majorTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.majorTxt.Name = "majorTxt";
            this.majorTxt.Size = new System.Drawing.Size(259, 33);
            this.majorTxt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.majorTxt.StateActive.Border.Rounding = 15;
            this.majorTxt.StateActive.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorTxt.StateActive.Content.Padding = new System.Windows.Forms.Padding(2, -1, -1, -1);
            this.majorTxt.TabIndex = 127;
            // 
            // AddUpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 371);
            this.Controls.Add(this.majorTxt);
            this.Controls.Add(this.dobDatePicker);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.femaleRBtn);
            this.Controls.Add(this.maleRBtn);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.studentIdTxt);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddUpdateStudentForm";
            this.Palette = this.plt1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette plt1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel titleLabel;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fullNameTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox studentIdTxt;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label genderLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton clearBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton verifyBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dobDatePicker;
        private System.Windows.Forms.Label majorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox majorTxt;
    }
}
namespace WinFormsApp1
{
    partial class UC_ProductReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxReport = new ListBox();
            cbPid = new ReaLTaiizor.Controls.ForeverComboBox();
            dtStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            dtEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            btngenerateWh = new ReaLTaiizor.Controls.NightButton();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBoxReport
            // 
            listBoxReport.BackColor = Color.Silver;
            listBoxReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxReport.FormattingEnabled = true;
            listBoxReport.Location = new Point(395, 58);
            listBoxReport.Name = "listBoxReport";
            listBoxReport.Size = new Size(572, 279);
            listBoxReport.TabIndex = 46;
            // 
            // cbPid
            // 
            cbPid.BackColor = Color.Maroon;
            cbPid.BaseColor = Color.Firebrick;
            cbPid.BGColor = Color.Maroon;
            cbPid.Cursor = Cursors.No;
            cbPid.DrawMode = DrawMode.OwnerDrawFixed;
            cbPid.DropDownHeight = 140;
            cbPid.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPid.Font = new Font("Segoe UI", 8F);
            cbPid.ForeColor = Color.White;
            cbPid.FormattingEnabled = true;
            cbPid.HoverColor = Color.DarkRed;
            cbPid.HoverFontColor = Color.White;
            cbPid.IntegralHeight = false;
            cbPid.ItemHeight = 18;
            cbPid.Location = new Point(171, 59);
            cbPid.Name = "cbPid";
            cbPid.Size = new Size(174, 24);
            cbPid.TabIndex = 47;
            // 
            // dtStartDate
            // 
            dtStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtStartDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtStartDate.Location = new Point(171, 188);
            dtStartDate.MinimumSize = new Size(0, 30);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(174, 30);
            dtStartDate.TabIndex = 48;
            dtStartDate.UseStyleColors = true;
            // 
            // dtEndDate
            // 
            dtEndDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtEndDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtEndDate.Location = new Point(171, 224);
            dtEndDate.MinimumSize = new Size(0, 30);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(174, 30);
            dtEndDate.TabIndex = 49;
            dtEndDate.UseStyleColors = true;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(57, 231);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(78, 23);
            dungeonHeaderLabel2.TabIndex = 50;
            dungeonHeaderLabel2.Text = "EndDate";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(57, 193);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(93, 23);
            dungeonHeaderLabel1.TabIndex = 51;
            dungeonHeaderLabel1.Text = "Start Date";
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel3.Location = new Point(57, 100);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(295, 23);
            dungeonHeaderLabel3.TabIndex = 52;
            dungeonHeaderLabel3.Text = "Warwhouses (separated by comma)";
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel4.Location = new Point(62, 58);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(73, 23);
            dungeonHeaderLabel4.TabIndex = 53;
            dungeonHeaderLabel4.Text = "Product";
            // 
            // btngenerateWh
            // 
            btngenerateWh.BackColor = Color.Transparent;
            btngenerateWh.DialogResult = DialogResult.None;
            btngenerateWh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btngenerateWh.ForeColor = Color.DarkRed;
            btngenerateWh.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btngenerateWh.HoverForeColor = Color.White;
            btngenerateWh.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btngenerateWh.Location = new Point(169, 273);
            btngenerateWh.MinimumSize = new Size(144, 47);
            btngenerateWh.Name = "btngenerateWh";
            btngenerateWh.NormalBackColor = Color.DarkRed;
            btngenerateWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btngenerateWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btngenerateWh.PressedForeColor = Color.White;
            btngenerateWh.Radius = 20;
            btngenerateWh.Size = new Size(182, 64);
            btngenerateWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btngenerateWh.TabIndex = 54;
            btngenerateWh.Text = "Generate Report";
            btngenerateWh.Click += btngeneratePR_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 55;
            // 
            // ProductReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(textBox1);
            Controls.Add(btngenerateWh);
            Controls.Add(dungeonHeaderLabel4);
            Controls.Add(dungeonHeaderLabel3);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(dungeonHeaderLabel2);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(cbPid);
            Controls.Add(listBoxReport);
            Name = "ProductReportControl";
            Size = new Size(992, 377);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReport;
        private ReaLTaiizor.Controls.ForeverComboBox cbPid;
        private ReaLTaiizor.Controls.PoisonDateTime dtStartDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtEndDate;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.NightButton btngenerateWh;
        private TextBox textBox1;
    }
}

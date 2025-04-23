namespace WinFormsApp1
{
    partial class WarehouseReportControl
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
            dungeonHeaderLabel7 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dtStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            dtEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            btngenerateWh = new ReaLTaiizor.Controls.NightButton();
            listBoxReport = new ListBox();
            cbWhId = new ReaLTaiizor.Controls.ForeverComboBox();
            SuspendLayout();
            // 
            // dungeonHeaderLabel7
            // 
            dungeonHeaderLabel7.AutoSize = true;
            dungeonHeaderLabel7.BackColor = Color.Transparent;
            dungeonHeaderLabel7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel7.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel7.Location = new Point(23, 131);
            dungeonHeaderLabel7.Name = "dungeonHeaderLabel7";
            dungeonHeaderLabel7.Size = new Size(93, 23);
            dungeonHeaderLabel7.TabIndex = 36;
            dungeonHeaderLabel7.Text = "Start Date";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(23, 186);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(83, 23);
            dungeonHeaderLabel1.TabIndex = 37;
            dungeonHeaderLabel1.Text = "End Date";
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(23, 82);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(108, 23);
            dungeonHeaderLabel2.TabIndex = 38;
            dungeonHeaderLabel2.Text = "Warwhouse ";
            // 
            // dtStartDate
            // 
            dtStartDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtStartDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtStartDate.Location = new Point(137, 126);
            dtStartDate.MinimumSize = new Size(0, 30);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(174, 30);
            dtStartDate.TabIndex = 40;
            dtStartDate.UseStyleColors = true;
            // 
            // dtEndDate
            // 
            dtEndDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtEndDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtEndDate.Location = new Point(137, 179);
            dtEndDate.MinimumSize = new Size(0, 30);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(174, 30);
            dtEndDate.TabIndex = 41;
            dtEndDate.UseStyleColors = true;
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
            btngenerateWh.Location = new Point(137, 264);
            btngenerateWh.MinimumSize = new Size(144, 47);
            btngenerateWh.Name = "btngenerateWh";
            btngenerateWh.NormalBackColor = Color.DarkRed;
            btngenerateWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btngenerateWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btngenerateWh.PressedForeColor = Color.White;
            btngenerateWh.Radius = 20;
            btngenerateWh.Size = new Size(182, 64);
            btngenerateWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btngenerateWh.TabIndex = 44;
            btngenerateWh.Text = "Generate Report";
            btngenerateWh.Click += btngenerateWh_Click;
            // 
            // listBoxReport
            // 
            listBoxReport.BackColor = Color.Silver;
            listBoxReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxReport.FormattingEnabled = true;
            listBoxReport.Location = new Point(363, 49);
            listBoxReport.Name = "listBoxReport";
            listBoxReport.Size = new Size(604, 279);
            listBoxReport.TabIndex = 45;
            // 
            // cbWhId
            // 
            cbWhId.BackColor = Color.Maroon;
            cbWhId.BaseColor = Color.Firebrick;
            cbWhId.BGColor = Color.Maroon;
            cbWhId.DrawMode = DrawMode.OwnerDrawFixed;
            cbWhId.DropDownHeight = 140;
            cbWhId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWhId.Font = new Font("Segoe UI", 8F);
            cbWhId.ForeColor = Color.White;
            cbWhId.FormattingEnabled = true;
            cbWhId.HoverColor = Color.DarkRed;
            cbWhId.HoverFontColor = Color.White;
            cbWhId.IntegralHeight = false;
            cbWhId.ItemHeight = 18;
            cbWhId.Location = new Point(137, 81);
            cbWhId.Name = "cbWhId";
            cbWhId.Size = new Size(174, 24);
            cbWhId.TabIndex = 46;
            // 
            // WarehouseReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cbWhId);
            Controls.Add(listBoxReport);
            Controls.Add(btngenerateWh);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(dungeonHeaderLabel2);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(dungeonHeaderLabel7);
            Name = "WarehouseReportControl";
            Size = new Size(992, 377);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel7;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.PoisonDateTime dtStartDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtEndDate;
        private ReaLTaiizor.Controls.NightButton btngenerateWh;
        private ListBox listBoxReport;
        private ReaLTaiizor.Controls.ForeverComboBox cbWhId;
    }
}

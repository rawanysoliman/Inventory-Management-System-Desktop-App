namespace WinFormsApp1
{
    partial class UC_ReleasePerm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvRelsPerm = new ReaLTaiizor.Controls.PoisonDataGridView();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel7 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dtRlsDate = new ReaLTaiizor.Controls.PoisonDateTime();
            cbWhId = new ReaLTaiizor.Controls.ForeverComboBox();
            btnAddRlsPerm = new ReaLTaiizor.Controls.NightButton();
            btnUpdate = new ReaLTaiizor.Controls.NightButton();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel5 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel8 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbCategory = new ReaLTaiizor.Controls.ForeverComboBox();
            cbProductId = new ReaLTaiizor.Controls.ForeverComboBox();
            numQuantity = new ReaLTaiizor.Controls.ForeverNumeric();
            btnUpdateStock = new ReaLTaiizor.Controls.NightButton();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbCustomerId = new ReaLTaiizor.Controls.ForeverComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRelsPerm).BeginInit();
            SuspendLayout();
            // 
            // dgvRelsPerm
            // 
            dgvRelsPerm.AllowUserToResizeRows = false;
            dgvRelsPerm.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvRelsPerm.BorderStyle = BorderStyle.Fixed3D;
            dgvRelsPerm.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRelsPerm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRelsPerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelsPerm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRelsPerm.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRelsPerm.EnableHeadersVisualStyles = false;
            dgvRelsPerm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvRelsPerm.GridColor = Color.FromArgb(255, 255, 255);
            dgvRelsPerm.Location = new Point(434, 13);
            dgvRelsPerm.Name = "dgvRelsPerm";
            dgvRelsPerm.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRelsPerm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRelsPerm.RowHeadersWidth = 51;
            dgvRelsPerm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvRelsPerm.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRelsPerm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelsPerm.Size = new Size(526, 294);
            dgvRelsPerm.TabIndex = 16;
            dgvRelsPerm.SelectionChanged += dgvReleasePerm_SelectionChanged;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(13, 27);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(112, 23);
            dungeonHeaderLabel1.TabIndex = 30;
            dungeonHeaderLabel1.Text = "Relaese Date";
            // 
            // dungeonHeaderLabel7
            // 
            dungeonHeaderLabel7.AutoSize = true;
            dungeonHeaderLabel7.BackColor = Color.Transparent;
            dungeonHeaderLabel7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel7.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel7.Location = new Point(13, 70);
            dungeonHeaderLabel7.Name = "dungeonHeaderLabel7";
            dungeonHeaderLabel7.Size = new Size(108, 23);
            dungeonHeaderLabel7.TabIndex = 36;
            dungeonHeaderLabel7.Text = "Warwhouse ";
            // 
            // dtRlsDate
            // 
            dtRlsDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtRlsDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtRlsDate.Location = new Point(210, 27);
            dtRlsDate.MinimumSize = new Size(0, 30);
            dtRlsDate.Name = "dtRlsDate";
            dtRlsDate.Size = new Size(142, 30);
            dtRlsDate.TabIndex = 38;
            dtRlsDate.UseStyleColors = true;
            // 
            // cbWhId
            // 
            cbWhId.BackColor = Color.Maroon;
            cbWhId.BaseColor = Color.Firebrick;
            cbWhId.BGColor = Color.Maroon;
            cbWhId.DrawMode = DrawMode.OwnerDrawFixed;
            cbWhId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWhId.Font = new Font("Segoe UI", 8F);
            cbWhId.ForeColor = Color.White;
            cbWhId.FormattingEnabled = true;
            cbWhId.HoverColor = Color.Red;
            cbWhId.HoverFontColor = Color.White;
            cbWhId.ItemHeight = 18;
            cbWhId.Location = new Point(208, 71);
            cbWhId.Name = "cbWhId";
            cbWhId.Size = new Size(144, 24);
            cbWhId.TabIndex = 39;
            // 
            // btnAddRlsPerm
            // 
            btnAddRlsPerm.BackColor = Color.Transparent;
            btnAddRlsPerm.DialogResult = DialogResult.None;
            btnAddRlsPerm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRlsPerm.ForeColor = Color.DarkRed;
            btnAddRlsPerm.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAddRlsPerm.HoverForeColor = Color.White;
            btnAddRlsPerm.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAddRlsPerm.Location = new Point(210, 174);
            btnAddRlsPerm.MinimumSize = new Size(144, 47);
            btnAddRlsPerm.Name = "btnAddRlsPerm";
            btnAddRlsPerm.NormalBackColor = Color.DarkRed;
            btnAddRlsPerm.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddRlsPerm.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddRlsPerm.PressedForeColor = Color.White;
            btnAddRlsPerm.Radius = 20;
            btnAddRlsPerm.Size = new Size(144, 47);
            btnAddRlsPerm.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddRlsPerm.TabIndex = 41;
            btnAddRlsPerm.Text = "Add ";
            btnAddRlsPerm.Click += btnAddReleasePerm_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.DialogResult = DialogResult.None;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.DarkRed;
            btnUpdate.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnUpdate.HoverForeColor = Color.White;
            btnUpdate.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnUpdate.Location = new Point(13, 174);
            btnUpdate.MinimumSize = new Size(144, 47);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NormalBackColor = Color.DarkRed;
            btnUpdate.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdate.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdate.PressedForeColor = Color.White;
            btnUpdate.Radius = 20;
            btnUpdate.Size = new Size(144, 47);
            btnUpdate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Update ";
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel4.Location = new Point(11, 252);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(146, 23);
            dungeonHeaderLabel4.TabIndex = 45;
            dungeonHeaderLabel4.Text = "Choose Category";
            // 
            // dungeonHeaderLabel5
            // 
            dungeonHeaderLabel5.AutoSize = true;
            dungeonHeaderLabel5.BackColor = Color.Transparent;
            dungeonHeaderLabel5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel5.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel5.Location = new Point(13, 284);
            dungeonHeaderLabel5.Name = "dungeonHeaderLabel5";
            dungeonHeaderLabel5.Size = new Size(78, 23);
            dungeonHeaderLabel5.TabIndex = 46;
            dungeonHeaderLabel5.Text = "Product ";
            // 
            // dungeonHeaderLabel8
            // 
            dungeonHeaderLabel8.AutoSize = true;
            dungeonHeaderLabel8.BackColor = Color.Transparent;
            dungeonHeaderLabel8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel8.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel8.Location = new Point(13, 320);
            dungeonHeaderLabel8.Name = "dungeonHeaderLabel8";
            dungeonHeaderLabel8.Size = new Size(80, 23);
            dungeonHeaderLabel8.TabIndex = 47;
            dungeonHeaderLabel8.Text = "Quantity";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Maroon;
            cbCategory.BaseColor = Color.Firebrick;
            cbCategory.BGColor = Color.Maroon;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 8F);
            cbCategory.ForeColor = Color.White;
            cbCategory.FormattingEnabled = true;
            cbCategory.HoverColor = Color.Red;
            cbCategory.HoverFontColor = Color.White;
            cbCategory.ItemHeight = 18;
            cbCategory.Location = new Point(208, 242);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(142, 24);
            cbCategory.TabIndex = 48;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbProductId
            // 
            cbProductId.BackColor = Color.Maroon;
            cbProductId.BaseColor = Color.Firebrick;
            cbProductId.BGColor = Color.Maroon;
            cbProductId.DrawMode = DrawMode.OwnerDrawFixed;
            cbProductId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductId.Font = new Font("Segoe UI", 8F);
            cbProductId.ForeColor = Color.White;
            cbProductId.FormattingEnabled = true;
            cbProductId.HoverColor = Color.Red;
            cbProductId.HoverFontColor = Color.White;
            cbProductId.ItemHeight = 18;
            cbProductId.Location = new Point(208, 283);
            cbProductId.Name = "cbProductId";
            cbProductId.Size = new Size(142, 24);
            cbProductId.TabIndex = 49;
            // 
            // numQuantity
            // 
            numQuantity.BaseColor = Color.Maroon;
            numQuantity.ButtonColorA = Color.IndianRed;
            numQuantity.ButtonColorB = Color.White;
            numQuantity.ButtonColorC = Color.White;
            numQuantity.Font = new Font("Segoe UI", 10F);
            numQuantity.ForeColor = Color.Silver;
            numQuantity.Location = new Point(208, 320);
            numQuantity.Maximum = 100L;
            numQuantity.Minimum = 0L;
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(142, 30);
            numQuantity.TabIndex = 50;
            numQuantity.Text = "foreverNumeric2";
            numQuantity.Value = 0L;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.BackColor = Color.Transparent;
            btnUpdateStock.DialogResult = DialogResult.None;
            btnUpdateStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStock.ForeColor = Color.DarkRed;
            btnUpdateStock.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnUpdateStock.HoverForeColor = Color.White;
            btnUpdateStock.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnUpdateStock.Location = new Point(434, 320);
            btnUpdateStock.MinimumSize = new Size(144, 47);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.NormalBackColor = Color.DarkRed;
            btnUpdateStock.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateStock.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateStock.PressedForeColor = Color.White;
            btnUpdateStock.Radius = 20;
            btnUpdateStock.Size = new Size(166, 47);
            btnUpdateStock.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateStock.TabIndex = 51;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.Click += btnUpdateStock_Click_1;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(13, 115);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(87, 23);
            dungeonHeaderLabel2.TabIndex = 52;
            dungeonHeaderLabel2.Text = "Customer";
            // 
            // cbCustomerId
            // 
            cbCustomerId.BackColor = Color.Maroon;
            cbCustomerId.BaseColor = Color.Firebrick;
            cbCustomerId.BGColor = Color.Maroon;
            cbCustomerId.DrawMode = DrawMode.OwnerDrawFixed;
            cbCustomerId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerId.Font = new Font("Segoe UI", 8F);
            cbCustomerId.ForeColor = Color.White;
            cbCustomerId.FormattingEnabled = true;
            cbCustomerId.HoverColor = Color.Red;
            cbCustomerId.HoverFontColor = Color.White;
            cbCustomerId.ItemHeight = 18;
            cbCustomerId.Location = new Point(206, 116);
            cbCustomerId.Name = "cbCustomerId";
            cbCustomerId.Size = new Size(144, 24);
            cbCustomerId.TabIndex = 53;
            // 
            // UC_ReleasePerm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(cbCustomerId);
            Controls.Add(dungeonHeaderLabel2);
            Controls.Add(btnUpdateStock);
            Controls.Add(numQuantity);
            Controls.Add(cbProductId);
            Controls.Add(cbCategory);
            Controls.Add(dungeonHeaderLabel8);
            Controls.Add(dungeonHeaderLabel5);
            Controls.Add(dungeonHeaderLabel4);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddRlsPerm);
            Controls.Add(cbWhId);
            Controls.Add(dtRlsDate);
            Controls.Add(dungeonHeaderLabel7);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(dgvRelsPerm);
            Name = "UC_ReleasePerm";
            Size = new Size(994, 383);
            ((System.ComponentModel.ISupportInitialize)dgvRelsPerm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvRelsPerm;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel7;
        private ReaLTaiizor.Controls.PoisonDateTime dtRlsDate;
        private ReaLTaiizor.Controls.ForeverComboBox cbWhId;
        private ReaLTaiizor.Controls.NightButton btnAddRlsPerm;
        private ReaLTaiizor.Controls.NightButton btnUpdate;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel5;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel8;
        private ReaLTaiizor.Controls.ForeverComboBox cbCategory;
        private ReaLTaiizor.Controls.ForeverComboBox cbProductId;
        private ReaLTaiizor.Controls.ForeverNumeric numQuantity;
        private ReaLTaiizor.Controls.NightButton btnUpdateStock;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.ForeverComboBox cbCustomerId;
    }
}

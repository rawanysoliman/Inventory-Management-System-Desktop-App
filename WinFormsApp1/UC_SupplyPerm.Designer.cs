namespace WinFormsApp1
{
    partial class UC_SupplyPerm
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
            cbWhId = new ReaLTaiizor.Controls.ForeverComboBox();
            dgvSplyPerm = new ReaLTaiizor.Controls.PoisonDataGridView();
            cbSupplierId = new ReaLTaiizor.Controls.ForeverComboBox();
            dtSplyDate = new ReaLTaiizor.Controls.PoisonDateTime();
            btnAddSplyPerm = new ReaLTaiizor.Controls.NightButton();
            btnUpdate = new ReaLTaiizor.Controls.NightButton();
            txtExpDuration = new ReaLTaiizor.Controls.SmallTextBox();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel5 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel6 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel7 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dtProDate = new ReaLTaiizor.Controls.PoisonDateTime();
            cbProductId = new ReaLTaiizor.Controls.ForeverComboBox();
            dungeonHeaderLabel8 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            numQuantity = new ReaLTaiizor.Controls.ForeverNumeric();
            btnUpdateStock = new ReaLTaiizor.Controls.NightButton();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbCategory = new ReaLTaiizor.Controls.ForeverComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSplyPerm).BeginInit();
            SuspendLayout();
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
            cbWhId.Location = new Point(185, 50);
            cbWhId.Name = "cbWhId";
            cbWhId.Size = new Size(144, 24);
            cbWhId.TabIndex = 14;
            // 
            // dgvSplyPerm
            // 
            dgvSplyPerm.AllowUserToResizeRows = false;
            dgvSplyPerm.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvSplyPerm.BorderStyle = BorderStyle.Fixed3D;
            dgvSplyPerm.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSplyPerm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSplyPerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSplyPerm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSplyPerm.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSplyPerm.EnableHeadersVisualStyles = false;
            dgvSplyPerm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvSplyPerm.GridColor = Color.FromArgb(255, 255, 255);
            dgvSplyPerm.Location = new Point(387, 13);
            dgvSplyPerm.Name = "dgvSplyPerm";
            dgvSplyPerm.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSplyPerm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSplyPerm.RowHeadersWidth = 51;
            dgvSplyPerm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvSplyPerm.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSplyPerm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSplyPerm.Size = new Size(586, 294);
            dgvSplyPerm.TabIndex = 15;
            dgvSplyPerm.SelectionChanged += dgvSplyPerm_SelectionChanged_1;
            // 
            // cbSupplierId
            // 
            cbSupplierId.BackColor = Color.Maroon;
            cbSupplierId.BaseColor = Color.Firebrick;
            cbSupplierId.BGColor = Color.Maroon;
            cbSupplierId.DrawMode = DrawMode.OwnerDrawFixed;
            cbSupplierId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplierId.Font = new Font("Segoe UI", 8F);
            cbSupplierId.ForeColor = Color.White;
            cbSupplierId.FormattingEnabled = true;
            cbSupplierId.HoverColor = Color.Red;
            cbSupplierId.HoverFontColor = Color.White;
            cbSupplierId.ItemHeight = 18;
            cbSupplierId.Location = new Point(185, 81);
            cbSupplierId.Name = "cbSupplierId";
            cbSupplierId.Size = new Size(144, 24);
            cbSupplierId.TabIndex = 16;
            // 
            // dtSplyDate
            // 
            dtSplyDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtSplyDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtSplyDate.Location = new Point(187, 13);
            dtSplyDate.MinimumSize = new Size(0, 30);
            dtSplyDate.Name = "dtSplyDate";
            dtSplyDate.Size = new Size(142, 30);
            dtSplyDate.TabIndex = 20;
            dtSplyDate.UseStyleColors = true;
            // 
            // btnAddSplyPerm
            // 
            btnAddSplyPerm.BackColor = Color.Transparent;
            btnAddSplyPerm.DialogResult = DialogResult.None;
            btnAddSplyPerm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSplyPerm.ForeColor = Color.DarkRed;
            btnAddSplyPerm.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAddSplyPerm.HoverForeColor = Color.White;
            btnAddSplyPerm.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAddSplyPerm.Location = new Point(13, 113);
            btnAddSplyPerm.MinimumSize = new Size(144, 47);
            btnAddSplyPerm.Name = "btnAddSplyPerm";
            btnAddSplyPerm.NormalBackColor = Color.DarkRed;
            btnAddSplyPerm.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddSplyPerm.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddSplyPerm.PressedForeColor = Color.White;
            btnAddSplyPerm.Radius = 20;
            btnAddSplyPerm.Size = new Size(144, 47);
            btnAddSplyPerm.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddSplyPerm.TabIndex = 21;
            btnAddSplyPerm.Text = "Add ";
            btnAddSplyPerm.Click += btnAddSplyPerm_Click;
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
            btnUpdate.Location = new Point(185, 115);
            btnUpdate.MinimumSize = new Size(144, 47);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NormalBackColor = Color.DarkRed;
            btnUpdate.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdate.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdate.PressedForeColor = Color.White;
            btnUpdate.Radius = 20;
            btnUpdate.Size = new Size(144, 47);
            btnUpdate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update ";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtExpDuration
            // 
            txtExpDuration.BackColor = Color.Transparent;
            txtExpDuration.BorderColor = Color.FromArgb(180, 180, 180);
            txtExpDuration.CustomBGColor = Color.White;
            txtExpDuration.Font = new Font("Tahoma", 11F);
            txtExpDuration.ForeColor = Color.DarkGray;
            txtExpDuration.Location = new Point(187, 329);
            txtExpDuration.MaxLength = 32767;
            txtExpDuration.Multiline = false;
            txtExpDuration.Name = "txtExpDuration";
            txtExpDuration.ReadOnly = false;
            txtExpDuration.Size = new Size(142, 33);
            txtExpDuration.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtExpDuration.TabIndex = 28;
            txtExpDuration.Text = "in days";
            txtExpDuration.TextAlignment = HorizontalAlignment.Left;
            txtExpDuration.UseSystemPasswordChar = false;
            txtExpDuration.Enter += txtExpDuration_Enter;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(13, 16);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(138, 23);
            dungeonHeaderLabel1.TabIndex = 29;
            dungeonHeaderLabel1.Text = "Permission Date";
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(13, 335);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(136, 23);
            dungeonHeaderLabel2.TabIndex = 30;
            dungeonHeaderLabel2.Text = "Expire Duration";
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel3.Location = new Point(13, 298);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(141, 23);
            dungeonHeaderLabel3.TabIndex = 31;
            dungeonHeaderLabel3.Text = "Production Date";
            // 
            // dungeonHeaderLabel5
            // 
            dungeonHeaderLabel5.AutoSize = true;
            dungeonHeaderLabel5.BackColor = Color.Transparent;
            dungeonHeaderLabel5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel5.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel5.Location = new Point(13, 227);
            dungeonHeaderLabel5.Name = "dungeonHeaderLabel5";
            dungeonHeaderLabel5.Size = new Size(78, 23);
            dungeonHeaderLabel5.TabIndex = 33;
            dungeonHeaderLabel5.Text = "Product ";
            // 
            // dungeonHeaderLabel6
            // 
            dungeonHeaderLabel6.AutoSize = true;
            dungeonHeaderLabel6.BackColor = Color.Transparent;
            dungeonHeaderLabel6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel6.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel6.Location = new Point(13, 74);
            dungeonHeaderLabel6.Name = "dungeonHeaderLabel6";
            dungeonHeaderLabel6.Size = new Size(83, 23);
            dungeonHeaderLabel6.TabIndex = 34;
            dungeonHeaderLabel6.Text = "Supplier ";
            // 
            // dungeonHeaderLabel7
            // 
            dungeonHeaderLabel7.AutoSize = true;
            dungeonHeaderLabel7.BackColor = Color.Transparent;
            dungeonHeaderLabel7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel7.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel7.Location = new Point(13, 45);
            dungeonHeaderLabel7.Name = "dungeonHeaderLabel7";
            dungeonHeaderLabel7.Size = new Size(108, 23);
            dungeonHeaderLabel7.TabIndex = 35;
            dungeonHeaderLabel7.Text = "Warwhouse ";
            // 
            // dtProDate
            // 
            dtProDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtProDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtProDate.Location = new Point(187, 291);
            dtProDate.MinimumSize = new Size(0, 30);
            dtProDate.Name = "dtProDate";
            dtProDate.Size = new Size(142, 30);
            dtProDate.TabIndex = 37;
            dtProDate.UseStyleColors = true;
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
            cbProductId.Location = new Point(187, 221);
            cbProductId.Name = "cbProductId";
            cbProductId.Size = new Size(142, 24);
            cbProductId.TabIndex = 38;
            // 
            // dungeonHeaderLabel8
            // 
            dungeonHeaderLabel8.AutoSize = true;
            dungeonHeaderLabel8.BackColor = Color.Transparent;
            dungeonHeaderLabel8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel8.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel8.Location = new Point(11, 262);
            dungeonHeaderLabel8.Name = "dungeonHeaderLabel8";
            dungeonHeaderLabel8.Size = new Size(80, 23);
            dungeonHeaderLabel8.TabIndex = 40;
            dungeonHeaderLabel8.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.BaseColor = Color.Maroon;
            numQuantity.ButtonColorA = Color.IndianRed;
            numQuantity.ButtonColorB = Color.White;
            numQuantity.ButtonColorC = Color.White;
            numQuantity.Font = new Font("Segoe UI", 10F);
            numQuantity.ForeColor = Color.Silver;
            numQuantity.Location = new Point(187, 254);
            numQuantity.Maximum = 100L;
            numQuantity.Minimum = 0L;
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(142, 30);
            numQuantity.TabIndex = 41;
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
            btnUpdateStock.Location = new Point(387, 315);
            btnUpdateStock.MinimumSize = new Size(144, 47);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.NormalBackColor = Color.DarkRed;
            btnUpdateStock.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateStock.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateStock.PressedForeColor = Color.White;
            btnUpdateStock.Radius = 20;
            btnUpdateStock.Size = new Size(166, 47);
            btnUpdateStock.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateStock.TabIndex = 43;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.Click += btnUpdateStock_Click_1;
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel4.Location = new Point(10, 187);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(146, 23);
            dungeonHeaderLabel4.TabIndex = 44;
            dungeonHeaderLabel4.Text = "Choose Category";
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
            cbCategory.Location = new Point(187, 185);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(142, 24);
            cbCategory.TabIndex = 45;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // UC_SupplyPerm
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(cbCategory);
            Controls.Add(dungeonHeaderLabel4);
            Controls.Add(btnUpdateStock);
            Controls.Add(numQuantity);
            Controls.Add(dungeonHeaderLabel8);
            Controls.Add(cbProductId);
            Controls.Add(dtProDate);
            Controls.Add(dungeonHeaderLabel7);
            Controls.Add(dungeonHeaderLabel6);
            Controls.Add(dungeonHeaderLabel5);
            Controls.Add(dungeonHeaderLabel3);
            Controls.Add(dungeonHeaderLabel2);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(txtExpDuration);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddSplyPerm);
            Controls.Add(dtSplyDate);
            Controls.Add(cbSupplierId);
            Controls.Add(dgvSplyPerm);
            Controls.Add(cbWhId);
            Name = "UC_SupplyPerm";
            Size = new Size(994, 383);
            ((System.ComponentModel.ISupportInitialize)dgvSplyPerm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.ForeverComboBox cbWhId;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvSplyPerm;
        private ReaLTaiizor.Controls.ForeverComboBox cbSupplierId;
        private ReaLTaiizor.Controls.PoisonDateTime dtSplyDate;
        private ReaLTaiizor.Controls.NightButton btnAddSplyPerm;
        private ReaLTaiizor.Controls.NightButton btnUpdate;
        private ReaLTaiizor.Controls.SmallTextBox txtExpDuration;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel5;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel6;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel7;
        private ReaLTaiizor.Controls.PoisonDateTime dtProDate;
        private ReaLTaiizor.Controls.ForeverComboBox cbProductId;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel8;
        private ReaLTaiizor.Controls.ForeverNumeric numQuantity;
        private ReaLTaiizor.Controls.NightButton btnUpdateStock;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.ForeverComboBox cbCategory;
    }
}

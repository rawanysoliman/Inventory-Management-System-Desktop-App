namespace WinFormsApp1
{
    partial class UC_TransferPerm
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
            dgvTransferPerm = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnUpdateStock = new ReaLTaiizor.Controls.NightButton();
            dungeonHeaderLabel7 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbFromWhId = new ReaLTaiizor.Controls.ForeverComboBox();
            cbToWhId = new ReaLTaiizor.Controls.ForeverComboBox();
            btnAddTransferPerm = new ReaLTaiizor.Controls.NightButton();
            dungeonHeaderLabel8 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            numQuantity = new ReaLTaiizor.Controls.ForeverNumeric();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dtTransferDate = new ReaLTaiizor.Controls.PoisonDateTime();
            dungeonHeaderLabel5 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbProductId = new ReaLTaiizor.Controls.ForeverComboBox();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbCategory = new ReaLTaiizor.Controls.ForeverComboBox();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel6 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dtProdDate = new ReaLTaiizor.Controls.PoisonDateTime();
            dbExpDate = new ReaLTaiizor.Controls.PoisonDateTime();
            dungeonHeaderLabel9 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cbSupplierId = new ReaLTaiizor.Controls.ForeverComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransferPerm).BeginInit();
            SuspendLayout();
            // 
            // dgvTransferPerm
            // 
            dgvTransferPerm.AllowUserToResizeRows = false;
            dgvTransferPerm.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvTransferPerm.BorderStyle = BorderStyle.Fixed3D;
            dgvTransferPerm.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTransferPerm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransferPerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransferPerm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransferPerm.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransferPerm.EnableHeadersVisualStyles = false;
            dgvTransferPerm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTransferPerm.GridColor = Color.FromArgb(255, 255, 255);
            dgvTransferPerm.Location = new Point(398, 12);
            dgvTransferPerm.Name = "dgvTransferPerm";
            dgvTransferPerm.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTransferPerm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTransferPerm.RowHeadersWidth = 51;
            dgvTransferPerm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvTransferPerm.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTransferPerm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransferPerm.Size = new Size(554, 294);
            dgvTransferPerm.TabIndex = 16;
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
            btnUpdateStock.Location = new Point(398, 312);
            btnUpdateStock.MinimumSize = new Size(144, 47);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.NormalBackColor = Color.DarkRed;
            btnUpdateStock.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateStock.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateStock.PressedForeColor = Color.White;
            btnUpdateStock.Radius = 20;
            btnUpdateStock.Size = new Size(166, 47);
            btnUpdateStock.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateStock.TabIndex = 44;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // dungeonHeaderLabel7
            // 
            dungeonHeaderLabel7.AutoSize = true;
            dungeonHeaderLabel7.BackColor = Color.Transparent;
            dungeonHeaderLabel7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel7.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel7.Location = new Point(15, 12);
            dungeonHeaderLabel7.Name = "dungeonHeaderLabel7";
            dungeonHeaderLabel7.Size = new Size(155, 23);
            dungeonHeaderLabel7.TabIndex = 45;
            dungeonHeaderLabel7.Text = "From Warwhouse ";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(15, 45);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(131, 23);
            dungeonHeaderLabel1.TabIndex = 46;
            dungeonHeaderLabel1.Text = "To Warwhouse ";
            // 
            // cbFromWhId
            // 
            cbFromWhId.BackColor = Color.Maroon;
            cbFromWhId.BaseColor = Color.Firebrick;
            cbFromWhId.BGColor = Color.Maroon;
            cbFromWhId.DrawMode = DrawMode.OwnerDrawFixed;
            cbFromWhId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFromWhId.Font = new Font("Segoe UI", 8F);
            cbFromWhId.ForeColor = Color.White;
            cbFromWhId.FormattingEnabled = true;
            cbFromWhId.HoverColor = Color.Red;
            cbFromWhId.HoverFontColor = Color.White;
            cbFromWhId.ItemHeight = 18;
            cbFromWhId.Location = new Point(176, 13);
            cbFromWhId.Name = "cbFromWhId";
            cbFromWhId.Size = new Size(144, 24);
            cbFromWhId.TabIndex = 47;
            // 
            // cbToWhId
            // 
            cbToWhId.BackColor = Color.Maroon;
            cbToWhId.BaseColor = Color.Firebrick;
            cbToWhId.BGColor = Color.Maroon;
            cbToWhId.DrawMode = DrawMode.OwnerDrawFixed;
            cbToWhId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbToWhId.Font = new Font("Segoe UI", 8F);
            cbToWhId.ForeColor = Color.White;
            cbToWhId.FormattingEnabled = true;
            cbToWhId.HoverColor = Color.Red;
            cbToWhId.HoverFontColor = Color.White;
            cbToWhId.ItemHeight = 18;
            cbToWhId.Location = new Point(176, 46);
            cbToWhId.Name = "cbToWhId";
            cbToWhId.Size = new Size(144, 24);
            cbToWhId.TabIndex = 48;
            // 
            // btnAddTransferPerm
            // 
            btnAddTransferPerm.BackColor = Color.Transparent;
            btnAddTransferPerm.DialogResult = DialogResult.None;
            btnAddTransferPerm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTransferPerm.ForeColor = Color.DarkRed;
            btnAddTransferPerm.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAddTransferPerm.HoverForeColor = Color.White;
            btnAddTransferPerm.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAddTransferPerm.Location = new Point(15, 145);
            btnAddTransferPerm.MinimumSize = new Size(144, 47);
            btnAddTransferPerm.Name = "btnAddTransferPerm";
            btnAddTransferPerm.NormalBackColor = Color.DarkRed;
            btnAddTransferPerm.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddTransferPerm.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddTransferPerm.PressedForeColor = Color.White;
            btnAddTransferPerm.Radius = 20;
            btnAddTransferPerm.Size = new Size(144, 47);
            btnAddTransferPerm.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddTransferPerm.TabIndex = 49;
            btnAddTransferPerm.Text = "Add ";
            btnAddTransferPerm.Click += btnAddTransferPerm_Click;
            // 
            // dungeonHeaderLabel8
            // 
            dungeonHeaderLabel8.AutoSize = true;
            dungeonHeaderLabel8.BackColor = Color.Transparent;
            dungeonHeaderLabel8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel8.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel8.Location = new Point(15, 266);
            dungeonHeaderLabel8.Name = "dungeonHeaderLabel8";
            dungeonHeaderLabel8.Size = new Size(80, 23);
            dungeonHeaderLabel8.TabIndex = 50;
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
            numQuantity.Location = new Point(175, 259);
            numQuantity.Maximum = 100L;
            numQuantity.Minimum = 0L;
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(142, 30);
            numQuantity.TabIndex = 51;
            numQuantity.Text = "foreverNumeric2";
            numQuantity.Value = 0L;
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel3.Location = new Point(17, 112);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(118, 23);
            dungeonHeaderLabel3.TabIndex = 52;
            dungeonHeaderLabel3.Text = "Transfer Date";
            // 
            // dtTransferDate
            // 
            dtTransferDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtTransferDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtTransferDate.Location = new Point(176, 110);
            dtTransferDate.MinimumSize = new Size(0, 30);
            dtTransferDate.Name = "dtTransferDate";
            dtTransferDate.Size = new Size(142, 30);
            dtTransferDate.TabIndex = 53;
            dtTransferDate.UseStyleColors = true;
            // 
            // dungeonHeaderLabel5
            // 
            dungeonHeaderLabel5.AutoSize = true;
            dungeonHeaderLabel5.BackColor = Color.Transparent;
            dungeonHeaderLabel5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel5.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel5.Location = new Point(20, 227);
            dungeonHeaderLabel5.Name = "dungeonHeaderLabel5";
            dungeonHeaderLabel5.Size = new Size(78, 23);
            dungeonHeaderLabel5.TabIndex = 54;
            dungeonHeaderLabel5.Text = "Product ";
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
            cbProductId.Location = new Point(175, 226);
            cbProductId.Name = "cbProductId";
            cbProductId.Size = new Size(142, 24);
            cbProductId.TabIndex = 55;
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel4.Location = new Point(15, 195);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(146, 23);
            dungeonHeaderLabel4.TabIndex = 56;
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
            cbCategory.Location = new Point(176, 196);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(142, 24);
            cbCategory.TabIndex = 57;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(15, 300);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(141, 23);
            dungeonHeaderLabel2.TabIndex = 58;
            dungeonHeaderLabel2.Text = "Production Date";
            // 
            // dungeonHeaderLabel6
            // 
            dungeonHeaderLabel6.AutoSize = true;
            dungeonHeaderLabel6.BackColor = Color.Transparent;
            dungeonHeaderLabel6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel6.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel6.Location = new Point(15, 336);
            dungeonHeaderLabel6.Name = "dungeonHeaderLabel6";
            dungeonHeaderLabel6.Size = new Size(103, 23);
            dungeonHeaderLabel6.TabIndex = 59;
            dungeonHeaderLabel6.Text = "Expire Date";
            // 
            // dtProdDate
            // 
            dtProdDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtProdDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dtProdDate.Location = new Point(175, 295);
            dtProdDate.MinimumSize = new Size(0, 30);
            dtProdDate.Name = "dtProdDate";
            dtProdDate.Size = new Size(142, 30);
            dtProdDate.TabIndex = 60;
            dtProdDate.UseStyleColors = true;
            // 
            // dbExpDate
            // 
            dbExpDate.CalendarMonthBackground = Color.WhiteSmoke;
            dbExpDate.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dbExpDate.Location = new Point(176, 331);
            dbExpDate.MinimumSize = new Size(0, 30);
            dbExpDate.Name = "dbExpDate";
            dbExpDate.Size = new Size(142, 30);
            dbExpDate.TabIndex = 61;
            dbExpDate.UseStyleColors = true;
            // 
            // dungeonHeaderLabel9
            // 
            dungeonHeaderLabel9.AutoSize = true;
            dungeonHeaderLabel9.BackColor = Color.Transparent;
            dungeonHeaderLabel9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel9.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel9.Location = new Point(15, 72);
            dungeonHeaderLabel9.Name = "dungeonHeaderLabel9";
            dungeonHeaderLabel9.Size = new Size(83, 23);
            dungeonHeaderLabel9.TabIndex = 62;
            dungeonHeaderLabel9.Text = "Supplier ";
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
            cbSupplierId.Location = new Point(176, 76);
            cbSupplierId.Name = "cbSupplierId";
            cbSupplierId.Size = new Size(144, 24);
            cbSupplierId.TabIndex = 63;
            // 
            // UC_TransferPerm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(cbSupplierId);
            Controls.Add(dungeonHeaderLabel9);
            Controls.Add(dbExpDate);
            Controls.Add(dtProdDate);
            Controls.Add(dungeonHeaderLabel6);
            Controls.Add(dungeonHeaderLabel2);
            Controls.Add(cbCategory);
            Controls.Add(dungeonHeaderLabel4);
            Controls.Add(cbProductId);
            Controls.Add(dungeonHeaderLabel5);
            Controls.Add(dtTransferDate);
            Controls.Add(dungeonHeaderLabel3);
            Controls.Add(numQuantity);
            Controls.Add(dungeonHeaderLabel8);
            Controls.Add(btnAddTransferPerm);
            Controls.Add(cbToWhId);
            Controls.Add(cbFromWhId);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(dungeonHeaderLabel7);
            Controls.Add(btnUpdateStock);
            Controls.Add(dgvTransferPerm);
            Name = "UC_TransferPerm";
            Size = new Size(994, 371);
            ((System.ComponentModel.ISupportInitialize)dgvTransferPerm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvTransferPerm;
        private ReaLTaiizor.Controls.NightButton btnUpdateStock;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel7;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.ForeverComboBox cbFromWhId;
        private ReaLTaiizor.Controls.ForeverComboBox cbToWhId;
        private ReaLTaiizor.Controls.NightButton btnAddTransferPerm;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel8;
        private ReaLTaiizor.Controls.ForeverNumeric numQuantity;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.PoisonDateTime dtTransferDate;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel5;
        private ReaLTaiizor.Controls.ForeverComboBox cbProductId;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.ForeverComboBox cbCategory;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel6;
        private ReaLTaiizor.Controls.PoisonDateTime dtProdDate;
        private ReaLTaiizor.Controls.PoisonDateTime dbExpDate;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel9;
        private ReaLTaiizor.Controls.ForeverComboBox cbSupplierId;
    }
}

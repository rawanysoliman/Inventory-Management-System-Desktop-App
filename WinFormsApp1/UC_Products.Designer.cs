namespace WinFormsApp1
{
    partial class UC_Products
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvProducts = new ReaLTaiizor.Controls.PoisonDataGridView();
            txPrdctName = new ReaLTaiizor.Controls.SmallTextBox();
            txPrice = new ReaLTaiizor.Controls.SmallTextBox();
            btnAddWh = new ReaLTaiizor.Controls.NightButton();
            btnUpdateWh = new ReaLTaiizor.Controls.NightButton();
            btnDltWh = new ReaLTaiizor.Controls.NightButton();
            cbCategory = new ReaLTaiizor.Controls.ForeverComboBox();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvProducts.BorderStyle = BorderStyle.Fixed3D;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DimGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Maroon;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvProducts.GridColor = Color.FromArgb(255, 255, 255);
            dgvProducts.Location = new Point(409, 18);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DimGray;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.LightGray;
            dataGridViewCellStyle8.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(547, 290);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txPrdctName
            // 
            txPrdctName.BackColor = Color.Transparent;
            txPrdctName.BorderColor = Color.FromArgb(180, 180, 180);
            txPrdctName.CustomBGColor = Color.White;
            txPrdctName.Font = new Font("Tahoma", 11F);
            txPrdctName.ForeColor = Color.DarkGray;
            txPrdctName.Location = new Point(25, 100);
            txPrdctName.MaxLength = 32767;
            txPrdctName.Multiline = false;
            txPrdctName.Name = "txPrdctName";
            txPrdctName.ReadOnly = false;
            txPrdctName.Size = new Size(138, 33);
            txPrdctName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txPrdctName.TabIndex = 17;
            txPrdctName.Text = "Name";
            txPrdctName.TextAlignment = HorizontalAlignment.Left;
            txPrdctName.UseSystemPasswordChar = false;
            txPrdctName.Enter += txPrdctName_Enter;
            // 
            // txPrice
            // 
            txPrice.BackColor = Color.Transparent;
            txPrice.BorderColor = Color.FromArgb(180, 180, 180);
            txPrice.CustomBGColor = Color.White;
            txPrice.Font = new Font("Tahoma", 11F);
            txPrice.ForeColor = Color.DarkGray;
            txPrice.Location = new Point(25, 168);
            txPrice.MaxLength = 32767;
            txPrice.Multiline = false;
            txPrice.Name = "txPrice";
            txPrice.ReadOnly = false;
            txPrice.Size = new Size(138, 33);
            txPrice.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txPrice.TabIndex = 18;
            txPrice.Text = "Price";
            txPrice.TextAlignment = HorizontalAlignment.Left;
            txPrice.UseSystemPasswordChar = false;
            txPrice.Enter += txPrice_Enter;
            // 
            // btnAddWh
            // 
            btnAddWh.BackColor = Color.Transparent;
            btnAddWh.DialogResult = DialogResult.None;
            btnAddWh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWh.ForeColor = Color.DarkRed;
            btnAddWh.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAddWh.HoverForeColor = Color.White;
            btnAddWh.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAddWh.Location = new Point(230, 77);
            btnAddWh.MinimumSize = new Size(144, 47);
            btnAddWh.Name = "btnAddWh";
            btnAddWh.NormalBackColor = Color.DarkRed;
            btnAddWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddWh.PressedForeColor = Color.White;
            btnAddWh.Radius = 20;
            btnAddWh.Size = new Size(144, 47);
            btnAddWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddWh.TabIndex = 19;
            btnAddWh.Text = "Add";
            btnAddWh.Click += btnAddWh_Click;
            // 
            // btnUpdateWh
            // 
            btnUpdateWh.BackColor = Color.Transparent;
            btnUpdateWh.DialogResult = DialogResult.None;
            btnUpdateWh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateWh.ForeColor = Color.DarkRed;
            btnUpdateWh.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnUpdateWh.HoverForeColor = Color.White;
            btnUpdateWh.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnUpdateWh.Location = new Point(230, 168);
            btnUpdateWh.MinimumSize = new Size(144, 47);
            btnUpdateWh.Name = "btnUpdateWh";
            btnUpdateWh.NormalBackColor = Color.DarkRed;
            btnUpdateWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateWh.PressedForeColor = Color.White;
            btnUpdateWh.Radius = 20;
            btnUpdateWh.Size = new Size(144, 47);
            btnUpdateWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateWh.TabIndex = 20;
            btnUpdateWh.Text = "Update";
            btnUpdateWh.Click += btnUpdatePrdct_Click;
            // 
            // btnDltWh
            // 
            btnDltWh.BackColor = Color.Transparent;
            btnDltWh.DialogResult = DialogResult.None;
            btnDltWh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDltWh.ForeColor = Color.Maroon;
            btnDltWh.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnDltWh.HoverForeColor = Color.White;
            btnDltWh.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnDltWh.Location = new Point(230, 253);
            btnDltWh.MinimumSize = new Size(144, 47);
            btnDltWh.Name = "btnDltWh";
            btnDltWh.NormalBackColor = Color.DarkRed;
            btnDltWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnDltWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnDltWh.PressedForeColor = Color.White;
            btnDltWh.Radius = 20;
            btnDltWh.Size = new Size(144, 47);
            btnDltWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnDltWh.TabIndex = 21;
            btnDltWh.Text = "Delete";
            btnDltWh.Click += btnDltPrdct_Click;
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
            cbCategory.Location = new Point(21, 253);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(142, 24);
            cbCategory.TabIndex = 58;
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonHeaderLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel4.Location = new Point(17, 218);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(146, 23);
            dungeonHeaderLabel4.TabIndex = 59;
            dungeonHeaderLabel4.Text = "Choose Category";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft YaHei UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DarkRed;
            bigLabel1.Location = new Point(3, 15);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(260, 56);
            bigLabel1.TabIndex = 60;
            bigLabel1.Text = "PRODUCTS";
            // 
            // UC_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(bigLabel1);
            Controls.Add(dungeonHeaderLabel4);
            Controls.Add(cbCategory);
            Controls.Add(btnDltWh);
            Controls.Add(btnUpdateWh);
            Controls.Add(btnAddWh);
            Controls.Add(txPrice);
            Controls.Add(txPrdctName);
            Controls.Add(dgvProducts);
            Name = "UC_Products";
            Size = new Size(994, 371);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvProducts;
        private ReaLTaiizor.Controls.SmallTextBox txPrdctName;
        private ReaLTaiizor.Controls.SmallTextBox txPrice;
        private ReaLTaiizor.Controls.NightButton btnAddWh;
        private ReaLTaiizor.Controls.NightButton btnUpdateWh;
        private ReaLTaiizor.Controls.NightButton btnDltWh;
        private ReaLTaiizor.Controls.ForeverComboBox cbCategory;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}

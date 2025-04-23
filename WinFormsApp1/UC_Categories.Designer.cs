namespace WinFormsApp1
{
    partial class UC_Categories
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
            dgvCategories = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnUpdateCat = new ReaLTaiizor.Controls.NightButton();
            btnAddCat = new ReaLTaiizor.Controls.NightButton();
            btnDltCat = new ReaLTaiizor.Controls.NightButton();
            txtCatName = new ReaLTaiizor.Controls.SmallTextBox();
            txtDescrp = new ReaLTaiizor.Controls.HopeRichTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToResizeRows = false;
            dgvCategories.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvCategories.BorderStyle = BorderStyle.Fixed3D;
            dgvCategories.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvCategories.GridColor = Color.FromArgb(255, 255, 255);
            dgvCategories.Location = new Point(465, 30);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(497, 303);
            dgvCategories.TabIndex = 8;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // btnUpdateCat
            // 
            btnUpdateCat.BackColor = Color.Transparent;
            btnUpdateCat.DialogResult = DialogResult.None;
            btnUpdateCat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCat.ForeColor = Color.DarkRed;
            btnUpdateCat.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnUpdateCat.HoverForeColor = Color.White;
            btnUpdateCat.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnUpdateCat.Location = new Point(291, 151);
            btnUpdateCat.MinimumSize = new Size(144, 47);
            btnUpdateCat.Name = "btnUpdateCat";
            btnUpdateCat.NormalBackColor = Color.DarkRed;
            btnUpdateCat.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateCat.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateCat.PressedForeColor = Color.White;
            btnUpdateCat.Radius = 20;
            btnUpdateCat.Size = new Size(144, 47);
            btnUpdateCat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateCat.TabIndex = 10;
            btnUpdateCat.Text = "Update";
            btnUpdateCat.Click += btnUpdateWh_Click;
            // 
            // btnAddCat
            // 
            btnAddCat.BackColor = Color.Transparent;
            btnAddCat.DialogResult = DialogResult.None;
            btnAddCat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCat.ForeColor = Color.DarkRed;
            btnAddCat.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAddCat.HoverForeColor = Color.White;
            btnAddCat.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAddCat.Location = new Point(291, 71);
            btnAddCat.MinimumSize = new Size(144, 47);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.NormalBackColor = Color.DarkRed;
            btnAddCat.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddCat.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddCat.PressedForeColor = Color.White;
            btnAddCat.Radius = 20;
            btnAddCat.Size = new Size(144, 47);
            btnAddCat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddCat.TabIndex = 11;
            btnAddCat.Text = "Add";
            btnAddCat.Click += btnAddWh_Click;
            // 
            // btnDltCat
            // 
            btnDltCat.BackColor = Color.Transparent;
            btnDltCat.DialogResult = DialogResult.None;
            btnDltCat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDltCat.ForeColor = Color.Maroon;
            btnDltCat.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnDltCat.HoverForeColor = Color.White;
            btnDltCat.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnDltCat.Location = new Point(291, 240);
            btnDltCat.MinimumSize = new Size(144, 47);
            btnDltCat.Name = "btnDltCat";
            btnDltCat.NormalBackColor = Color.DarkRed;
            btnDltCat.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnDltCat.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnDltCat.PressedForeColor = Color.White;
            btnDltCat.Radius = 20;
            btnDltCat.Size = new Size(144, 47);
            btnDltCat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnDltCat.TabIndex = 12;
            btnDltCat.Text = "Delete";
            btnDltCat.Click += btnDltWh_Click;
            // 
            // txtCatName
            // 
            txtCatName.BackColor = Color.Transparent;
            txtCatName.BorderColor = Color.FromArgb(180, 180, 180);
            txtCatName.CustomBGColor = Color.White;
            txtCatName.Font = new Font("Tahoma", 11F);
            txtCatName.ForeColor = Color.DarkGray;
            txtCatName.Location = new Point(40, 85);
            txtCatName.MaxLength = 32767;
            txtCatName.Multiline = false;
            txtCatName.Name = "txtCatName";
            txtCatName.ReadOnly = false;
            txtCatName.Size = new Size(138, 33);
            txtCatName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtCatName.TabIndex = 16;
            txtCatName.Text = "Name";
            txtCatName.TextAlignment = HorizontalAlignment.Left;
            txtCatName.UseSystemPasswordChar = false;
            // 
            // txtDescrp
            // 
            txtDescrp.BorderColor = Color.FromArgb(220, 223, 230);
            txtDescrp.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescrp.ForeColor = Color.DarkRed;
            txtDescrp.Hint = "";
            txtDescrp.HoverBorderColor = Color.FromArgb(64, 158, 255);
            txtDescrp.Location = new Point(12, 151);
            txtDescrp.MaxLength = 32767;
            txtDescrp.Multiline = true;
            txtDescrp.Name = "txtDescrp";
            txtDescrp.PasswordChar = '\0';
            txtDescrp.ScrollBars = ScrollBars.None;
            txtDescrp.SelectedText = "";
            txtDescrp.SelectionLength = 0;
            txtDescrp.SelectionStart = 0;
            txtDescrp.Size = new Size(250, 182);
            txtDescrp.TabIndex = 17;
            txtDescrp.TabStop = false;
            txtDescrp.Text = "Category Description";
            txtDescrp.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft YaHei UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DarkRed;
            bigLabel1.Location = new Point(3, 12);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(292, 56);
            bigLabel1.TabIndex = 20;
            bigLabel1.Text = "CATEGORIES";
            // 
            // UC_Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(bigLabel1);
            Controls.Add(txtDescrp);
            Controls.Add(txtCatName);
            Controls.Add(btnDltCat);
            Controls.Add(btnAddCat);
            Controls.Add(btnUpdateCat);
            Controls.Add(dgvCategories);
            Name = "UC_Categories";
            Size = new Size(994, 379);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvCategories;
        private ReaLTaiizor.Controls.NightButton btnUpdateCat;
        private ReaLTaiizor.Controls.NightButton btnAddCat;
        private ReaLTaiizor.Controls.NightButton btnDltCat;
        private ReaLTaiizor.Controls.SmallTextBox txtCatName;
        private ReaLTaiizor.Controls.HopeRichTextBox txtDescrp;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}

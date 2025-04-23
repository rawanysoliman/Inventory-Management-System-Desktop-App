namespace WinFormsApp1
{
    partial class UC_Suppliers
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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            dgvSuppliers = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnUpdateSp = new ReaLTaiizor.Controls.NightButton();
            btnAddSp = new ReaLTaiizor.Controls.NightButton();
            btnDltSp = new ReaLTaiizor.Controls.NightButton();
            txtSpName = new ReaLTaiizor.Controls.SmallTextBox();
            txtSpLoc = new ReaLTaiizor.Controls.SmallTextBox();
            txtSpEmail = new ReaLTaiizor.Controls.SmallTextBox();
            txtSpPhone = new ReaLTaiizor.Controls.SmallTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtSpFax = new ReaLTaiizor.Controls.SmallTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToResizeRows = false;
            dgvSuppliers.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvSuppliers.BorderStyle = BorderStyle.Fixed3D;
            dgvSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSuppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.DimGray;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle17.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.Maroon;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = Color.Maroon;
            dataGridViewCellStyle18.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle18;
            dgvSuppliers.EnableHeadersVisualStyles = false;
            dgvSuppliers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvSuppliers.GridColor = Color.FromArgb(255, 255, 255);
            dgvSuppliers.Location = new Point(400, 29);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.DimGray;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle19.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle19.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = Color.LightGray;
            dataGridViewCellStyle20.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle20.SelectionForeColor = Color.Black;
            dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(571, 290);
            dgvSuppliers.TabIndex = 8;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // btnUpdateSp
            // 
            btnUpdateSp.BackColor = Color.Transparent;
            btnUpdateSp.DialogResult = DialogResult.None;
            btnUpdateSp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSp.ForeColor = Color.DarkRed;
            btnUpdateSp.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnUpdateSp.HoverForeColor = Color.White;
            btnUpdateSp.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnUpdateSp.Location = new Point(210, 189);
            btnUpdateSp.MinimumSize = new Size(144, 47);
            btnUpdateSp.Name = "btnUpdateSp";
            btnUpdateSp.NormalBackColor = Color.DarkRed;
            btnUpdateSp.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateSp.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateSp.PressedForeColor = Color.White;
            btnUpdateSp.Radius = 20;
            btnUpdateSp.Size = new Size(144, 47);
            btnUpdateSp.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateSp.TabIndex = 10;
            btnUpdateSp.Text = "Update";
            btnUpdateSp.Click += btnUpdateSp_Click;
            // 
            // btnAddSp
            // 
            btnAddSp.BackColor = Color.Transparent;
            btnAddSp.DialogResult = DialogResult.None;
            btnAddSp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSp.ForeColor = Color.DarkRed;
            btnAddSp.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAddSp.HoverForeColor = Color.White;
            btnAddSp.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAddSp.Location = new Point(210, 88);
            btnAddSp.MinimumSize = new Size(144, 47);
            btnAddSp.Name = "btnAddSp";
            btnAddSp.NormalBackColor = Color.DarkRed;
            btnAddSp.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddSp.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddSp.PressedForeColor = Color.White;
            btnAddSp.Radius = 20;
            btnAddSp.Size = new Size(144, 47);
            btnAddSp.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddSp.TabIndex = 11;
            btnAddSp.Text = "Add";
            btnAddSp.Click += btnAddSp_Click;
            // 
            // btnDltSp
            // 
            btnDltSp.BackColor = Color.Transparent;
            btnDltSp.DialogResult = DialogResult.None;
            btnDltSp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDltSp.ForeColor = Color.Maroon;
            btnDltSp.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnDltSp.HoverForeColor = Color.White;
            btnDltSp.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnDltSp.Location = new Point(210, 292);
            btnDltSp.MinimumSize = new Size(144, 47);
            btnDltSp.Name = "btnDltSp";
            btnDltSp.NormalBackColor = Color.DarkRed;
            btnDltSp.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnDltSp.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnDltSp.PressedForeColor = Color.White;
            btnDltSp.Radius = 20;
            btnDltSp.Size = new Size(144, 47);
            btnDltSp.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnDltSp.TabIndex = 12;
            btnDltSp.Text = "Delete";
            btnDltSp.Click += btnDltSp_Click;
            // 
            // txtSpName
            // 
            txtSpName.BackColor = Color.Transparent;
            txtSpName.BorderColor = Color.FromArgb(180, 180, 180);
            txtSpName.CustomBGColor = Color.White;
            txtSpName.Font = new Font("Tahoma", 11F);
            txtSpName.ForeColor = Color.DarkGray;
            txtSpName.Location = new Point(30, 102);
            txtSpName.MaxLength = 32767;
            txtSpName.Multiline = false;
            txtSpName.Name = "txtSpName";
            txtSpName.ReadOnly = false;
            txtSpName.Size = new Size(138, 33);
            txtSpName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtSpName.TabIndex = 16;
            txtSpName.Text = "Name";
            txtSpName.TextAlignment = HorizontalAlignment.Left;
            txtSpName.UseSystemPasswordChar = false;
            txtSpName.Enter += txtSpName_Enter;
            // 
            // txtSpLoc
            // 
            txtSpLoc.BackColor = Color.Transparent;
            txtSpLoc.BorderColor = Color.FromArgb(180, 180, 180);
            txtSpLoc.CustomBGColor = Color.White;
            txtSpLoc.Font = new Font("Tahoma", 11F);
            txtSpLoc.ForeColor = Color.DarkGray;
            txtSpLoc.Location = new Point(30, 158);
            txtSpLoc.MaxLength = 32767;
            txtSpLoc.Multiline = false;
            txtSpLoc.Name = "txtSpLoc";
            txtSpLoc.ReadOnly = false;
            txtSpLoc.Size = new Size(138, 33);
            txtSpLoc.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtSpLoc.TabIndex = 18;
            txtSpLoc.Tag = "";
            txtSpLoc.Text = "Location";
            txtSpLoc.TextAlignment = HorizontalAlignment.Left;
            txtSpLoc.UseSystemPasswordChar = false;
            txtSpLoc.Enter += txtSpLoc_Enter;
            // 
            // txtSpEmail
            // 
            txtSpEmail.BackColor = Color.Transparent;
            txtSpEmail.BorderColor = Color.FromArgb(180, 180, 180);
            txtSpEmail.CustomBGColor = Color.White;
            txtSpEmail.Font = new Font("Tahoma", 11F);
            txtSpEmail.ForeColor = Color.DarkGray;
            txtSpEmail.Location = new Point(30, 253);
            txtSpEmail.MaxLength = 32767;
            txtSpEmail.Multiline = false;
            txtSpEmail.Name = "txtSpEmail";
            txtSpEmail.ReadOnly = false;
            txtSpEmail.Size = new Size(138, 33);
            txtSpEmail.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtSpEmail.TabIndex = 20;
            txtSpEmail.Tag = "";
            txtSpEmail.Text = "Email";
            txtSpEmail.TextAlignment = HorizontalAlignment.Left;
            txtSpEmail.UseSystemPasswordChar = false;
            txtSpEmail.Enter += txtSpEmail_Enter;
            // 
            // txtSpPhone
            // 
            txtSpPhone.BackColor = Color.Transparent;
            txtSpPhone.BorderColor = Color.FromArgb(180, 180, 180);
            txtSpPhone.CustomBGColor = Color.White;
            txtSpPhone.Font = new Font("Tahoma", 11F);
            txtSpPhone.ForeColor = Color.DarkGray;
            txtSpPhone.Location = new Point(30, 203);
            txtSpPhone.MaxLength = 32767;
            txtSpPhone.Multiline = false;
            txtSpPhone.Name = "txtSpPhone";
            txtSpPhone.ReadOnly = false;
            txtSpPhone.Size = new Size(138, 33);
            txtSpPhone.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtSpPhone.TabIndex = 21;
            txtSpPhone.Tag = "";
            txtSpPhone.Text = "Phone";
            txtSpPhone.TextAlignment = HorizontalAlignment.Left;
            txtSpPhone.UseSystemPasswordChar = false;
            txtSpPhone.Enter += txtSpPhone_Enter;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft YaHei UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DarkRed;
            bigLabel1.Location = new Point(3, 13);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(253, 56);
            bigLabel1.TabIndex = 22;
            bigLabel1.Text = "SUPPLIERS";
            // 
            // txtSpFax
            // 
            txtSpFax.BackColor = Color.Transparent;
            txtSpFax.BorderColor = Color.FromArgb(180, 180, 180);
            txtSpFax.CustomBGColor = Color.White;
            txtSpFax.Font = new Font("Tahoma", 11F);
            txtSpFax.ForeColor = Color.DarkGray;
            txtSpFax.Location = new Point(30, 306);
            txtSpFax.MaxLength = 32767;
            txtSpFax.Multiline = false;
            txtSpFax.Name = "txtSpFax";
            txtSpFax.ReadOnly = false;
            txtSpFax.Size = new Size(138, 33);
            txtSpFax.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtSpFax.TabIndex = 23;
            txtSpFax.Tag = "";
            txtSpFax.Text = "Fax";
            txtSpFax.TextAlignment = HorizontalAlignment.Left;
            txtSpFax.UseSystemPasswordChar = false;
            txtSpFax.Enter += txtSpFax_Enter;
            // 
            // UC_Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(txtSpFax);
            Controls.Add(bigLabel1);
            Controls.Add(txtSpPhone);
            Controls.Add(txtSpEmail);
            Controls.Add(txtSpLoc);
            Controls.Add(txtSpName);
            Controls.Add(btnDltSp);
            Controls.Add(btnAddSp);
            Controls.Add(btnUpdateSp);
            Controls.Add(dgvSuppliers);
            Name = "UC_Suppliers";
            Size = new Size(994, 379);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvSuppliers;
        private ReaLTaiizor.Controls.NightButton btnUpdateSp;
        private ReaLTaiizor.Controls.NightButton btnAddSp;
        private ReaLTaiizor.Controls.NightButton btnDltSp;
        private ReaLTaiizor.Controls.SmallTextBox txtSpName;
        private ReaLTaiizor.Controls.SmallTextBox txtSpLoc;
        private ReaLTaiizor.Controls.SmallTextBox txtSpEmail;
        private ReaLTaiizor.Controls.SmallTextBox txtSpPhone;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.SmallTextBox txtSpFax;
    }
}

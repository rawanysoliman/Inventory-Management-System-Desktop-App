using InventoryManagementSystem.context;

namespace WinFormsApp1
{
    public partial class UcWarehouse: UserControl
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
            dgvWarehouse = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnAddWh = new ReaLTaiizor.Controls.NightButton();
            btnUpdateWh = new ReaLTaiizor.Controls.NightButton();
            btnDltWh = new ReaLTaiizor.Controls.NightButton();
            txtWhName = new ReaLTaiizor.Controls.SmallTextBox();
            txtWhLoc = new ReaLTaiizor.Controls.SmallTextBox();
            txtManger = new ReaLTaiizor.Controls.SmallTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouse).BeginInit();
            SuspendLayout();
            // 
            // dgvWarehouse
            // 
            dgvWarehouse.AllowUserToResizeRows = false;
            dgvWarehouse.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvWarehouse.BorderStyle = BorderStyle.Fixed3D;
            dgvWarehouse.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvWarehouse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWarehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWarehouse.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWarehouse.EnableHeadersVisualStyles = false;
            dgvWarehouse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvWarehouse.GridColor = Color.FromArgb(255, 255, 255);
            dgvWarehouse.Location = new Point(368, 45);
            dgvWarehouse.Name = "dgvWarehouse";
            dgvWarehouse.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWarehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvWarehouse.RowHeadersWidth = 51;
            dgvWarehouse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Rockwell", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvWarehouse.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvWarehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWarehouse.Size = new Size(571, 290);
            dgvWarehouse.TabIndex = 7;
            dgvWarehouse.CellClick += dgvWarehouse_CellClick;
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
            btnAddWh.Location = new Point(188, 171);
            btnAddWh.MinimumSize = new Size(144, 47);
            btnAddWh.Name = "btnAddWh";
            btnAddWh.NormalBackColor = Color.DarkRed;
            btnAddWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAddWh.PressedForeColor = Color.White;
            btnAddWh.Radius = 20;
            btnAddWh.Size = new Size(144, 47);
            btnAddWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAddWh.TabIndex = 8;
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
            btnUpdateWh.Location = new Point(188, 102);
            btnUpdateWh.MinimumSize = new Size(144, 47);
            btnUpdateWh.Name = "btnUpdateWh";
            btnUpdateWh.NormalBackColor = Color.DarkRed;
            btnUpdateWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUpdateWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUpdateWh.PressedForeColor = Color.White;
            btnUpdateWh.Radius = 20;
            btnUpdateWh.Size = new Size(144, 47);
            btnUpdateWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUpdateWh.TabIndex = 9;
            btnUpdateWh.Text = "Update";
            btnUpdateWh.Click += btnUpdateWh_Click;
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
            btnDltWh.Location = new Point(188, 241);
            btnDltWh.MinimumSize = new Size(144, 47);
            btnDltWh.Name = "btnDltWh";
            btnDltWh.NormalBackColor = Color.DarkRed;
            btnDltWh.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnDltWh.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnDltWh.PressedForeColor = Color.White;
            btnDltWh.Radius = 20;
            btnDltWh.Size = new Size(144, 47);
            btnDltWh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnDltWh.TabIndex = 10;
            btnDltWh.Text = "Delete";
            btnDltWh.Click += btnDltWh_Click;
            // 
            // txtWhName
            // 
            txtWhName.BackColor = Color.Transparent;
            txtWhName.BorderColor = Color.FromArgb(180, 180, 180);
            txtWhName.CustomBGColor = Color.White;
            txtWhName.Font = new Font("Tahoma", 11F);
            txtWhName.ForeColor = Color.DarkGray;
            txtWhName.Location = new Point(15, 128);
            txtWhName.MaxLength = 32767;
            txtWhName.Multiline = false;
            txtWhName.Name = "txtWhName";
            txtWhName.ReadOnly = false;
            txtWhName.Size = new Size(138, 33);
            txtWhName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtWhName.TabIndex = 15;
            txtWhName.Text = "Name";
            txtWhName.TextAlignment = HorizontalAlignment.Left;
            txtWhName.UseSystemPasswordChar = false;
            txtWhName.Enter += txtWhName_Enter;
            // 
            // txtWhLoc
            // 
            txtWhLoc.BackColor = Color.Transparent;
            txtWhLoc.BorderColor = Color.FromArgb(180, 180, 180);
            txtWhLoc.CustomBGColor = Color.White;
            txtWhLoc.Font = new Font("Tahoma", 11F);
            txtWhLoc.ForeColor = Color.DarkGray;
            txtWhLoc.Location = new Point(15, 185);
            txtWhLoc.MaxLength = 32767;
            txtWhLoc.Multiline = false;
            txtWhLoc.Name = "txtWhLoc";
            txtWhLoc.ReadOnly = false;
            txtWhLoc.Size = new Size(138, 33);
            txtWhLoc.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtWhLoc.TabIndex = 17;
            txtWhLoc.Tag = "";
            txtWhLoc.Text = "Location";
            txtWhLoc.TextAlignment = HorizontalAlignment.Left;
            txtWhLoc.UseSystemPasswordChar = false;
            txtWhLoc.Enter += txtWhLoc_Enter;
            // 
            // txtManger
            // 
            txtManger.BackColor = Color.Transparent;
            txtManger.BorderColor = Color.FromArgb(180, 180, 180);
            txtManger.CustomBGColor = Color.White;
            txtManger.Font = new Font("Tahoma", 11F);
            txtManger.ForeColor = Color.DarkGray;
            txtManger.Location = new Point(15, 241);
            txtManger.MaxLength = 32767;
            txtManger.Multiline = false;
            txtManger.Name = "txtManger";
            txtManger.ReadOnly = false;
            txtManger.Size = new Size(138, 33);
            txtManger.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtManger.TabIndex = 18;
            txtManger.Text = "Manager";
            txtManger.TextAlignment = HorizontalAlignment.Left;
            txtManger.UseSystemPasswordChar = false;
            txtManger.Enter += txtManger_Enter;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft YaHei UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DarkRed;
            bigLabel1.Location = new Point(2, 30);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(330, 56);
            bigLabel1.TabIndex = 19;
            bigLabel1.Text = "WAREHOUSES";
            // 
            // UcWarehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(bigLabel1);
            Controls.Add(txtManger);
            Controls.Add(txtWhLoc);
            Controls.Add(txtWhName);
            Controls.Add(btnDltWh);
            Controls.Add(btnUpdateWh);
            Controls.Add(btnAddWh);
            Controls.Add(dgvWarehouse);
            Name = "UcWarehouse";
            Size = new Size(994, 379);
            Resize += UcWarehouse_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvWarehouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonDataGridView dgvWarehouse;
        private ReaLTaiizor.Controls.NightButton btnAddWh;
        private ReaLTaiizor.Controls.NightButton btnUpdateWh;
        private ReaLTaiizor.Controls.NightButton btnDltWh;
        private ReaLTaiizor.Controls.SmallTextBox txtWhName;
        private ReaLTaiizor.Controls.SmallTextBox txtWhLoc;
        private ReaLTaiizor.Controls.SmallTextBox txtManger;




        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            btnSplyperm = new ReaLTaiizor.Controls.HopeButton();
            btnRlsperm = new ReaLTaiizor.Controls.HopeButton();
            btnProduct = new ReaLTaiizor.Controls.HopeButton();
            btnSupplier = new ReaLTaiizor.Controls.HopeButton();
            btnCategory = new ReaLTaiizor.Controls.HopeButton();
            btnWh = new ReaLTaiizor.Controls.HopeButton();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            pnlFooter = new Panel();
            pnlMain = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Red;
            pnlMenu.Controls.Add(hopeComboBox1);
            pnlMenu.Controls.Add(btnSplyperm);
            pnlMenu.Controls.Add(btnRlsperm);
            pnlMenu.Controls.Add(btnProduct);
            pnlMenu.Controls.Add(btnSupplier);
            pnlMenu.Controls.Add(btnCategory);
            pnlMenu.Controls.Add(btnWh);
            pnlMenu.Controls.Add(headerLabel1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(803, 179);
            pnlMenu.TabIndex = 0;
            // 
            // hopeComboBox1
            // 
            hopeComboBox1.BackColor = Color.Red;
            hopeComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBox1.FlatStyle = FlatStyle.Flat;
            hopeComboBox1.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            hopeComboBox1.ForeColor = Color.White;
            hopeComboBox1.FormattingEnabled = true;
            hopeComboBox1.ItemHeight = 30;
            hopeComboBox1.Items.AddRange(new object[] { "Warehouse Report", "Product Report", "Product Movement Report", "Expired Products Report", "Expiring Soon Report" });
            hopeComboBox1.Location = new Point(144, 127);
            hopeComboBox1.Name = "hopeComboBox1";
            hopeComboBox1.Size = new Size(507, 36);
            hopeComboBox1.TabIndex = 9;
            hopeComboBox1.Text = "                       Generate Reports";
            // 
            // btnSplyperm
            // 
            btnSplyperm.BackColor = Color.White;
            btnSplyperm.BorderColor = Color.White;
            btnSplyperm.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSplyperm.DangerColor = Color.FromArgb(245, 108, 108);
            btnSplyperm.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSplyperm.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSplyperm.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSplyperm.InfoColor = Color.FromArgb(144, 147, 153);
            btnSplyperm.Location = new Point(533, 61);
            btnSplyperm.Name = "btnSplyperm";
            btnSplyperm.PrimaryColor = Color.White;
            btnSplyperm.Size = new Size(118, 50);
            btnSplyperm.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSplyperm.TabIndex = 7;
            btnSplyperm.Text = "Supply Permission";
            btnSplyperm.TextColor = Color.Red;
            btnSplyperm.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnRlsperm
            // 
            btnRlsperm.BackColor = Color.White;
            btnRlsperm.BorderColor = Color.White;
            btnRlsperm.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRlsperm.DangerColor = Color.FromArgb(245, 108, 108);
            btnRlsperm.DefaultColor = Color.FromArgb(255, 255, 255);
            btnRlsperm.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRlsperm.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnRlsperm.InfoColor = Color.FromArgb(144, 147, 153);
            btnRlsperm.Location = new Point(673, 61);
            btnRlsperm.Name = "btnRlsperm";
            btnRlsperm.PrimaryColor = Color.White;
            btnRlsperm.Size = new Size(118, 50);
            btnRlsperm.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRlsperm.TabIndex = 8;
            btnRlsperm.Text = "Release Permission";
            btnRlsperm.TextColor = Color.Red;
            btnRlsperm.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.White;
            btnProduct.BorderColor = Color.White;
            btnProduct.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnProduct.DangerColor = Color.FromArgb(245, 108, 108);
            btnProduct.DefaultColor = Color.FromArgb(255, 255, 255);
            btnProduct.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProduct.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnProduct.InfoColor = Color.FromArgb(144, 147, 153);
            btnProduct.Location = new Point(144, 61);
            btnProduct.Name = "btnProduct";
            btnProduct.PrimaryColor = Color.White;
            btnProduct.Size = new Size(118, 50);
            btnProduct.SuccessColor = Color.FromArgb(103, 194, 58);
            btnProduct.TabIndex = 6;
            btnProduct.Text = "products";
            btnProduct.TextColor = Color.Red;
            btnProduct.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.White;
            btnSupplier.BorderColor = Color.White;
            btnSupplier.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSupplier.DangerColor = Color.FromArgb(245, 108, 108);
            btnSupplier.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSupplier.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSupplier.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSupplier.InfoColor = Color.FromArgb(144, 147, 153);
            btnSupplier.Location = new Point(406, 61);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.PrimaryColor = Color.White;
            btnSupplier.Size = new Size(118, 50);
            btnSupplier.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSupplier.TabIndex = 4;
            btnSupplier.Text = "Suppliers";
            btnSupplier.TextColor = Color.Red;
            btnSupplier.WarningColor = Color.FromArgb(230, 162, 60);
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.White;
            btnCategory.BorderColor = Color.White;
            btnCategory.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCategory.DangerColor = Color.FromArgb(245, 108, 108);
            btnCategory.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCategory.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCategory.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCategory.InfoColor = Color.FromArgb(144, 147, 153);
            btnCategory.Location = new Point(272, 61);
            btnCategory.Name = "btnCategory";
            btnCategory.PrimaryColor = Color.White;
            btnCategory.Size = new Size(118, 50);
            btnCategory.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Categories";
            btnCategory.TextColor = Color.Red;
            btnCategory.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnWh
            // 
            btnWh.BackColor = Color.White;
            btnWh.BorderColor = Color.White;
            btnWh.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnWh.DangerColor = Color.FromArgb(245, 108, 108);
            btnWh.DefaultColor = Color.FromArgb(255, 255, 255);
            btnWh.Font = new Font("Stencil", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnWh.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnWh.InfoColor = Color.FromArgb(144, 147, 153);
            btnWh.Location = new Point(12, 61);
            btnWh.Name = "btnWh";
            btnWh.PrimaryColor = Color.White;
            btnWh.Size = new Size(118, 50);
            btnWh.SuccessColor = Color.FromArgb(103, 194, 58);
            btnWh.TabIndex = 2;
            btnWh.Text = "Warehouse";
            btnWh.TextColor = Color.Red;
            btnWh.WarningColor = Color.FromArgb(230, 162, 60);
            btnWh.Click += btnWh_Click;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel1.Location = new Point(194, 9);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(386, 29);
            headerLabel1.TabIndex = 0;
            headerLabel1.Text = "INVENTORY MANAGEMENT SYSTEM";
            headerLabel1.Click += headerLabel1_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Red;
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 450);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(803, 18);
            pnlFooter.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pnlMain.ForeColor = Color.White;
            pnlMain.Location = new Point(0, 179);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(803, 271);
            pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 468);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlMenu);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlFooter;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private Panel pnlMain;
        private ReaLTaiizor.Controls.HopeButton btnWh;
        private ReaLTaiizor.Controls.HopeButton btnSplyperm;
        private ReaLTaiizor.Controls.HopeButton btnRlsperm;
        private ReaLTaiizor.Controls.HopeButton btnProduct;
        private ReaLTaiizor.Controls.HopeButton btnSupplier;
        private ReaLTaiizor.Controls.HopeButton btnCategory;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
    }
}

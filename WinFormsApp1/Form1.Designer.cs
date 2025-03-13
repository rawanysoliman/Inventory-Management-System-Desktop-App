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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlMenu = new Panel();
            foreverComboBox1 = new ReaLTaiizor.Controls.ForeverComboBox();
            label2 = new Label();
            foxBigLabel2 = new ReaLTaiizor.Controls.FoxBigLabel();
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            btnSplyperm = new ReaLTaiizor.Controls.HopeButton();
            btnRlsperm = new ReaLTaiizor.Controls.HopeButton();
            btnProduct = new ReaLTaiizor.Controls.HopeButton();
            btnSupplier = new ReaLTaiizor.Controls.HopeButton();
            btnCategory = new ReaLTaiizor.Controls.HopeButton();
            btnWh = new ReaLTaiizor.Controls.HopeButton();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            pnlFooter = new Panel();
            pnlMain = new Panel();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DarkRed;
            pnlMenu.Controls.Add(foreverComboBox1);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(foxBigLabel2);
            pnlMenu.Controls.Add(foxBigLabel1);
            pnlMenu.Controls.Add(btnSplyperm);
            pnlMenu.Controls.Add(btnRlsperm);
            pnlMenu.Controls.Add(btnProduct);
            pnlMenu.Controls.Add(btnSupplier);
            pnlMenu.Controls.Add(btnCategory);
            pnlMenu.Controls.Add(btnWh);
            pnlMenu.Controls.Add(headerLabel1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.ForeColor = Color.White;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(994, 184);
            pnlMenu.TabIndex = 0;
            // 
            // foreverComboBox1
            // 
            foreverComboBox1.BackColor = SystemColors.ActiveCaptionText;
            foreverComboBox1.BaseColor = Color.Silver;
            foreverComboBox1.BGColor = Color.White;
            foreverComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            foreverComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foreverComboBox1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreverComboBox1.ForeColor = Color.White;
            foreverComboBox1.FormattingEnabled = true;
            foreverComboBox1.HoverColor = Color.Gainsboro;
            foreverComboBox1.HoverFontColor = Color.FromArgb(64, 0, 0);
            foreverComboBox1.ItemHeight = 18;
            foreverComboBox1.Items.AddRange(new object[] { "Warehouse Report", "Product Report", "Product Movement Report", "Expired Products Report", "Expiring Soon Report" });
            foreverComboBox1.Location = new Point(356, 138);
            foreverComboBox1.Name = "foreverComboBox1";
            foreverComboBox1.Size = new Size(614, 24);
            foreverComboBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(714, 110);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // foxBigLabel2
            // 
            foxBigLabel2.BackColor = Color.Transparent;
            foxBigLabel2.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foxBigLabel2.ForeColor = Color.White;
            foxBigLabel2.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel2.LineColor = Color.Transparent;
            foxBigLabel2.Location = new Point(237, 148);
            foxBigLabel2.Name = "foxBigLabel2";
            foxBigLabel2.Size = new Size(87, 30);
            foxBigLabel2.TabIndex = 11;
            foxBigLabel2.Text = "REPORTS";
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.Transparent;
            foxBigLabel1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foxBigLabel1.ForeColor = Color.White;
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.Transparent;
            foxBigLabel1.Location = new Point(232, 126);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(107, 36);
            foxBigLabel1.TabIndex = 10;
            foxBigLabel1.Text = "GENERATE";
            // 
            // btnSplyperm
            // 
            btnSplyperm.BackColor = Color.White;
            btnSplyperm.BorderColor = Color.White;
            btnSplyperm.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSplyperm.DangerColor = Color.Gray;
            btnSplyperm.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSplyperm.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSplyperm.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSplyperm.InfoColor = Color.FromArgb(144, 147, 153);
            btnSplyperm.Location = new Point(728, 60);
            btnSplyperm.Name = "btnSplyperm";
            btnSplyperm.PrimaryColor = Color.White;
            btnSplyperm.Size = new Size(118, 50);
            btnSplyperm.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSplyperm.TabIndex = 7;
            btnSplyperm.Text = "Supply Permission";
            btnSplyperm.TextColor = Color.DarkRed;
            btnSplyperm.WarningColor = Color.FromArgb(230, 162, 60);
            btnSplyperm.Click += btnSplyperm_Click;
            // 
            // btnRlsperm
            // 
            btnRlsperm.BackColor = Color.White;
            btnRlsperm.BorderColor = Color.White;
            btnRlsperm.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRlsperm.DangerColor = Color.Silver;
            btnRlsperm.DefaultColor = Color.FromArgb(255, 255, 255);
            btnRlsperm.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRlsperm.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnRlsperm.InfoColor = Color.FromArgb(144, 147, 153);
            btnRlsperm.Location = new Point(852, 60);
            btnRlsperm.Name = "btnRlsperm";
            btnRlsperm.PrimaryColor = Color.White;
            btnRlsperm.Size = new Size(118, 50);
            btnRlsperm.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRlsperm.TabIndex = 8;
            btnRlsperm.Text = "Release Permission";
            btnRlsperm.TextColor = Color.DarkRed;
            btnRlsperm.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.White;
            btnProduct.BorderColor = Color.White;
            btnProduct.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnProduct.DangerColor = Color.FromArgb(245, 108, 108);
            btnProduct.DefaultColor = Color.FromArgb(255, 255, 255);
            btnProduct.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnProduct.InfoColor = Color.FromArgb(144, 147, 153);
            btnProduct.Location = new Point(356, 59);
            btnProduct.Name = "btnProduct";
            btnProduct.PrimaryColor = Color.White;
            btnProduct.Size = new Size(118, 50);
            btnProduct.SuccessColor = Color.FromArgb(103, 194, 58);
            btnProduct.TabIndex = 6;
            btnProduct.Text = "products";
            btnProduct.TextColor = Color.DarkRed;
            btnProduct.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.White;
            btnSupplier.BorderColor = Color.White;
            btnSupplier.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSupplier.DangerColor = Color.FromArgb(245, 108, 108);
            btnSupplier.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSupplier.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupplier.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSupplier.InfoColor = Color.FromArgb(144, 147, 153);
            btnSupplier.Location = new Point(604, 60);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.PrimaryColor = Color.White;
            btnSupplier.Size = new Size(118, 50);
            btnSupplier.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSupplier.TabIndex = 4;
            btnSupplier.Text = "Suppliers";
            btnSupplier.TextColor = Color.DarkRed;
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
            btnCategory.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategory.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCategory.InfoColor = Color.FromArgb(144, 147, 153);
            btnCategory.Location = new Point(480, 60);
            btnCategory.Name = "btnCategory";
            btnCategory.PrimaryColor = Color.White;
            btnCategory.Size = new Size(118, 50);
            btnCategory.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Categories";
            btnCategory.TextColor = Color.DarkRed;
            btnCategory.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnWh
            // 
            btnWh.BackColor = Color.White;
            btnWh.BorderColor = Color.White;
            btnWh.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnWh.DangerColor = Color.FromArgb(245, 108, 108);
            btnWh.DefaultColor = Color.FromArgb(255, 255, 255);
            btnWh.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWh.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnWh.InfoColor = Color.FromArgb(144, 147, 153);
            btnWh.Location = new Point(232, 59);
            btnWh.Name = "btnWh";
            btnWh.PrimaryColor = Color.White;
            btnWh.Size = new Size(118, 50);
            btnWh.SuccessColor = Color.FromArgb(103, 194, 58);
            btnWh.TabIndex = 2;
            btnWh.Text = "Warehouse";
            btnWh.TextColor = Color.DarkRed;
            btnWh.WarningColor = Color.FromArgb(230, 162, 60);
            btnWh.Click += btnWh_Click;
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Goudy Stout", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            headerLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel1.Location = new Point(0, 9);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(202, 64);
            headerLabel1.TabIndex = 0;
            headerLabel1.Text = "IMS";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Maroon;
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 555);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(994, 14);
            pnlFooter.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.BackgroundImage = (Image)resources.GetObject("pnlMain.BackgroundImage");
            pnlMain.BorderStyle = BorderStyle.Fixed3D;
            pnlMain.Controls.Add(label1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pnlMain.ForeColor = Color.White;
            pnlMain.Location = new Point(0, 184);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(994, 371);
            pnlMain.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(591, 254);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 569);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlMenu);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
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
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel2;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.ForeverComboBox foreverComboBox1;
    }
}

using InventoryManagementSystem.context;
using InventoryManagementSystem.Entities;
using WinFormsApp1;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myContext context = new myContext();
        }



        private void btnSupplier_Click(object sender, EventArgs e)
        {

        }




        private void LoadUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnWh_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcWarehouse());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnSplyperm_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SupplyPerm());
        }
    }
}

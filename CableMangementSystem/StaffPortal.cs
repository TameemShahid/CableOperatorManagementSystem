using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableMangementSystem
{
    public partial class StaffPortal : Form
    {
        public StaffPortal()
        {
            InitializeComponent();
        }
        
        private void addInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AddInventory = new AddInventory();
            AddInventory.MdiParent = this;
            AddInventory.Show();
        }

        private void addAreaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form addArea = new Area();
            addArea.MdiParent = this;
            addArea.Show();
        }

        private void billingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form billingHistory = new BillingHistory();
            billingHistory.MdiParent = this;
            billingHistory.Show();
        }

        private void addBlockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Block blk = new Block();
            blk.MdiParent = this;
            blk.Show();
        }

        private void addCityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.MdiParent = this;
            city.Show();
        }

        private void addConnectionChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConnCharges ncc = new NewConnCharges();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Payment newPayment = new Payment();
            newPayment.MdiParent = this;
            newPayment.Show();
        }
        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditConnCharges ecc = new EditConnCharges();
            ecc.MdiParent = this;
            ecc.Show();
        }

       
        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowInventory showInven = new ShowInventory();
            showInven.MdiParent = this;
            showInven.Show();
        }

        private void StaffPortal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.WindowState = FormWindowState.Maximized;
            report.MdiParent = this;
            report.Show();
        }
    }
}

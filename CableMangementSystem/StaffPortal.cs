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
            AddInventory.WindowState = FormWindowState.Maximized;
            AddInventory.MdiParent = this;
            AddInventory.Show();
        }

        private void addAreaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form addArea = new Area();
            addArea.WindowState = FormWindowState.Maximized;
            addArea.MdiParent = this;
            addArea.Show();
        }

        private void billingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form billingHistory = new BillingHistory();
            billingHistory.WindowState = FormWindowState.Maximized;
            billingHistory.MdiParent = this;
            billingHistory.Show();
        }

        private void addBlockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Block blk = new Block();
            blk.WindowState = FormWindowState.Maximized;
            blk.MdiParent = this;
            blk.Show();
        }

        private void addCityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.WindowState = FormWindowState.Maximized;
            city.MdiParent = this;
            city.Show();
        }

        private void addConnectionChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConnCharges ncc = new NewConnCharges();
            ncc.WindowState = FormWindowState.Maximized;
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Payment newPayment = new Payment();
            newPayment.WindowState = FormWindowState.Maximized;
            newPayment.MdiParent = this;
            newPayment.Show();
        }
        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditConnCharges ecc = new EditConnCharges();
            ecc.WindowState = FormWindowState.Maximized;
            ecc.MdiParent = this;
            ecc.Show();
        }

       
        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowInventory showInven = new ShowInventory();
            showInven.WindowState = FormWindowState.Maximized;
            showInven.MdiParent = this;
            showInven.Show();
        }

        private void StaffPortal_Load(object sender, EventArgs e)
        {
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.WindowState = FormWindowState.Maximized;
            report.MdiParent = this;
            report.Show();
        }

        private void ShowCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCityForm show = new ShowCityForm();
            show.WindowState = FormWindowState.Maximized;
            show.MdiParent = this;
            show.Show();
        }

        private void showAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAreas area = new ShowAreas();
            area.WindowState = FormWindowState.Maximized;
            area.MdiParent = this;
            area.Show();
        }

        private void showPendingConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingConnections pendingConn = new PendingConnections();
            pendingConn.WindowState = FormWindowState.Maximized;
            pendingConn.MdiParent = this;
            pendingConn.Show();
        }

        private void showBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBlock ShBlock = new ShowBlock();
            ShBlock.WindowState = FormWindowState.Maximized;
            ShBlock.MdiParent = this;
            ShBlock.Show();
        }
    }
}

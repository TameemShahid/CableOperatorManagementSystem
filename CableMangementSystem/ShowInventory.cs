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
    public partial class ShowInventory : Form
    {
        public ShowInventory()
        {
            InitializeComponent();
        }

        private void ShowInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cableMDBDataSet.INVENTORY' table. You can move, or remove it, as needed.
            this.iNVENTORYTableAdapter.Fill(this.cableMDBDataSet.INVENTORY);
            // TODO: This line of code loads data into the 'cableMDBDataSet.INVENTORY' table. You can move, or remove it, as needed.
            this.iNVENTORYTableAdapter.Fill(this.cableMDBDataSet.INVENTORY);

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

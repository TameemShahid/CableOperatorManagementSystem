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
    public partial class ReportEach : Form
    {
        public ReportEach()
        {
            InitializeComponent();
        }

        public ReportEach(string username)
        {
            InitializeComponent();
            MessageBox.Show(username);
        }

        private void ReportEach_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
        }
    }
}

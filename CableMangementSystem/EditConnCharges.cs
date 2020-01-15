using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CableMangementSystem
{
    public partial class EditConnCharges : Form
    {
        public EditConnCharges()
        {
            InitializeComponent();
            Expired.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Expired_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void EditConnCharges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cableMDBDataSet.CONNECTION' table. You can move, or remove it, as needed.
            this.cONNECTIONTableAdapter.Fill(this.cableMDBDataSet.CONNECTION);
            // TODO: This line of code loads data into the 'cableMDBDataSet.CONNECTION' table. You can move, or remove it, as needed.
            this.cONNECTIONTableAdapter.Fill(this.cableMDBDataSet.CONNECTION);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cONNECTIONTableAdapter.FillBy(this.cableMDBDataSet.CONNECTION);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(Expired.Checked)
                {
                    var conn_id = dataGridView1.SelectedRows[0].Cells[0].Value;

                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EDIT_CONN_CHRG_PROC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CONN_ID", conn_id));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(conn_id.ToString() + " successfully expired!");
                    this.cONNECTIONTableAdapter.Fill(this.cableMDBDataSet.CONNECTION);
                    Expired.Checked = false;
                }
                else
                {
                    MessageBox.Show("You need to check 'Expired' to expire connection charges!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

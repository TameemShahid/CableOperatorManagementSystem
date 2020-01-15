using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableMangementSystem
{
    public partial class PendingConnections : Form
    {
        public PendingConnections()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void PendingConnections_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("LOAD_CONN_CHRG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    comboBox1.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            { MessageBox.Show("Charges cannot be empty!"); }
            else
            {
                try
                {
                    string connection_id = "";
                    var address_id = dataGridView1.SelectedRows[0].Cells[0].Value;
                    var charges = comboBox1.Text;

                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("RET_CONN_ID_FOR_AMOUNT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@AMOUNT", comboBox1.Text));
                    SqlDataReader reader;

                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        connection_id = reader.GetValue(0).ToString();
                        break;
                    }
                    reader.Close();

                    cmd = new SqlCommand("PENDING_CHRG_PROC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CONN_ID", connection_id));
                    cmd.Parameters.Add(new SqlParameter("@ADDR_ID", address_id));
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadDataGridView();
                    MessageBox.Show("Connection Charges successfully added!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void LoadDataGridView()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("LOAD_PENDING_CONN", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlda = new SqlDataAdapter(command);   

                DataSet ds = new DataSet();
                sqlda.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

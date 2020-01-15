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
    public partial class ReportForm : Form
    {
        string user_id = "";
        public ReportForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadDataGridView();

        }


        private void LoadDataGridView()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("LOAD_HISTORY_DATA", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlda = new SqlDataAdapter(command);
               
                DataSet ds = new DataSet();
                sqlda.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GenerateReport()
        {

            SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("LOAD_HISTORY_BY_USERID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@USERID", user_id));

                SqlDataReader reader;
                string user = " ";

                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    user = reader["NAME"].ToString();
                }

                // generate report from above information
                ReportEach report = new ReportEach(user);
                report.ShowDialog();

                conn.Close(); 
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }   
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            user_id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void GenReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}

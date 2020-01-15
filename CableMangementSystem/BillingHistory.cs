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
    public partial class BillingHistory : Form
    {
        public BillingHistory()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LOAD_HISTORY_DATA", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlda = new SqlDataAdapter(cmd);

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
        }

        private void groupBox1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LOAD_HISTORY_BY_UNPAID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlda = new SqlDataAdapter(cmd);

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
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LOAD_HISTORY_BY_PAID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlda = new SqlDataAdapter(cmd);

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ToSearch = textBox1.Text;

            if(ToSearch == "")
            {
                MessageBox.Show("Search Box is empty please fill with valid data!");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LOAD_HISTORY_BY_USERNAME", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NAME", textBox1.Text));
                    SqlDataAdapter sqlda = new SqlDataAdapter(cmd);

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
        }

        private void BillingHistory_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Search only through User Name...";
            radioButton1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search only through User Name...")
                textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search only through User Name...";
                textBox1.ForeColor = Color.Gray;
            }
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class NewConnCharges : Form
    {
        int amount;
        string desc;
        string date;
        public NewConnCharges()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int length = textBox2.Text.Length;

            if(length > 20)
            {
                MessageBox.Show("Error! Description cannot be greater than 20 characters!");
                textBox2.Text = "";
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionEnd.ToShortDateString());
        }

        private void NewConnCharges_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("ADD_CONN_PROC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AMOUNT", numericUpDown1.Value));
                cmd.Parameters.Add(new SqlParameter("@DESC", textBox2.Text));
                cmd.Parameters.Add(new SqlParameter("@START_DATE", monthCalendar1.SelectionRange.End.ToShortDateString()));

                cmd.ExecuteNonQuery();
                conn.Close();

                numericUpDown1.Value = 0;
                textBox2.Text = "";
                monthCalendar1.ResetText();

                MessageBox.Show("New Connection Charge successfully added!");
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

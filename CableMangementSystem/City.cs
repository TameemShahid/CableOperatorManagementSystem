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
    public partial class City : Form
    {
        public City()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void City_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Text box cant be empty!");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ADD_CITY_PROC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CITY_NAME", textBox1.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    textBox1.Text = "";
                    MessageBox.Show("City successfully added!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("City already exists!");
                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

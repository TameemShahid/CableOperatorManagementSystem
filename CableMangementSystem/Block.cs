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
    public partial class Block : Form
    {
        public Block()
        {
            InitializeComponent();
            if(comboBox1.Text == "")
            {
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void Block_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            var city = comboBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AREA FROM AREA WHERE CITY_NO = (SELECT CITY_NO FROM CITY WHERE CITY='QUETTA')", conn);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                comboBox2.Items.Add(reader["AREA"]);
            }
            conn.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
            if (textBox1.Text == "")
            { MessageBox.Show("Text box cannot be empty"); }
            else
            {
                conn.Open();
                string item;
                string check = "";
                SqlCommand cmd = new SqlCommand("SELECT ITEM FROM INVENTORY WHERE ITEM='" + textBox1.Text+"'", conn);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    check = reader["ITEM"].ToString();
                    break;
                }
                reader.Close();
                if (check != "")
                    MessageBox.Show("Item already exists!");
                else
                {
                    cmd = new SqlCommand("ADD_INVENTORY_PROC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ITEM_NAME", textBox1.Text));
                    cmd.Parameters.Add(new SqlParameter("@QTY", numericUpDown1.Value));
                    cmd.ExecuteReader();
                }
                conn.Close();

                MessageBox.Show("Item successfully added!");
                textBox1.Text = "";
                numericUpDown1.Value = 0;
            }
        }
    }
}

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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("LOAD_CITY",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "CITY";
            conn.Close();
            textBox1.Enabled = true;

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                var CITY_ID = "";
                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("RET_ID_FOR_CITY", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CITY_NAME", comboBox1.Text));

                SqlDataReader SQLREAD;
                SQLREAD = cmd.ExecuteReader();
                while (SQLREAD.Read())
                {
                    CITY_ID = SQLREAD["CITY_NO"].ToString();
                    break;
                }
                SQLREAD.Close();

                cmd = new SqlCommand("ADD_AREA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AREANAME", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@CITYNO", CITY_ID));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Area successfully added!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

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
    public partial class ShowCityForm : Form
    {
        public ShowCityForm()
        {
            InitializeComponent();
        }

        private void ShowCityForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CITY", conn);

                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                List<string> cities = new List<string>();

                while (reader.Read())
                {
                    cities.Add(reader["CITY"].ToString());
                }


                foreach (string item in cities)
                    ShowCityListBox.Items.Add(item);


            } catch (Exception ex) { }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace libraryApp
{

    public partial class Form7 : Form

    {
        string connectionString = @"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True;";
        public Form7()
        {
            InitializeComponent();
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter("SELECT * FROM BOOK ORDER BY Category" , con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
        }

        private void buy_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("update Book set quantity = quantity-1 where name=@book update Book set BuyersNO = BuyersNO+1", con);
            mycommand.Parameters.AddWithValue("@offer", Int64.Parse(promo.Text));
            mycommand.Parameters.AddWithValue("@book", buyname.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into comments values (@comment,@rdid,@bkid) ", con);
            mycommand.Parameters.AddWithValue("@comment", comment.Text);
            mycommand.Parameters.AddWithValue("@rdid", rdrid.Text);
            mycommand.Parameters.AddWithValue("@bkid", bkid.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

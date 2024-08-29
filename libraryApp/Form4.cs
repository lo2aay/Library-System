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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into BOOK (year,name,price,id,quantity,BuyersNO,AUTH_ID,Category) values (@year,@name,@price,@id,@quan,0,@authid,@cat)", con);
            mycommand.Parameters.AddWithValue("@year", year.Text);
            mycommand.Parameters.AddWithValue("@name", title.Text);
            mycommand.Parameters.AddWithValue("@id", Int64.Parse(bookid.Text));
            mycommand.Parameters.AddWithValue("@price", Int64.Parse(price.Text));
            mycommand.Parameters.AddWithValue("@quan", Int64.Parse(quan.Text));
            mycommand.Parameters.AddWithValue("@authid", Int64.Parse(authid.Text));
            mycommand.Parameters.AddWithValue("@cat", cat.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

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
    public partial class Form8 : Form
    {
        string connectionString = @"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True;";
        public Form8()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open(); //update BOOK set Offer = @offer where name=@book
            SqlCommand mycommand = new SqlCommand("update [USER] set Lname=@Lname, Fname=@Fname, street=@street, buildingNo=@building,city=@city,passowrd=@password ,phone=@Pnumber where USR_ID=@id AND passowrd=@ps", con);
            mycommand.Parameters.AddWithValue("@Lname", Lname.Text);
            mycommand.Parameters.AddWithValue("@Fname", Fname.Text);
            mycommand.Parameters.AddWithValue("@id", id.Text);
            mycommand.Parameters.AddWithValue("@street", street.Text);
            mycommand.Parameters.AddWithValue("@building", building.Text);
            mycommand.Parameters.AddWithValue("@city", city.Text);
            mycommand.Parameters.AddWithValue("@password", password.Text);
            mycommand.Parameters.AddWithValue("@ps", textBox2.Text);
            mycommand.Parameters.AddWithValue("@Pnumber", Pnumber.Text);
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

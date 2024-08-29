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
    public partial class Form2 : Form

    {
        string connectionString = @"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into [USER] values (@Lname,@Fname,@id,@street,@building,@city,@password,@Pnumber) insert into [admin] values (@id)",con);
            mycommand.Parameters.AddWithValue("@Lname",Lname.Text);
            mycommand.Parameters.AddWithValue("@Fname",Fname.Text);
            mycommand.Parameters.AddWithValue("@id", id.Text);
            mycommand.Parameters.AddWithValue("@street", street.Text);
            mycommand.Parameters.AddWithValue("@building", building.Text);
            mycommand.Parameters.AddWithValue("@city", city.Text);
            mycommand.Parameters.AddWithValue("@password", password.Text);
            mycommand.Parameters.AddWithValue("@Pnumber", Pnumber.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void author_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into [USER] values (@Lname,@Fname,@id,@street,@building,@city,@password,@Pnumber) insert into AUTHOR values (@id)", con);
            mycommand.Parameters.AddWithValue("@Lname", Lname.Text);
            mycommand.Parameters.AddWithValue("@Fname", Fname.Text);
            mycommand.Parameters.AddWithValue("@id", id.Text);
            mycommand.Parameters.AddWithValue("@street", street.Text);
            mycommand.Parameters.AddWithValue("@building", building.Text);
            mycommand.Parameters.AddWithValue("@city", city.Text);
            mycommand.Parameters.AddWithValue("@password", password.Text);
            mycommand.Parameters.AddWithValue("@Pnumber", Pnumber.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();
        }

        private void student_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into [USER] values (@Lname,@Fname,@id,@street,@building,@city,@password,@Pnumber) insert into READER values (@id) insert into student values (@id)", con);
            mycommand.Parameters.AddWithValue("@Lname", Lname.Text);
            mycommand.Parameters.AddWithValue("@Fname", Fname.Text);
            mycommand.Parameters.AddWithValue("@id", id.Text);
            mycommand.Parameters.AddWithValue("@street", street.Text);
            mycommand.Parameters.AddWithValue("@building", building.Text);
            mycommand.Parameters.AddWithValue("@city", city.Text);
            mycommand.Parameters.AddWithValue("@password", password.Text);
            mycommand.Parameters.AddWithValue("@Pnumber", Pnumber.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();
        }

        private void reader_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into [USER] values (@Lname,@Fname,@id,@street,@building,@city,@password,@Pnumber) insert into READER values (@id)", con);
            mycommand.Parameters.AddWithValue("@Lname", Lname.Text);
            mycommand.Parameters.AddWithValue("@Fname", Fname.Text);
            mycommand.Parameters.AddWithValue("@id", id.Text);
            mycommand.Parameters.AddWithValue("@street", street.Text);
            mycommand.Parameters.AddWithValue("@building", building.Text);
            mycommand.Parameters.AddWithValue("@city", city.Text);
            mycommand.Parameters.AddWithValue("@password", password.Text);
            mycommand.Parameters.AddWithValue("@Pnumber", Pnumber.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
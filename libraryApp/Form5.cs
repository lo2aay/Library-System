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
    public partial class Form5 : Form
    {
        string connectionString = @"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True;";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L558MLK;Initial Catalog=library;Integrated Security=True");
            con.Open(); //update BOOK set Offer = @offer where name=@book
            SqlCommand mycommand = new SqlCommand("update BOOK set Offer = @offer where name=@book", con);
            mycommand.Parameters.AddWithValue("@offer", Int64.Parse(offer.Text));
            mycommand.Parameters.AddWithValue("@book", bk.Text);
            SqlDataReader randomrdr = mycommand.ExecuteReader();
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter(" select name from book where BuyersNo = (select max(BuyersNo) from book);", con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter("SELECT distinct book.name from buys,reader,book where " +
                        "reader.RDR_ID = buys.RDR_ID " +
                        "and book.id = buys.id " +
                        "and date < DATEADD(day,-30, getdate()) and date < getdate()" +
                        "except SELECT distinct book.name from buys, reader, book " +
                        "where reader.RDR_ID=buys.RDR_ID and book.id=buys.id and date > DATEADD(day,-30, getdate()) " +
                        "and date < getdate()", con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter("select top 1  category,count(category) as TotalNo from book group by category order by TotalNo asc", con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter("select [user].Lname, [user].fNAME, [user].USR_ID,[user].street, [user].buildingno,[user].city, [user].passowrd, [user].phone," +
                        "boughtNO = (select count(buys.RDR_ID) from buys where buys.RDR_ID = reader.RDR_ID)" +
                        "from [user],reader where [user].USR_ID = reader.RDR_ID select min(category) from book", con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter("select count(*) as NUM_of_authors from(SELECT author.AUTH_ID from buys,author,book,reader where reader.RDR_ID=buys.RDR_ID and author.AUTH_ID=book.AUTH_ID and book.id=buys.id and date < DATEADD(day,-30, getdate())  and date < getdate() except SELECT author.AUTH_ID from buys,reader,book,author where reader.RDR_ID=buys.RDR_ID and author.AUTH_ID=book.AUTH_ID and book.id=buys.id and date > DATEADD(day,-30, getdate()) and date < getdate()) temp;", con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // select distinct author.AUTH_ID from book, author where author.AUTH_ID != book.AUTH_ID except select distinct author.AUTH_ID from book, author where author.AUTH_ID = book.AUTH_ID
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sqld = new SqlDataAdapter("select distinct author.AUTH_ID from book, author where author.AUTH_ID != book.AUTH_ID except select distinct author.AUTH_ID from book, author where author.AUTH_ID = book.AUTH_ID", con);
                    DataTable dtbl = new DataTable();
                    sqld.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
        }
    }
}

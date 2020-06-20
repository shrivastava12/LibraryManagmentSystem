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
using System.Net.Mail;
using System.Net;

namespace LibraryManagmentSystem
{
    public partial class books_stock : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=library_managment;Integrated Security=True");

        public books_stock()
        {
            InitializeComponent();
        }

        private void books_stock_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            fill_books_info();
        }
        public void fill_books_info()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select books_name,books_author_name,books_quantity,available_qty from books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string i;
            i = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from issue_books where books_name='"+ i.ToString() +"' and book_return_date =''";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;


        }

        private void k(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select books_name,books_author_name,books_quantity,available_qty from books_info where books_name like('%"+ textBox1.Text +"%')";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView2.SelectedCells[6].Value.ToString();
            textBox2.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential("shrivastava74795@gmail.com", "8873715828");
            MailMessage mail = new MailMessage("shrivastava74795@gmail.com", textBox2.Text, "This is message for returning the books", textBox3.Text);
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("Mail Send");
        }
    }
}

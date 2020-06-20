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



namespace LibraryManagmentSystem
{

    public partial class student_return_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=library_managment;Integrated Security =True");

        public student_return_books()
        {
            InitializeComponent();
        }

        private void student_return_books_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

        }
        public void fill_grid(string enrollment)
        {

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where student_enrollment='" + enrollment.ToString() + "' and book_return_date=''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill_grid(txtenrollment.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where id=" + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtbookname.Text = dr["books_name"].ToString();
                txtissuedate.Text = Convert.ToString(dr["books_issue_date"].ToString());

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update issue_books set book_return_date='" + dateTimePicker1.Value.ToString() + "' issue_books where Id=" + i + "";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = conn.CreateCommand();

                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set avilable_qty=avilable_qty+1 where books_name='" + txtbookname.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Books return successfully");
                fill_grid(txtenrollment.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

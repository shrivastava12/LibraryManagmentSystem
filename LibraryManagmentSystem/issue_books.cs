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
    public partial class issue_books : Form
    {
        int books_qty;
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=library_managment;Integrated Security=True");
        public issue_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where student_enrollment_no='"+ txt_enrollment.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("This enrollment no is not found");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtstudent_name.Text = dr["student_name"].ToString();
                    txtstudentdept.Text = dr["student_department"].ToString();
                    txtstudentsem.Text = dr["student_sem"].ToString();
                    txtstudentcontact.Text = dr["student_contact"].ToString();
                    txtstudentemail.Text = dr["student_email"].ToString();
                }
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbookname_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            if (e.KeyCode != Keys.Enter)
            {

                listBox1.Items.Clear();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%" + txtbookname.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da =  new SqlDataAdapter(cmd);
                da.Fill(dt);

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if(count>0)
                {
                    listBox1.Visible = true;
                    foreach(DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"].ToString());
                    }
                }

                 
            }


        }

        private void txtbookname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                //you might need to select one value to allow arrow keys
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbookname.Text = listBox1.SelectedIndex.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtbookname.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd3 = conn.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from books_info where books_name = '" + txtbookname.Text + "'";
            cmd3.ExecuteNonQuery();
            DataTable da3 = new DataTable();
            SqlDataAdapter dt2 = new SqlDataAdapter(cmd3);
            dt2.Fill(da3);
            foreach (DataRow dr2 in da3.Rows)
            {
                books_qty = Convert.ToInt32(dr2["available_qty"].ToString());
            }
            if (books_qty > 0)
            {

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into issue_books values('" + txt_enrollment.Text + "','" + txtstudent_name.Text + "','" + txtstudentdept.Text + "','" + txtstudentsem.Text + "','" + txtstudentcontact.Text + "','" + txtstudentemail.Text + "','" + txtbookname.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set available_qty=available_qty-1 where books_name ='" + txtbookname.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("books Issue Successfully");

            }
            else
            {
                MessageBox.Show("Books not available");
            }
        }
    }
}

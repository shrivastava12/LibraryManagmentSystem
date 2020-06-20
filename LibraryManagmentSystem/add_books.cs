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
    public partial class add_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=library_managment;Integrated Security=True");

        public add_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values('"+ txt1.Text +"','"+ txt2.Text +"','"+ txt3.Text +"','"+ dateTimePicker1.Text +"',"+ txt5.Text +","+ txt6.Text +","+ txt6.Text +")";
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Book Added Successfully");
        }

        private void add_books_Load(object sender, EventArgs e)
        {

        }
    }
}

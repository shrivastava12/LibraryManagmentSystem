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
using System.IO;

namespace LibraryManagmentSystem
{
    public partial class view_student_info : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=library_managment;Integrated Security=True");
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        DialogResult result;
        public view_student_info()
        {
            InitializeComponent();
        }

        public void fillGrid()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt); 
            dataGridView1.DataSource = dt;

            Bitmap img;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol.Width = 500;
            imgcol.HeaderText = "student image";
            imgcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgcol.Width = 100;
            dataGridView1.Columns.Add(imgcol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                dataGridView1.Rows[i].Cells[8].Value = img;
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;
            }
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
           
          
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                int i = 0;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_name like('%"+ textBox1.Text +"%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                imgcol.Width = 500;
                imgcol.HeaderText = "student image";
                imgcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgcol.Width = 100;
                dataGridView1.Columns.Add(imgcol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[8].Value = img;
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtstudent_name.Text = dr["student_name"].ToString();
                txtstudent_enroll.Text = dr["student_enrollment_no"].ToString();
                txtstudent_dept.Text = dr["student_department"].ToString();
                txtstudent_contact.Text = dr["student_contact"].ToString();
                txtstudent_email.Text = dr["student_email"].ToString();
                txtstudent_sem.Text = dr["student_sem"].ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (result == DialogResult.OK) // Test result
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string img_path;
                string pwd = Class1.GetRandomPassword(20);
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jgp");
                img_path = "student_images\\" + pwd + ".jpg";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student_info set student_name='"+ txtstudent_name.Text +"',student_contact = '"+txtstudent_contact.Text +"',student_email = '"+ txtstudent_email.Text +"',student_sem = '"+ txtstudent_sem.Text +"',student_image='"+ img_path.ToString() +"',student_enrollment_no='"+ txtstudent_enroll.Text +"',student_department='"+ txtstudent_dept.Text +"'where id="+ i +"";
                cmd.ExecuteNonQuery();
                fillGrid();
               
                MessageBox.Show("Record Updated Successfully");
            }
            
            else if (result == DialogResult.Cancel)
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student_info set student_name='" + txtstudent_name.Text + "',student_contact = '" + txtstudent_contact.Text + "',student_email = '" + txtstudent_email.Text + "',student_sem = '" + txtstudent_sem.Text + "',student_enrollment_no='" + txtstudent_enroll.Text + "',student_department='" + txtstudent_dept.Text + "'where id=" + i + "";
                cmd.ExecuteNonQuery();
                fillGrid();
                MessageBox.Show("Record Updated Successfully");
            }
        }
    }
}

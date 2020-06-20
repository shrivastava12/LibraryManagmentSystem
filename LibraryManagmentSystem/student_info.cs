using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LibraryManagmentSystem
{
    public partial class student_info : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=library_managment;Integrated Security=True");
        //string pwd;
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        public student_info()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if(result == DialogResult.OK) // Test result
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string img_path;
                string pwd = Class1.GetRandomPassword(20);
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jgp");

                img_path = "student_images\\" + pwd + ".jpg";

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into student_info values('" + txtsudentname.Text + "','" + img_path.ToString() + "','" + txtstudentenrollment.Text + "','" + txtstudentdept.Text + "','" + txtstudentsem.Text + "','" + txtsudentcontact.Text + "','" + txtsudentemail.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record insrted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
         }
    }
}

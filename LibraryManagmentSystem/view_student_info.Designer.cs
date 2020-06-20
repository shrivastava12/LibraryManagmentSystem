namespace LibraryManagmentSystem
{
    partial class view_student_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtstudent_email = new System.Windows.Forms.TextBox();
            this.txtstudent_sem = new System.Windows.Forms.TextBox();
            this.txtstudent_enroll = new System.Windows.Forms.TextBox();
            this.txtstudent_contact = new System.Windows.Forms.TextBox();
            this.txtstudent_dept = new System.Windows.Forms.TextBox();
            this.txtstudent_name = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 462);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtstudent_email);
            this.panel1.Controls.Add(this.txtstudent_sem);
            this.panel1.Controls.Add(this.txtstudent_enroll);
            this.panel1.Controls.Add(this.txtstudent_contact);
            this.panel1.Controls.Add(this.txtstudent_dept);
            this.panel1.Controls.Add(this.txtstudent_name);
            this.panel1.Location = new System.Drawing.Point(322, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 333);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enrollment No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtstudent_email
            // 
            this.txtstudent_email.Location = new System.Drawing.Point(786, 176);
            this.txtstudent_email.Name = "txtstudent_email";
            this.txtstudent_email.Size = new System.Drawing.Size(223, 22);
            this.txtstudent_email.TabIndex = 5;
            // 
            // txtstudent_sem
            // 
            this.txtstudent_sem.Location = new System.Drawing.Point(786, 124);
            this.txtstudent_sem.Name = "txtstudent_sem";
            this.txtstudent_sem.Size = new System.Drawing.Size(223, 22);
            this.txtstudent_sem.TabIndex = 4;
            // 
            // txtstudent_enroll
            // 
            this.txtstudent_enroll.Location = new System.Drawing.Point(786, 65);
            this.txtstudent_enroll.Name = "txtstudent_enroll";
            this.txtstudent_enroll.Size = new System.Drawing.Size(223, 22);
            this.txtstudent_enroll.TabIndex = 3;
            // 
            // txtstudent_contact
            // 
            this.txtstudent_contact.Location = new System.Drawing.Point(222, 176);
            this.txtstudent_contact.Name = "txtstudent_contact";
            this.txtstudent_contact.Size = new System.Drawing.Size(223, 22);
            this.txtstudent_contact.TabIndex = 2;
            // 
            // txtstudent_dept
            // 
            this.txtstudent_dept.Location = new System.Drawing.Point(222, 124);
            this.txtstudent_dept.Name = "txtstudent_dept";
            this.txtstudent_dept.Size = new System.Drawing.Size(223, 22);
            this.txtstudent_dept.TabIndex = 1;
            // 
            // txtstudent_name
            // 
            this.txtstudent_name.Location = new System.Drawing.Point(222, 70);
            this.txtstudent_name.Name = "txtstudent_name";
            this.txtstudent_name.Size = new System.Drawing.Size(223, 22);
            this.txtstudent_name.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 856);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view_student_info";
            this.Text = "view_student_info";
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtstudent_email;
        private System.Windows.Forms.TextBox txtstudent_sem;
        private System.Windows.Forms.TextBox txtstudent_enroll;
        private System.Windows.Forms.TextBox txtstudent_contact;
        private System.Windows.Forms.TextBox txtstudent_dept;
        private System.Windows.Forms.TextBox txtstudent_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
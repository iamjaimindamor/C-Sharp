using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Part3CRUD
{
    public partial class Form1 : Form
    {
        private DataClasses1DataContext dc;
        private List<Student> studs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ctrl as TextBox;
                    txt.Clear();
                }
            }
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connect to database    {by creating instance}
            dc = new DataClasses1DataContext();
            if (textBox1.ReadOnly == false)
            {
                //fetch the Student table from the Database
                Student stud = new Student();

                //Fetch the Column and pass value for entry....
                stud.Enrollment_Number = Int64.Parse(textBox1.Text);
                stud.Student_Name = textBox2.Text;
                stud.Department = textBox3.Text;
                stud.DOB = dateTimePicker1.Value;
                stud.Address = textBox4.Text;
                stud.Mobile_Number = Int64.Parse(textBox5.Text);
                stud.Blood_Group = textBox6.Text;

                //now pre submit state
                dc.Students.InsertOnSubmit(stud);

                //Commit the Changes to Database
                dc.SubmitChanges();

                //Prompt the user for successful transaction

                MessageBox.Show("Student Registered Successfully");
            }
            else
            {
                //fetch the Student table from the Database
                Student up_stud = dc.Students.SingleOrDefault(alias => alias.Enrollment_Number == Int64.Parse(textBox1.Text));

                //Fetch the Column and pass value for entry....
                up_stud.Enrollment_Number = Int64.Parse(textBox1.Text);
                up_stud.Student_Name = textBox2.Text;
                up_stud.Department = textBox3.Text;
                up_stud.DOB = dateTimePicker1.Value;
                up_stud.Address = textBox4.Text;
                up_stud.Mobile_Number = Int64.Parse(textBox5.Text);
                up_stud.Blood_Group = textBox6.Text;

                //Commit the Changes to Database
                dc.SubmitChanges();

                //Prompt the user for successful transaction
                MessageBox.Show("Student Details UPDATED Successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
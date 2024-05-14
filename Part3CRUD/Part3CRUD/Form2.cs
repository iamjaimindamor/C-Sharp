using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Part3CRUD
{
    public partial class Form2 : Form
    {
        private DataClasses1DataContext dc2;
        private List<Student> studs;

        public Form2()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dc2 = new DataClasses1DataContext();

            this.studentTableAdapter.Fill(this.collegeDBDataSet.Student);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
            dc2 = new DataClasses1DataContext();

            dataGridView1.DataSource = dc2.Students.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.collegeDBDataSet.Student);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form1 f1 = new Form1();

                f1.textBox1.ReadOnly = true;
                f1.button1.Text = "Update";
                f1.button2.Enabled = false;

                f1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                f1.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                f1.textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                f1.textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                f1.dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                f1.textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                f1.textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                f1.textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                f1.ShowDialog();
                LoadData();

                //refresh the gridview
                f1.textBox1.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Entry Not Selected!!!");
            }
            //prompt the admin
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //get the selected value from the DataGridView
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                    dc2 = new DataClasses1DataContext();
                    //Create new obj od existing data to make any changes
                    Student st = dc2.Students.SingleOrDefault(b => b.Id == id);

                    //selected obj will deleted by calling DeleteOnSubmit Method
                    dc2.Students.DeleteOnSubmit(st);

                    //Commit the changes
                    dc2.SubmitChanges();
                    LoadData();

                    MessageBox.Show("Student Details Deleted");
                }
            }
        }
    }
}
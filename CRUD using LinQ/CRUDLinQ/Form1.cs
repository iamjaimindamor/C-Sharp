using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLinQ
{
    public partial class Form1 : Form
    {
        List<Employee> emp;
        DataClasses1DataContext data;
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            data = new DataClasses1DataContext();
           
            dataGridView1.DataSource= data.Employees;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.companyDBDataSet.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            data = new DataClasses1DataContext();
            emp= data.Employees.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Are You Sure You Want To Delete ?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {   
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()); 
                    String name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                    Employee obj_del = data.Employees.SingleOrDefault(AN => AN.Ename == name);
                    data.Employees.DeleteOnSubmit(obj_del);
                    data.SubmitChanges();
                    LoadData();
                }


            }else
            {
                MessageBox.Show("Please Select the Record To Delete . ");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();  
            f.ShowDialog();  
            LoadData();


        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               

                Form2 form2 = new Form2();
                form2.textBox6.ReadOnly = true;
                form2.button2.Enabled = false;
                form2.button1.Text = "Update";
                form2.textBox6.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                form2.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                form2.textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                form2.textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                form2.textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                form2.textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                form2.ShowDialog();
                LoadData();
              
            }
            else
            {
                MessageBox.Show("Row Not Selected");
            }


          
             
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            if(textBox6.ReadOnly == false) {
                Employee obj = new Employee();
                //obj.Id = int.Parse(textBox6.Text);
                obj.Ename = textBox1.Text;
                obj.EAddress = textBox2.Text;
                obj.EDepartment = textBox3.Text;
                obj.EDesignation = textBox4.Text;
                obj.Salary = int.Parse(textBox5.Text);
                dc.Employees.InsertOnSubmit(obj); //PENDING SUBMIT STATE
                dc.SubmitChanges(); //COMMIT THE DATA
                MessageBox.Show("Record Inserted");
            }
            else 
            { 
                textBox6.ReadOnly = false;
                Employee obj1 = dc.Employees.FirstOrDefault(x => x.Id == Convert.ToInt32(textBox6.Text));

                obj1.Ename = textBox1.Text; 
                obj1.EAddress = textBox2.Text; 
                obj1.EDepartment = textBox3.Text;
                obj1.EDesignation = textBox4.Text;
                obj1.Salary = int.Parse(textBox5.Text);

                dc.SubmitChanges();

                MessageBox.Show("Record Updated");
               



            }
           
        }

       public void button2_Click_1(object sender, EventArgs e)
        {
            foreach(Control ctrl in Controls) 
            {
                if(ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
                textBox1.Focus();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

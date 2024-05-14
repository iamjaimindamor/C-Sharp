using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        DataClasses1DataContext dc;
        List<Employee> emps;
        int rno = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dc = new DataClasses1DataContext();
            emps =  dc.Employees.ToList();
            ShowData();

        }
        private void ShowData()
        {
            textBox1.Text = emps[rno].Id.ToString();
            textBox2.Text = emps[rno].Ename.ToString();
            textBox3.Text = emps[rno].EAddress.ToString();
            textBox4.Text = emps[rno].EDepartment.ToString();
            textBox5.Text = emps[rno].EDesignation.ToString();
            textBox6.Text = emps[rno].Salary.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rno > 0)
            {
                rno -= 1;
                ShowData();
            }
            else MessageBox.Show("First Record Of The Table");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(rno < emps.Count-1) 
            {
                rno += 1;
                ShowData();
            }
            else
            {
                MessageBox.Show("No More Records");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

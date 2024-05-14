namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "done";
            b.Size = new Size(100, 50);
            b.Location = new Point(300, 200);
            this.Controls.Add(b);

            b.Click += delegate
            {
                MessageBox.Show("Hello World");
            };
            
           }
        }
    }



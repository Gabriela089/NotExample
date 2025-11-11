using School.Controllers;

namespace School
{
    public partial class Form1 : Form
    {
        public PPMG_Controller PPMG_Controller { get; set; }
        public Form1()
        {
            InitializeComponent();
            PPMG_Controller = new PPMG_Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age =int.Parse( textBox2.Text);
            string subject = textBox1.Text;
            PPMG_Controller.AddTeacher(name, age, subject);

        }
    }
}

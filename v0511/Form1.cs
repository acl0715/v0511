using System.DirectoryServices.ActiveDirectory;

namespace v0511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("こんにちはー！！！");
            button1.Text = "推された";
            button1.Left = 0;
            button2.Visible = false;
            button2.BackColor = Color.Gray;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
    }
}
namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the ename frin the text
            string name = nsmeTextBox.Text;

            helloLabel.Text = "Hello, " + name;
        }

    }
}
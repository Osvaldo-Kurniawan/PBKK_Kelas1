namespace Kuliah1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            String FirstName = textBox1.Text;
            String LastName = textBox2.Text;

            // Create a formatted string with a newline character to split the text into multiple lines
            string salamText = "Hello \n" + FirstName + " " + LastName;

            // Set the label's text to the formatted string
            Salam.Text = salamText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Salam.Text = "";
        }
    }
}
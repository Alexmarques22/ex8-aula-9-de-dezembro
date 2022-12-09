namespace ex2_aula_9dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "o nome é comom";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "o nome é deferente";
        }
    }
}
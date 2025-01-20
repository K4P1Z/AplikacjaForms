namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2();
            from.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 from = new Form3();
            from.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 from = new Form4();
            from.Show();
        }
    }
}

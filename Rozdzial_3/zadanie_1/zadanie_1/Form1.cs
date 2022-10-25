namespace zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.Blah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("D³ugoœæ wiadomoœci to: " + len);
        }
    }
}
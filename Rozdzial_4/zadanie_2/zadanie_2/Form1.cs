namespace zadanie_2
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        public Form1()
        {
            InitializeComponent();

            lloyd = new Elephant() { Name = "Lloyd", EarSize = 33 };
            lucinda = new Elephant() { EarSize = 40, Name = "Lucinda" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Zamiana udana");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
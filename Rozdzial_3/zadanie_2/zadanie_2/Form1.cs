namespace zadanie_2
{
    public partial class Form1 : Form
    {
        Guy joe = new Guy() { Cash = 100, Name = "Joe" };
        Guy bob = new Guy() { Cash = 50, Name = "Bob"};
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " z³";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " z³";
            bankCashLabel.Text = "Bank ma " + bank + " z³";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilosci pieniêdzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.Cash += joe.GiveCash(10);
            UpdateForm();
        }

        private void bobGivestoJoe_Click(object sender, EventArgs e)
        {
            
            joe.Cash += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
namespace zadanie_2
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuj� {0} work�w paszy do wykarmienia {1} kr�w",
            farmer.BagsOfFeed, farmer.NumberOfCows);
        }
    }
}
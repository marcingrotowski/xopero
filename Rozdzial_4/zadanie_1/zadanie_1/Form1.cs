namespace zadanie_1
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate = 0.39, amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private string button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = amountOwed.ToString() + " z�";
            }
            else
            {
                MessageBox.Show("Pocz�tkowa i ko�cowa warto�� nie mo�e by� r�wna 0");
            }
        }
    }
}
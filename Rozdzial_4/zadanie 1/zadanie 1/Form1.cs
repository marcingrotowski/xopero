namespace zadanie_1
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate = 0.39, amountOwed;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled.ToString() + " mil", "Przebyta odleg³oœæ");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)startingMiles.Value;
            endingMileage = (int)endingMiles.Value;
                if (endingMiles.Value > startingMiles.Value)
                {
                    milesTraveled = endingMileage - startingMileage;
                    amountOwed = milesTraveled * reimburseRate;
                    label4.Text = amountOwed.ToString() + " z³";
                    }
                else
                    {
                    MessageBox.Show("Pocz¹tkowa wartoœæ nie mo¿e byæ wiêksza od koñcowej",
                    "Nie mogê obliczyæ odleg³oœci");
                    }
        }
    }
}
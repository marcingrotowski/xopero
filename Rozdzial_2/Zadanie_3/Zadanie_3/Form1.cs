namespace Zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                if (enableCheckbox.Checked == true)
                {
                    if (labelToChange.Text == "Z prawej")
                    {
                        labelToChange.Text = "Z lewej";
                        labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        labelToChange.Text = "Z prawej";
                        labelToChange.TextAlign = ContentAlignment.MiddleRight;
                    }
                }
                else
                {
                    labelToChange.Text = "Mozliwo�� zmiany tekstu zosta�a wy��czona";
                    labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
            }
    }
}
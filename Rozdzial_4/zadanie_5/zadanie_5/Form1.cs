namespace zadanie_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void toggleBouncing(int index, Label labelToBounce)
        {
            if (bouncers[index] == null)
            {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labelToBounce;
            }
            else
            {
                bouncers[index] = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toggleBouncing(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toggleBouncing(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toggleBouncing(2, label3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i< 3; i++)
            {
                if (bouncers[i] != null)
                {
                    bouncers[i].Move();
                }
            }
        }
    }
}
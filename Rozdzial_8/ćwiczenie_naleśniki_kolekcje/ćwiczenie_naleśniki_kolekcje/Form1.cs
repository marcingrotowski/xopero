namespace ćwiczenie_naleśniki_kolekcje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }

        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if(breakfastLine.Count == 0)
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Chrupkiego;
            else if (soggy.Checked == true)
                food = Flapjack.Wilgotnego;
            else if (browned.Checked == true)
                food = Flapjack.Rumianego;
            else
                food = Flapjack.Bananowego;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if(breakfastLine.Count == 0)
            {
                Lumberjack newLumberjack = breakfastLine.Dequeue();
                nextLumberjack.EatFl
            }
        }
    }
}
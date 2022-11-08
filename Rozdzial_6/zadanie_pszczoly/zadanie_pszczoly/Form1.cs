namespace zadanie_pszczoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" }, 175);
            workers[1] = new Worker(new string[] { "Pielêgnacja jaj", "Nauczanie pszczó³ek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ¿¹d³ami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielêgnacja jaj", "Nauczanie pszczó³ek", "Utrzymywanie ula", "Patrol z ¿¹d³ami"},155);
            queen = new Queen(workers, 275);
        
        }

        private Queen queen;

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dostêpnych robotnic do wykonania zadania");
            else
                MessageBox.Show("Zadanie przypisane");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
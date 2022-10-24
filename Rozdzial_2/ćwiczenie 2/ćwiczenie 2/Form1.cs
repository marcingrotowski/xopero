namespace ćwiczenie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int i = 0; i <= 254 && Visible; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }

                for (int i = 254; i >= 0 && Visible; i--)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
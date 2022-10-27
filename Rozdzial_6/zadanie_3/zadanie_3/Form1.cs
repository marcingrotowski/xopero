using System.Security.Cryptography.X509Certificates;

namespace zadanie_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBaseClass mybaseclass = new MyBaseClass("a");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySubClass mysubclass = new MySubClass("a", 4);
        }
    }
}
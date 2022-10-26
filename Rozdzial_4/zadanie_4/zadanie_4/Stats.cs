using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_4
{
    internal class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            if (correctKey)
            {
                Total++;
            }
            else
            {
                Missed++;
            }

            Accuracy = 100 * Correct / Total;
        }
    }
}

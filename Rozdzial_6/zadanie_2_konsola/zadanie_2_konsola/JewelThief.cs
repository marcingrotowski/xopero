using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_2_konsola;

namespace zadanie_2_konsola
{
    internal class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Kradne zawartosc sejfu" + stolenJewels.Sparkle());
        }
    }
}

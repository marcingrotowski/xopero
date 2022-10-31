using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_interfejsy_konsola
{
    internal class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Cześć dzieciaki! Mam " + funnyThingIHave; }
        }
        public void Honk()
        {
            Console.WriteLine(this.funnyThingIHave);
        }
    }
}

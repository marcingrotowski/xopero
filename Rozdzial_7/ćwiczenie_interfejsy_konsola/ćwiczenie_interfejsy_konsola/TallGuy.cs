using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_interfejsy_konsola
{
    internal class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public string FunnyThingIHave { get { return "duże buty"; } }

        public void Honk()
        {
            Console.WriteLine("tut tut");
        }
        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " cm wzrostu");
        }
    }
}

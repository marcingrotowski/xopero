using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_xaml_kanapki
{
    internal class MenuItem
    {
        public string Meat { get; private set; }
        public string Condiments { get; private set; }
        public string Bread { get; private set; }

        public MenuItem(string meat, string condiments, string bread)        {
            Meat = meat;
            Condiments = condiments;
            Bread = bread;
        }

        public override string ToString()
        {
            return Meat + ", " + Condiments + ", " + Bread;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    internal class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {
            MessageBox.Show("to jest klasa pochodna: " + baseClassNeedsThis + " i " + anotherValue);
        }
    }
}

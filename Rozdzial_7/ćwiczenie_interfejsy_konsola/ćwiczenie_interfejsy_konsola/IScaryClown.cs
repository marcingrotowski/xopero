using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_interfejsy_konsola
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }
}

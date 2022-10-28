using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_konsola_interfejsy
{
    internal interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}

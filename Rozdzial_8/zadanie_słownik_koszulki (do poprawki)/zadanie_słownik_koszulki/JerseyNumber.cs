﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_słownik_koszulki
{
    internal class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int numberRetired)
        {
            Player = player;
            YearRetired = numberRetired;
        }   
    }
}

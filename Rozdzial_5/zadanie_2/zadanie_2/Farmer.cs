﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_2
{
    internal class Farmer
    {
        public int BagsOfFeed;
        public const int FeedMultiplier = 30;

        private int numberOfCows;
        public int NumberOfCows
        {
            get { 
                return numberOfCows; 
            }
            set { 
                numberOfCows = value; 
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}

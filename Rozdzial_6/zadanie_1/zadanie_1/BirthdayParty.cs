﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize() {
            if (NumberOfPeople <= 4)
                return 20;
            else
                return 40;
        }
        private int MaxWritingLength() {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        private decimal CalculateCostOfDecoration()
        {
            decimal costOfDecoration;
            if (FancyDecorations)
                costOfDecoration = (NumberOfPeople * 15.00M) + 50.00M;
            else
                costOfDecoration = (NumberOfPeople * 7.50M) + 30.00M;
            return costOfDecoration;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 20)
                    cakeCost = 40 + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}

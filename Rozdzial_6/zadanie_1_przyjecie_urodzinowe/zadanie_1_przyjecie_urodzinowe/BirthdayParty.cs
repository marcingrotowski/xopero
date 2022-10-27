using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_przyjecie_urodzinowe
{
    internal class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberoOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }
        public BirthdayParty(int numberoOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberoOfPeople = numberoOfPeople;
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

        private int CakeSize()
        {
            if (NumberoOfPeople <= 4)
                return 20;
            else
                return 40;
        }

        private int MaxWritingLength()
        {
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

        private decimal CalculationCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberoOfPeople * 15.00M) + 50.00M;
            else
                costOfDecorations = (NumberoOfPeople * 7.50M) + 30.00M;
            return costOfDecorations;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculationCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberoOfPeople;

                decimal cakeCost;
                if (CakeSize() == 20)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}

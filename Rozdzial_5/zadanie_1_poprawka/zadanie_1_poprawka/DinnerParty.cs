using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_poprawka
{
    internal class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecoration()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
            return costOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (!HealthyOption)
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            return costOfBeveragesPerPerson;
        }
        
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}

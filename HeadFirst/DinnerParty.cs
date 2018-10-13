using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public int CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool isOn)
        {
            if (isOn)
            {
                CostOfBeveragesPerPerson = 5;
            }
            else
            {
                CostOfBeveragesPerPerson = 20;
            }
        }

        public void CalculateCostOfDecorations(bool isFantasy)
        {
            if (isFantasy)
            {
                CostOfDecorations = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            }
        }

        public decimal CalculateCost(bool isOn, bool isFantasy)
        {
            SetHealthyOption(isOn);
            CalculateCostOfDecorations(isFantasy);
            
            decimal cost = CostOfFoodPerPerson * NumberOfPeople +
                       CostOfBeveragesPerPerson * NumberOfPeople +
                       CostOfDecorations;

            if (isOn)
            {
                return cost * .95M;
            }
            else
            {
                return cost;
            }
        }

    }
}

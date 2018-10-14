using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    class DinnerParty
    {
        private int numberOfPeople;
        private int costOfBeveragesPerPerson;
        private decimal costOfDecorations;
        private const int costOfFoodPerPerson = 25;

        public void SetCostOfBeveragesPerPerson(bool isOn)
        {
            if (isOn)
            {
                costOfBeveragesPerPerson = 5;
            }
            else
            {
                costOfBeveragesPerPerson = 20;
            }
        }

        public void SetCostOfDecorations(bool isFantasy)
        {
            if (isFantasy)
            {
                costOfDecorations = (numberOfPeople * 15M) + 50M;
            }
            else
            {
                costOfDecorations = (numberOfPeople * 7.5M) + 30M;
            }
        }



    public decimal CalculateCost(bool isHealthy, bool isFantasy, int numberOfPeople)
        {
            this.numberOfPeople = numberOfPeople;
            SetCostOfBeveragesPerPerson(isHealthy);
            SetCostOfDecorations(isFantasy);
            
            decimal cost = costOfFoodPerPerson * this.numberOfPeople +
                       costOfBeveragesPerPerson * this.numberOfPeople +
                       costOfDecorations;

            if (isHealthy)
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

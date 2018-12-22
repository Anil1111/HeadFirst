using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        override public decimal Cost
        {
            get {
                decimal totalCost = base.Cost;
                int CostOfBeveragesPerPerson = HealthyOption ? 5 : 20;
                CostOfDecorations = FancyDecorations ? (NumberOfPeople * 15M) + 50M 
                                                     : (NumberOfPeople * 7.5M) + 30M;

                totalCost = CostOfFoodPerPerson * NumberOfPeople +
                           CostOfBeveragesPerPerson * NumberOfPeople +
                           CostOfDecorations;

                if (HealthyOption)
                    return totalCost * .95M;
                else
                    return totalCost;
            }        
        }

    }
}

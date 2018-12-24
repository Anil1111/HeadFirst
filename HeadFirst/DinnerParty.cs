using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//todo checking healthy option rises the cost
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

                totalCost = CostOfFoodPerPerson * NumberOfPeople +
                           CostOfBeveragesPerPerson * NumberOfPeople +
                           CostOfDecorations;
                
                return HealthyOption ? (totalCost * 0.95M) : totalCost;
            }        
        }

    }
}

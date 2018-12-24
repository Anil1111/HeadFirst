using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//todo checking fancy decorations lowers the price 
namespace HeadFirst
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal CostOfDecorations {
            get
            {
               return FancyDecorations ? (NumberOfPeople * 15M) + 50M : (NumberOfPeople * 7.5M) + 30M;
            }
         }
        public virtual decimal Cost { get
            {
                return CostOfDecorations;
            }
        }
    }
}

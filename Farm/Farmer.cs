using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        // this is long version
        //private readonly int feedMultiplier;
        //public int FeedMultiplier { get { return feedMultiplier; } }
        // but IDE proposed auto property
        public int FeedMultiplier { get; }

        //long version here also
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }


        public Farmer(int numberOfCows, int feedMultiplier)
        {
            // in long version we would've use this.feedMultiplier
            FeedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}

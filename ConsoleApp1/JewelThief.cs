using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I am stealling! " + stolenJewels.Sparkle());
        }
    }
}

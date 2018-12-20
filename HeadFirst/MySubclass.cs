using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    public class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {

        }
        
    }
}

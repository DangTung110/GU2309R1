using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: T111111111111!";
        }
        public string HowToEat()
        {
            return "Thoc";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro2
{
    class Robot
    {
        public Robot() { }
        public int Person_Robot()
        {
            Random rd = new Random();
            int number = rd.Next(1,10);
            return number;
        }
    }
}

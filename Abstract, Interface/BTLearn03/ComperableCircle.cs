using BTLearn0203;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn0203
{
    internal class ComperableCircle : Circle, IComparable<ComperableCircle> // Icomparable đã có trong thư viện system
    {
        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(string color, bool filled, double radius) : base(color, filled, radius) { }
        public int CompareTo(ComperableCircle o)
        {
            if (Radius > o.Radius) return 1;
            else if (Radius < o.Radius) return -1;
            else return 1;
        }
    }
}

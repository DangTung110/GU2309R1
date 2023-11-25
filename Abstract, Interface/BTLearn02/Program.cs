using BTLearn0203;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BTLearn0203.CircleComparer;

namespace BTLearn0203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ComperableCircle> circles = new List<ComperableCircle>();
            circles.Add(new ComperableCircle(3.6));
            circles.Add(new ComperableCircle(2));
            circles.Add(new ComperableCircle("Yellow", false, 3.4));

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }
            
            circles.Sort(); // Sắp xếp các phần tử trong list
            //IComparer<Circle> circleComparator = new CircleComparator();
            //circles.Sort(circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadKey();
        }
    }
}

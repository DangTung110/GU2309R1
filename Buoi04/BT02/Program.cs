using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float RATE = 23000;
            float vnd, usd;

            Console.WriteLine("Enter USD: ");
            usd = float.Parse(Console.ReadLine());

            vnd = usd * RATE;

            Console.WriteLine(usd + "USD = " + vnd + "VND");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hight = -1, weigh = -1, bmi;

            Console.Write("Please enter your hight: ");
            hight = double.Parse(Console.ReadLine());

            Console.Write("Please enter your weigh: ");
            weigh = float.Parse(Console.ReadLine());

            bmi = weigh / Math.Pow(hight, 2);
            bmi = Math.Round(bmi, 1);

            Console.WriteLine("BMI: {0}", bmi);

            if (bmi < 18.0 && bmi > 0) Console.WriteLine("Underwight!");
            else if (bmi < 25.0) Console.WriteLine("Normal!");
            else if (bmi < 30.0) Console.WriteLine("Overigh!");
            else Console.WriteLine("Obese!");

            return;
        }
    }
}

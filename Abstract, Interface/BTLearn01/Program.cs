using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Tiger());
            animals.Add(new Chicken());
            //Console.WriteLine(string.Join(" ", animals));

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    Chicken c = (Chicken) animal;
                    Console.WriteLine(c.HowToEat());

                    Edible edibler = (Chicken)animal;     // interface Edible
                    Console.WriteLine(edibler.HowToEat());
                }
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }

            Console.ReadKey();
        }
    }
}

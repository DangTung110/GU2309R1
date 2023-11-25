using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn02
{
    internal class Cat : Animal
    {
        private string name;
        public Cat(string height, string weight, string name = "No Name") : base (height, weight)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.weight, this.height, this.Name);
        }
        ~Cat() { }
    }
}

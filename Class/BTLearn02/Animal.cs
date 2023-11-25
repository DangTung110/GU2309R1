using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn02
{
    internal abstract class Animal
    {        
        protected string weight;
        protected string height;
        protected string Weight { get => weight; set => weight = value; }
        protected string Hight { get => height; set => height = value; }
        public Animal(string weight = "0", string hight = "0")
        {
            this.weight = weight;
            this.height = hight;
        }
        public abstract void PrintInfo();
        ~Animal() { }
    }
}

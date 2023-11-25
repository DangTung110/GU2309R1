using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn04
{
    internal class Fan
    {
        private int speed;
        private bool on;
        private double radius;
        private string color;

        public Fan(int speed = 1, bool on = false, double radius = 5, string color = "blue")
        {
            this.speed = speed;
            this.On = on;
            this.Radius = radius;
            this.Color = color;
        }
        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public override string ToString()
        {
            if (this.on) return string.Format("Speed: {0} | Color: {1}| Radius: {2} | fan is on!", speed, color, radius) ;
            return string.Format("Color: {0} | Radius: {1} | fan is off!",color, radius);
        }
        ~Fan() { }
    }
}

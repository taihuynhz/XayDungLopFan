using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungLopFan
{
    class Programs
    {
        static void Main(string[] args)
        {
            Fan Fan1 = new Fan(3, true, 10, "yellow");
            Fan Fan2 = new Fan(2, false, 5, "blue");

            Console.WriteLine(Fan1.ToString());
            Console.WriteLine(Fan2.ToString());
        }
    }

    public class Fan
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;

        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public Fan(int speed, bool on, double radius, string color)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }

        public override String ToString()
        {
            return "Speed" + (speed == SLOW ? " SLOW" : speed == MEDIUM ? " MEDIUM" : speed == FAST ? " FAST" : " NULL") + ", radius " + radius + ", color " + color + (on == true ? ", Fan is on" : ", Fan is off");
        }
    }
}

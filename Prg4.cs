using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Prg4
    {
        static void Main(string[] args)
        {
            fan Fan1 = new fan(10, true ,10, "yellow");
            Console.WriteLine(Fan1.ToString());
            fan Fan2 = new fan(5, false, 5, "blue");
            Console.WriteLine(Fan2.ToString());
        }

    } 
    class fan
    {
      
         int SLOW = 1, HEIGHT = 2, MEDIUM = 3;
        
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

       

        public fan(int speed , bool on, double radius, string color)
        {
            this.Speed=speed;
            this.On=on;
            this.Radius = radius;
            this.Color = color;
        }

       

        public override string ToString( )
        {
            if (on == true)
            {
                return string.Format ("({0}, {1} ,{2})",color, radius , speed);
                Console.WriteLine("fan is on");
            }
            else
            {
                return string.Format("({0}, {1})" ,color, radius);
                Console.WriteLine("fan is off");
            }

        }
    }
}

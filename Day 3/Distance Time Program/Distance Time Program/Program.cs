using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Time_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance, speed, time,displacement;
            Console.WriteLine("Enter the distance");
            distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            time = double.Parse(Console.ReadLine());
            speed = calcspeed(distance, time);
            displacement = caldisp(distance, time);
            Console.WriteLine("speed in km/hr and m/hr is {0} and {1}", speed, displacement);
        }
        static double calcspeed(double distance, double time)
        {
            double s=distance/time;
            return s;
        }
        static double caldisp(double distance, double time)
        {
            double d=(distance/time)*0.62;
            return d;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai3
    {
        public static void CheckAPoint()
        {
            Console.WriteLine("xC, yC");
            double xC = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("xM, yM");
            double xM = double.Parse(Console.ReadLine());
            double yM = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(xM - xC, 2) + Math.Pow(yM - yC, 2));
            if(distance < radius) Console.WriteLine("Point M in the circle");
            if(distance == radius) Console.WriteLine("Point M on the circle");
            if(distance > radius) Console.WriteLine("Point M out the circle");

        }
    }
}

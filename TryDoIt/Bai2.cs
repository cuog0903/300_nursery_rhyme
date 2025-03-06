using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai2
    {
        public static void CalculateDistance()
        {
            Console.Write("A(xA, yA): ");
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            Console.Write("B(xB, yB): ");
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            Console.WriteLine(distance);
        }
    }
}

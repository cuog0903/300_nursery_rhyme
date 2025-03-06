using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai1
    {
        public static void CalculateVolume()
        {
            Console.Write("Enter the area S of a sphere: ");
            double pi = 3.141593;
            double area = double.Parse(Console.ReadLine());
            double radius = Math.Sqrt(area / (4 * pi));
            double volume = area * radius / 3;
            Console.WriteLine(volume);
        }

    }
}

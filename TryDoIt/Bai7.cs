using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai7
    {
        //Viet chuong trinh giai phuong trinh bac 1
        public static void SolveFirstDegreeEquations()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a != 0) Console.WriteLine($"Phuong trinh co 1 nghiem  x = {-b / a}");
            else if (b == 0) Console.WriteLine("Phuong trinh co vo so nghiem");
            else Console.WriteLine("Phuong trinh vo nghiem");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai8
    {
        //Viet chuong trinh giai phuong trinh bac hai
        public static void SolveQuadraticEquations()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0) SolveFirstDegreeEquations(b, c);//Suy biến thành phương trình bậc nhất
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if(delta > 0) Console.WriteLine($"Phuong trinh co hai nghiem rieng biet x1 = {(- b + Math.Sqrt(delta)) / (2 * a)}, x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
                else if(delta == 0) Console.WriteLine($"Phuong trinh co nghiem kep x1 = x2 = {-b / (2 * a)}");
                else Console.WriteLine($"Phuong trinh vo nghiem");

            }
            //Giai phuong trinh bac nhat
        }
        private static void SolveFirstDegreeEquations(double a, double b)
        {
            if (a != 0) Console.WriteLine($"Phuong trinh co 1 nghiem  x = {-b / a}");
            else if (b == 0) Console.WriteLine("Phuong trinh co vo so nghiem");
            else Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    public class Bai12
    {
        //Viet chuong trinh giai he phuong trinh 2 an
        public static void SolveTwoVariableSystemEquations()
        {
            Console.WriteLine("Enter the coefficients: ");
            Console.Write("Enter a1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Enter b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Enter c1: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Enter b2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("Enter c2: ");
            double c2 = double.Parse(Console.ReadLine());
            //Cong thuc Cramer tinh he phuong trinh hai an
            double d = a1 * b2 - a2 * b1;
            double dx = c1 * b2 - c2 * b1;
            double dy = a1 * c2 - a2 * c1;
            if(d != 0)
            {
                Console.WriteLine($"The System Equations has unique solution: x = {dx/d} and y = {dy/d}");
            }else
            {
                if(dx == 0 && dy == 0) Console.WriteLine("The system of equations with infinite solutions");
                else Console.WriteLine("The system of equations with no solutions");
            }


        }
        
    }
}

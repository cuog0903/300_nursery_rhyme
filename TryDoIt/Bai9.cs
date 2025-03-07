using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai9
    {
        public static void PlayWithTrigonometricCircle()
        {
            Console.Write("Enter x: ");
            double x;
            if(double.TryParse(Console.ReadLine(), out x))
            {
                //Doi tu phut ra do
                double degree = x / 60;
                int numberRightAngle = (int)Math.Ceiling(degree / 90) % 4;
                Console.WriteLine($"x thuoc goc vuong thu: {numberRightAngle}");
                Console.WriteLine($"cos(x) = {Math.Cos(Math.PI * degree / 180)}");

            }else Console.WriteLine("Ban dang khong nhap vao 1 so");
            
            

        }
    }
}

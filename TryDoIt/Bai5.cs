using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai5
    {
        //Challenge: Nhap vao toa do 3 dinh cua tam giac va 1 diem M, xac dinh diem M nam trong, tren hay ngoai tam giac ABC
        //Giai pháp: Nhập vào 3 đinh, kiểm tra xem 3 đỉnh có thẳng hàng hay không?--> nếu không mới tạo thành 1 tam giác
        //Tính diện tích các hình vuông: ABC, MAC, MAB, MBC, so sánh diện tích các hình để biết vị trí điểm M so với tam giác ABC
        public static void CheckPointWithTriangle()
            
        {
            Console.WriteLine("Toa do diem A(xA, yA)");
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Toa do diem B(xB, yB)");
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            Console.WriteLine("Toa do diem A(xC, yC)");
            double xC = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem M(xM, yM)");
            double xM = double.Parse(Console.ReadLine());
            double yM = double.Parse(Console.ReadLine());
            double edgeAB = CalculateDistance(xA, yA, xB, yB);
            double edgeAC = CalculateDistance(xA, yA, xC, yC);
            double edgeBC = CalculateDistance(xB, yB, xC, yC);
            double distanceAM = CalculateDistance(xA, yA, xM, yM);
            double distanceBM = CalculateDistance(xB, yB, xM, yM);
            double distanceCM = CalculateDistance(xC, yC, xM, yM);
            //Kiem tra xem 3 diem cua nhap cao tao thanh 1 tam giac hay khong

            if(edgeAB != edgeAC + edgeBC || edgeAC != edgeAB + edgeBC || edgeBC != edgeAB + edgeAC)
            {
                //TInh dien tich cac tam giac
                double areaABC = CalculateAreaATriangle(edgeAB, edgeAC, edgeBC);
                double areaABM = CalculateAreaATriangle(edgeAB, distanceAM, distanceBM);
                double areaACM = CalculateAreaATriangle(edgeAC, distanceAM, distanceCM);
                double areaBCM = CalculateAreaATriangle(edgeBC, distanceBM, distanceCM);
                if(areaABC == (areaABM + areaACM + areaBCM))
                {
                    Console.WriteLine("M nam trong tam giac ABC");
                    return;
                }   
                    
                if(areaABM == 0 || areaACM == 0 || areaBCM == 0)
                {
                    Console.WriteLine("M nam tren canh tam giac ABC");
                    return;
                }
                    
                Console.WriteLine("M nam ngoai tam giac ABC");
               
            }else
                Console.WriteLine("Three point enter form a Line, not form a triangle");

        }
        public static double CalculateDistance(double xA, double yA, double xB, double yB)
        {
            return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
        }
        public static double CalculateAreaATriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static double CalculateAreaATriangleV2(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            return 0.5 * Math.Abs(xA * (yB - yC) + xB * (yA - yC) + xC * (yA - yB) );
        }
    }
}

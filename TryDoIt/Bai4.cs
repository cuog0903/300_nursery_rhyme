using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai4
    {
        public static void CheckATriangle()
        {
            double edgeA = double.Parse(Console.ReadLine()); //Chieu dai canh A
            double edgeB = double.Parse(Console.ReadLine());//Chieu dai canh B
            double edgeC = double.Parse(Console.ReadLine());//Chieu dai canh C
            //Dieu kien de 3 canh tro thanh 3 canh cua mot tam giac la: Tong cua hai canh bat ky phai lon hon canh con lai
            if((edgeA > 0 && edgeB > 0 && edgeC > 0) && (edgeA + edgeB > edgeC || edgeA + edgeC > edgeB || edgeC + edgeB > edgeA))
            {
                //Co 4 tam giac dac biet: tam giac can, tam giac deu, tam giac vuong, tam giac vuong can
                int flag = 0;
                if (edgeA == edgeB || edgeA == edgeC || edgeB == edgeC) flag += 1; //Xet dieu kien tam giac can
                if (edgeA == edgeB && edgeB == edgeC) flag += 1;//Xet dieu kien tam giac la tam giac deu (muon deu thi phai can truoc da)
                //Kiem tra dieu kien tam giac vuong theo cong thuc pitago
                if (edgeA == Math.Sqrt(Math.Pow(edgeB, 2) + Math.Pow(edgeC, 2)) || edgeB == Math.Sqrt(Math.Pow(edgeC, 2) + Math.Pow(edgeA, 2)) || edgeC == Math.Sqrt(Math.Pow(edgeB, 2) + Math.Pow(edgeA, 2))) flag += 3;
                switch(flag)
                {
                    case 0:
                        Console.WriteLine("The triangle is nomal triangle");
                        break;
                    case 1:
                        Console.WriteLine("The triangle is Isosceles triangle");
                        break;
                    case 2: //Muon la tam giac deu truoc tien no phaila tam giac can (len flag moi bang 2)
                        Console.WriteLine("The triangle is equilateral triangle");
                        break;
                    case 3: //Thoa mna cong thuc pitago thi la tam giac vuong
                        Console.WriteLine("The triangle is right triangle");
                        break;
                    case 4://Tam giac vuong can (can flag + 1, vuong flag + 3 tong bang 4)
                        Console.WriteLine("The triangle is Isosceles and right triangle");
                        break;
                }
                //Tinh dien tich tam giac: su dung cong thuc heron
                double p = (edgeA + edgeB + edgeC) / 2; //Tinh nua chu vi cua tam giac
                double s = Math.Sqrt(p * (p - edgeA) * (p - edgeB) * (p - edgeC));
                Console.WriteLine($"Area of the triangle is: {s} ");


            }else
                Console.WriteLine("The edges enter not form a triangle");
        }



    }
}  


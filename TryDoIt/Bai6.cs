using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TryDoIt
{
    class Bai6
    {
        //Viet mot chuong trinh nhap vaoi 3 so nguyen sau do in ra man hinh 3 so theo thu tu tang dan
        public static void SortNumber()
        {
            //Nhap[ vao 3 so nguyen tu ban phim
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b) SwapNumber(ref a, ref b); //Sau lenh nay thi a >= b;
            if (a < c) SwapNumber(ref a, ref c); //Sau cau lenh nay thi a tro thanh so lon nhat
            if (b < c) SwapNumber(ref b, ref c); //Sau lenh nay thi c thanh so nho nhat
            Console.WriteLine($"Tang dan: {c} {b} {a}");
        }
        //Viet ham swap hai so
        private static void SwapNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
}

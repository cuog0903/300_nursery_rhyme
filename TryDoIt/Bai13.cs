using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    public class Bai13
    {
        public static void CheckDateMothYear()
        {
            //Viết chương trình nhập vào ngày tháng năm, kiểm tra ngày và tháng nhập có hợp lệ hay
            //Tính thứ trong tuần của ngày đó
            int d, month, year, topDay = 0, DayOfWeek;
            Console.Write("Nhap vao ngay: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao nam: ");
            year = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    topDay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    topDay = 30;
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0) topDay = 29;
                    else topDay = 28;
                    break;
            }
            if (month < 1 || month > 12 || d < 1 || d > topDay)
            {
                Console.WriteLine("Khong hop le");
                return;
            }else Console.WriteLine("hop le");
            int a = (14 - month) / 12;
            int y = year - a;
            int m = month + 12 * a - 2;
            
            DayOfWeek = (d + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
            if(DayOfWeek == 0) Console.WriteLine("Chu nhat");
            else Console.WriteLine($"Thu {DayOfWeek + 1}");
         
          

        }
    }
}

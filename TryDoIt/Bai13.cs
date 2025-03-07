using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    public class Bai13
    {
        //Viết chuong trình nhập vào ngày tháng năm, kiểm tra ngày tháng nhập vào  có hợp lệ không. Tính thứ trong tuần của ngày đó
        public static void EnterDateMothYear()
        {
            Console.WriteLine("Enter Date, Month and Year");
            Console.Write("Enter Date: ");
            int date = int.Parse(Console.ReadLine());
            Console.Write("Enter Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
        }
    }
}

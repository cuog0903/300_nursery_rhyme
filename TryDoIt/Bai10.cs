using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai10
    {
        public static void CheckCanadaSIN()
        {
            //SIN: Số bảo hiểm xã hội của Canada - Canadian Social Insurance Number
            //gồm 9 chữ số:
            //Số phải nhất là số kiểm tra (check digit)
            //Trọng số: s1 + s2
            //s1 = tổng các số có vị trí lẻ
            //Các số có vị trí chẵn thì nhân đôi, nêu kết quả nhân dôi có hai chữ số thì kết quả là tổng của hai chữ số này, s2 là tổng các kết quả
            //SIN hợp lệ nếu check digit + s1 + s2 chia hết cho 10 và ngược lại
            //Yêu cầu bài toán:
            //Viết chương trình kiểm tra xem số SIN nhập vào có hợp lệ không
            //Bấm phím 0 để thoát chương trình

            while (true)
            {
                Console.Write("Enter SIN (If want out app, enter number 0): ");
                int numberSIN = int.Parse(Console.ReadLine());
                if (numberSIN == 0) return; //Neu nguoi dung nhap so 0 thi thoat
                //Lay so kiem tra check digit
                int checkDigit = numberSIN % 10;
                numberSIN /= 10; //Cap nhat lai so SIN sau khi bo di so check digit
                int s1 = 0, s2 = 0;
                for (int i = 8; i > 0 && numberSIN > 0; numberSIN /= 10, i--)
                {
                    if (i % 2 != 0) //Neu o vi tri le
                    {
                        s1 += (numberSIN % 10); //TInh tong cac so o vi tri le

                    }else //Khi o vi tri chan
                    {
                        int temp = (numberSIN % 10) * 2; //Nhan doi so o vi tri chan
                        if (temp - 10 > 0) //Neu ket qua nhan doi ma co hai chu so
                        {
                            s2 += ((temp % 10) + (temp / 10));
                        }
                        else s2 += temp;

                    }
                }
                if((checkDigit + s1+ s2) % 10 == 0) Console.WriteLine("SIN: correct");
                else Console.WriteLine("SIN: incorrect");

            }
        }
    }
}

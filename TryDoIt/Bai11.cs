using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDoIt
{
    class Bai11
    {
        public static void PlayRockPaperScissorsGame()
        {
            //Game: Bao - đá - kéo
            //Luật chơi: bao thắng đá, đá thắng kéo, kéo tháng bao
            //Người dùng được yêu cầu nhập vào 1 trong ba ký tự b, d, k, nếu nhập khác 1 tronb ba ký tự trên thì chương trình sẽ thoát
            //Cập nhật tỷ số theo định dạng : Tỷ số human - Computer: 0 - 0
            //Cần có 2 biến đếm để cập nhật tỷ số

            //Yêu cầu người dùng nhập vào ký tự
            //Dungf Random de lay ky tu cua computer
            //Them comment de test git thoi nhe
            int human = 0, computer = 0;// Hai bien de cap nhat ty so
            while (true)
            {
                Console.Write("Nhap ky tu (b - d - k), ky tu khac de thoat: ");
                char humanChar = char.Parse(Console.ReadLine());
                if (humanChar != 'b' && humanChar != 'd' && humanChar != 'k') return; //Neu khac 1 trong ba kys tu thi thoat chuong trinh
                char[] chars = ['b', 'd', 'k'];
                Random random = new Random();
                char computerChar = chars[random.Next(chars.Length)]; //lay random ky tu cho may tinh
                Console.WriteLine($"Computer: {computerChar}");

                if (humanChar == computerChar)
                {
                    Console.WriteLine($"Ty so (Human - Computer) : {human} - {computer}");
                    continue;
                } //Neu ra giong nhau thi tiep tuc choi ma khong  cap nhat ty so
                else //neu khac nhau
                {
                    switch (humanChar)
                    {
                        case 'b':
                            switch (computerChar)
                            {
                                case 'd': human++; break;
                                case 'k': computer++; break;
                            }
                            break;
                        case 'd':
                            switch (computerChar)
                            {
                                case 'b': computer++; break;
                                case 'k': human++; break;
                            }
                            break;
                        case 'k':
                            switch (computerChar)
                            {
                                case 'd': computer++; break;
                                case 'b': human++; break;
                            }
                            break;
                    }
                    Console.WriteLine($"Ty so (Human - Computer) : {human} - {computer}");
                }
            }
        }
    }
}

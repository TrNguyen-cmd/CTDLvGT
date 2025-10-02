using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("**");
            Console.WriteLine("* Chương trình quản lý thông tin sinh viên *");
            Console.WriteLine("**");
            Console.WriteLine("************************************************");
            Console.WriteLine("Chọn hành động: ");
            Console.WriteLine("1. Nhập thông tin sinh viên");
            Console.WriteLine("2. Xuất thông tin sinh viên");
            Console.WriteLine("3. Kết thúc chương trình");
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Sv SV = new Sv();
            do
            {
                Console.Clear();
                Menu();
                Console.WriteLine("Lựa chọn: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SV.NhapThongTinSinhVien();
                        SV.XepLoai(); break;
                    case "2":
                        SV.OutP();
                        Console.ReadLine(); break;
                    case "3":
                        Console.WriteLine("Chương trình kết thúc"); return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ"); break;
                }
            }
            while (true);
        }
    }
}

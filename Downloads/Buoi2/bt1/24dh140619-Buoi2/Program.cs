using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24dh140619_Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen a = new MangSoNguyen();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lựa chọn:");
                Console.WriteLine("1. Input");
                Console.WriteLine("2. Output");
                Console.WriteLine("3. SequentialSearch");
                Console.WriteLine("4. BubbleSort");
                Console.WriteLine("5. BinarySearch");
                Console.WriteLine("6. Sort");
                Console.WriteLine("7. Kết thúc");
                Console.WriteLine("----------------------------------------------");
                Console.Write("Nhập lựa chọn: ");
                int chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1: a.Input();break;
                    case 2: a.Output(); break;
                    case 3:
                        int x;
                        Console.Write("Số cần tìm: ");
                        x = int.Parse(Console.ReadLine());
                        if (a.SequentialSearch(x) != -1)
                        {
                            Console.WriteLine($"{x} tồn tại trong mảng");
                        }
                        else Console.WriteLine($"{x} không tồn tại trong mảng");
                        Console.ReadKey();
                        break;
                    case 4: a.BubbleSort(); break;
                    case 5:
                        Console.Write("Số cần tìm bằng cấu trúc Array: ");
                        x = int.Parse(Console.ReadLine());
                        a.BinarySearch(x); break;
                    case 6: a.Sort(); break;
                    case 7: Console.WriteLine("Kết thúc chương trình.");return;
                    default: break;
                }
            }
        }
    }
}

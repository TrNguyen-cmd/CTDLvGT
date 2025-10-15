using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            WebBrowser browser = new WebBrowser();
            browser.history = new Stack<string>();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Thêm một URL mới vào lịch sử");
                Console.WriteLine("2. Quay lại trang trước đó.");
                Console.WriteLine("3. Hiển thị URL hiện tại.");
                Console.WriteLine("4. Kết thúc");
                Console.Write("Lựa chọn: ");

                int chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        {
                            Console.Write("URL: ");
                            string url = Console.ReadLine();
                            browser.Visit(url);
                            break;
                        }
                    case 2:
                        {
                            browser.Back();
                            Console.ReadKey();
                            break;
                        }
                    case 3:browser.CurrentUrl();break;
                    case 4:
                        {
                            Console.WriteLine("Chương trình kết thúc");
                            Console.ReadKey();
                            return;
                        }
                    default: break;

                }

            }
        }
    }
}

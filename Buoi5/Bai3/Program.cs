using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Queue<Customer> KH = new Queue<Customer>();
            int stt = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chương trình quản lý danh sách khách hàng");
                Console.WriteLine("1. Thêm khách hàng");
                Console.WriteLine("2. Xóa khách một khách hàng hỏi hàng đợi");
                Console.WriteLine("3. Thông tin khách hàng đầu tiên");
                Console.WriteLine("4. Hiển thị thông tin tất cả khách hàng trong hàng đợi");
                Console.WriteLine("5. Kết thúc");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Thông tin khách hàng thứ " + stt);
                            Customer customer = new Customer();
                            customer.TTKH(stt);
                            KH.Enqueue(customer);
                            stt++;
                        }break;
                        case 2:
                        {
                            Console.WriteLine("Đã xóa khách hàng: ");
                            Customer khdx = KH.Dequeue();
                            khdx.XuatTTKH();
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Thông tin khách hàng đầu tiên: ");
                            Console.WriteLine(KH.Peek());
                            Console.ReadLine();
                        }break;
                    case 4:
                        {
                            Console.WriteLine("Thông tin tất cả khách hàng: ");
                            foreach(Customer customer in KH)
                            {
                                customer.XuatTTKH();
                            }    
                            Console.ReadLine();
                        }break;
                    case 5:
                        Console.WriteLine("Chương trình kết thúc.");return;
                    default: break;
                }    
            }
        }
    }
}

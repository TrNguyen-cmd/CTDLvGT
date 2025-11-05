using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LinkedList<int> list = new LinkedList<int>();
            Console.Write("Nhập các phần tử trong danh sách (các phần tử cách nhau bằng dấu cách): ");
            string[] number =Console.ReadLine().Split(' ');
            for(int i = 0; i < number.Length; i++)
            {
                list.AddLast(int.Parse(number[i]));
            }    
            Removefist(list);
            Removelast(list);
            Remove(list);
            Console.WriteLine("Đã xóa phần trong danh sách");
        }
        static void Removefist(LinkedList<int> list)
        {
            list.RemoveFirst();
            Console.WriteLine("Đã xóa phần tử đầu tiên");
        }
        static void Removelast(LinkedList<int> list)
        {
            list.RemoveLast();
            Console.WriteLine("Đã xóa phần tử cuối");
        }
        static void Remove(LinkedList<int> list)
        {
            LinkedListNode<int> node = null;
            Console.Write("Nhập giá trị cần xóa: ");
            int x = int.Parse(Console.ReadLine());
            node = list.Find(x);
            list.Remove(node);
        }
    }
}

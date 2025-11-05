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
            Console.OutputEncoding = Encoding.UTF8;
            LinkedList<int> list = new LinkedList<int>();
            Console.Write("Nhập các phần tử trong danh sách: ");
            string[] number = Console.ReadLine().Split(' ');
            for (int i = 0; i < number.Length; i++)
            {
                list.AddLast(int.Parse(number[i]));
            }
            Find(list);
            PtuTaiK(list);
            MaxMin(list);
        }
        static void Find(LinkedList<int> list)
        {
            Console.WriteLine("Nhập giá trị cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            LinkedListNode<int> node = list.Find(x);
            int i = 1;
            if (node != null)
            {
                LinkedListNode<int> c = list.First;
                while(c != null)
                {
                    if(c == node) break;
                    c = c.Next;
                    i++;
                }
                Console.WriteLine($"Đã tìm thấy {x} tại node thứ {i}");
            }
        }
        static void PtuTaiK(LinkedList<int> list)
        {
            Console.WriteLine("Nhập node cần in ra: ");
            int k = int.Parse(Console.ReadLine());
            LinkedListNode<int> current = list.First;
            int n = 1;
            while(current!= null && n < k)
            {
                current = current.Next;
                n++;
            }    
            if(current!=null)
            {
                Console.WriteLine($"Phần tử tại vị trí {k} là: {current.Value}");
            }    
        }
        static void MaxMin(LinkedList<int> list)
        {
            int Max = list.Max();
            int Min = list.Min();
            Console.WriteLine($"Giá trị lớn nhất trong danh sách là: {Max}");
            Console.WriteLine($"Giá trị nhỏ nhất trong danh sách là: {Min}");
        }
    }
}

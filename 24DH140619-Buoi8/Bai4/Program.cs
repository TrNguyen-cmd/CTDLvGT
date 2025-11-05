using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
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
            LinkedList<int> Reverselist = Reverse(list);

            foreach(var x in Reverselist)
            {
                Console.Write(x + " -> ");
            }
            Console.WriteLine("null");
        }
        static LinkedList<int> Reverse(LinkedList<int> list)
        {
            LinkedList<int> Reverse = new LinkedList<int>();
            LinkedListNode<int> node = list.Last;
            while(node != null)
            {
                Reverse.AddFirst(node.Value);
                node = node.Previous;
            }    
            return Reverse;
        }
    }
}

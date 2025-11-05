using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== BÀI 1: LINKEDLIST CƠ BẢN ===\n");

            LinkedList list = new LinkedList();

            list.Addfirst(10);
            list.Addfirst(5);
            list.Addlast(20);
            list.Addlast(25);

            Console.WriteLine();
            list.Display();
            Console.WriteLine($"Số phần tử: {list.count()}");
        }
    }
}

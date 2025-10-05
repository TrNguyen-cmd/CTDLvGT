using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Stack<int> stack = new Stack<int>();
            Console.Write("Số phần tử trong stack: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Các phần tử trong stack: ");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            stack.Pop();
            Console.WriteLine("Stack sau khi bỏ phần tử đầu tiên: ");
            foreach (int i in stack)
            { Console.Write(i + " "); }
            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Phần tử đầu tiên của stack: " + stack.Peek());
            Console.WriteLine("************************************************************************");
            if (stack.Count() == 0)
            { Console.WriteLine("Stack rỗng "); }
            else Console.WriteLine("Stack có chứa phần tử");
            Console.ReadKey();

        }
    }
}

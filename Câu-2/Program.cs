using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Câu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Stack<int> ST = new Stack<int>();
            Console.Write("Nhập số nguyên cần chuyển sang hệ nhị phân: ");
            int n = int.Parse(Console.ReadLine());
            int d = n;
            while(d>0)
            {
                ST.Push(d % 2);
                d = d / 2;
            }
            Console.Write($"{n} sau khi chuyển sang hệ nhị phân: ");
            foreach (int i in ST)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}

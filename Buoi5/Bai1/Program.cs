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
             Queue<int> queue = new Queue<int>();
            Console.Write("Nhập số cần cần đảo ngược: ");
            int n = int.Parse(Console.ReadLine());
            int d = n;
            while (d > 0)
            {
                queue.Enqueue(d%10);
                d=d / 10;
            }
            Console.Write($"{n} sau khi đảo ngược: ");
            foreach(int i in queue)
                Console.Write(i);
            Console.ReadLine();
        }
    }
}

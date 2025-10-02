using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24dh140619_Buoi2
{
    class MangSoNguyen
    {
        public MangSoNguyen() { }
        public int n { get; set; }
        public int[] Arr { get; set; }
        public void Input()
        {
            Console.Write("Số phần tử trong mảng:");
            n = int.Parse(Console.ReadLine());
            Arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = rd.Next(1, 100);
            }
        }
        public void Output()
        {
            Console.WriteLine("Các phần tử trong mảng: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public int SequentialSearch(int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (x == Arr[i])
                {
                    return x;
                }
            }
            return -1;
        }
        public void BubbleSort()
        {
            int b;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (Arr[j] < Arr[i])
                    {
                        b = Arr[j];
                        Arr[j] = Arr[i];
                        Arr[i] = b;
                    }
                }
            }
            Console.WriteLine("Các phần tử trong mảng sau khi sắp xếp: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.ReadKey();
        }
        public void BinarySearch(int x)
        {
            int S = Array.BinarySearch(Arr, x);
            if (S >= 0)
            {
                Console.WriteLine($"{x} Tồn tại trong mảng, Tại vị trí {Array.IndexOf(Arr, x)}");
            }
            else Console.WriteLine($"{x} Không tồn tại trong mảng");
            Console.ReadKey();
        }
        public void Sort()
        {
            Array.Sort(Arr);
            Console.WriteLine("Các phần tử trong mảng sau khi sắp xếp bằng PP có sẵn: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

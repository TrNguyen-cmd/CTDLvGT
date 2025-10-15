using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Customer
    {
        public Customer() { }
        public string Hoten { get; set; }
        public int Maso { get; set; }
        public int stt { get; set; }
        public void TTKH(int stt)
        {
            this.stt = stt;
            Console.Write("Họ và tên KH: ");
            Hoten = Console.ReadLine();
            Console.Write("Mã số KH: ");
            Maso = int.Parse(Console.ReadLine());
        }
        public void XuatTTKH()
        {
            Console.WriteLine($"STT: {stt} | Họ tên: {Hoten} | Mã số: {Maso}");
        }
    }
}

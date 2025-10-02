using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class DanhSachSinhVien
    {
        public int n { get; set; }
        public SinhVien[] arrSinhVien { get; set; }
        public DanhSachSinhVien() { }
        public DanhSachSinhVien(int n, SinhVien[] arrSinhVien )
        { 
            this.n = n;
            this.arrSinhVien = arrSinhVien;
        }

        public void InputSinhVien()
        {
            Console.Write("Số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());
            arrSinhVien = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}: ");
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapThongTinSinhVien();
                Console.WriteLine("*****************************************************");
            }
            Console.ReadLine();
        }
        public void OutputSinhVien()
        {
            for (int i = 0; i < n; i++)
            {
                arrSinhVien[i].XepLoai();
                arrSinhVien[i].OutP();
            }
        }
        public SinhVien TimKiemThongTinSinhVien(string HoTen)
        {
            for (int i = 0; i < n; i++)
            {
                if (HoTen.ToLower() == arrSinhVien[i].hoten.ToLower())
                {
                    return arrSinhVien[i];
                }
            }
            return null;
        }
        public SinhVien TimKiemNhiPhan(string HoTen)
        {
            int left = 0, right = n - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(arrSinhVien[mid].hoten, HoTen, StringComparison.OrdinalIgnoreCase);
                if (cmp == 0)
                    return arrSinhVien[mid];
                else if (cmp < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
        public void SapXepThongTinSinhVienHoTen()
        {
            Array.Sort(arrSinhVien);
        }
    }
}

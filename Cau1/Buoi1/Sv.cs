using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Sv
    {
        private string maSO;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;

        public Sv() { }

        public Sv(string maSO, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maSO = maSO;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
        }

        public Sv(Sv sv)
        {
            sv.maSO = maSO;
            sv.hoTen = hoTen;
            sv.chuyenNganh = chuyenNganh;
            sv.namSinh = namSinh;
            sv.diemTB = diemTB;
        }

        public string maso
        {
            get { return maSO; }
            set { maSO = value; }
        }
        public string hoten
        {
            get { return hoTen; }
            set { hoten = value; }
        }
        public string chuyennganh
        {
            get { return chuyenNganh; }
            set { chuyenNganh = value; }
        }
        public int namsinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public float diemtb
        {
            get { return diemTB; }
            set { diemTB = value; }
        }
        public void NhapThongTinSinhVien()
        {
            Console.Write("MSSV: ");
            maSO = Console.ReadLine();
            Console.Write("Ho Ten Sv: ");
            hoTen = Console.ReadLine();
            Console.Write("Chuyen nganh: ");
            chuyenNganh = Console.ReadLine();
            do
            {
                Console.Write("Nam sinh: ");
                namSinh = int.Parse(Console.ReadLine());
            }
            while ((2025 - namSinh) <= 17 || (2025 - namSinh >= 70));
            do
            {
                Console.Write("Diem TB: ");
                diemTB = float.Parse(Console.ReadLine());
                if (diemTB > 10 || diemTB <= 0)
                    Console.WriteLine("Diem k hop le");
            }
            while (diemTB < 0 || diemTB > 10);
        }
        public void XepLoai()
        {
            if (diemTB > 8)
                loai = "Gioi";
            else if (diemTB >= 7) loai = "Kha";
            else if (diemTB >= 5) loai = "Trung Binh";
            else loai = "Kem";
        }
        public void OutP()
        {
            Console.WriteLine();
            Console.WriteLine($"MSSV : {maSO}");
            Console.WriteLine($"Ho Ten : {hoTen}");
            Console.WriteLine($"Chuyen nganh: {chuyenNganh}");
            Console.WriteLine($"Nam sinh : {namSinh}");
            Console.WriteLine($"Xep loai : {loai}");
        }
    }
}

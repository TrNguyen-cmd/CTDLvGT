using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachSinhVien dssv = new DanhSachSinhVien();
            while (true)
            {
                Console.WriteLine("1. Nhập thông tin sinh viên");
                Console.WriteLine("2. Xuất thông tin sinh viên");
                Console.WriteLine("3. Tìm kiếm bằng phương pháp tuần tự");
                Console.WriteLine("4. Tìm kiếm bằng phương pháp nhị phân");
                Console.WriteLine("5. Sắp xếp ");
                Console.WriteLine("6. kết thúc");
                int chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        dssv.InputSinhVien(); break;
                    case 2:
                        dssv.OutputSinhVien(); break;
                    case 3:
                        {
                            Console.Write("Nhập họ tên sv cần tìm: ");
                            string HoTen = Console.ReadLine();
                            SinhVien sv = dssv.TimKiemThongTinSinhVien(HoTen);
                            if (dssv.TimKiemThongTinSinhVien(HoTen) == null)
                                Console.WriteLine("không tìm thấy sinh viên");
                            else
                            {
                                Console.WriteLine("Tìm thấy sinh viên");
                                sv.OutP();
                            }
                            break;
                        }
                    case 4:
                        {
                            string HoTen = Console.ReadLine();
                            SinhVien SV = dssv.TimKiemNhiPhan(HoTen);
                            if (SV == null)
                            {
                                Console.WriteLine("không tìm thấy sinh viên");
                            }
                            else
                            {
                                Console.WriteLine("Đã tìm thấy sinh viên:");
                                SV.OutP();
                            }
                            break;
                        }
                    case 5:
                        {
                            dssv.SapXepThongTinSinhVienHoTen(); break;
                        }
                    case 6: Console.WriteLine("Chương trình kết thúc"); return;
                    default: break;


                }
            }

        }
    }
}

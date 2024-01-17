using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        private string Hoten;
        private double SoNgayCong;
        private double SoNgayLamThem;
        private string XepLoai;
        private string BoPhan;

        public NhanVien() { }
        public NhanVien(string hoten, double songaycong, double songaylamthem, string xeploai, string bophan)
        {
            this.Hoten = hoten;
            this.SoNgayCong = songaycong;
            this.SoNgayLamThem = songaylamthem;
            this.XepLoai = xeploai;
            this.BoPhan = bophan;
        }
        public string hoten 
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public double songaycong
        {
            get { return SoNgayCong; }
            set { songaycong = value; }
        }
        public double songaylamthem
        {
            get { return songaylamthem; }
            set { songaylamthem = value; }
        }
        public string xeploai
        {
            get { return xeploai; }
            set { xeploai = value; }
        }
        public string bophan
        {
            get { return BoPhan; }
            set { bophan = value; }
        }
        public double TinhLuong()
        {
            int songaylamthem = 0;
            if (bophan.Equals("TrucTiep")) { songaylamthem = songaylamthem * 3; }
            else if (bophan.Equals("GianTiep")) { songaylamthem = songaylamthem * 2; }
            return (songaycong + songaylamthem) * 100000;
        }
        public double tinhThuNhap()
        {
            double thuNhap = TinhLuong();
            switch (XepLoai)
            {
                case "A":
                    thuNhap = thuNhap * 1.5;
                    break;
                case "B":
                    thuNhap = thuNhap * 1.2;
                    break;
                default:
                    break;
            }
            return thuNhap;
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho Ten:"+Hoten);
            Console.WriteLine("Bo Phan:"+bophan);
            Console.WriteLine("ThuNhap:"+tinhThuNhap());
        }
    class Program
        {
            static void Main(string[] args)
            {
                NhanVien nhanvien1 = new NhanVien();
                Console.Write("Nhap Ho ten Nhan vien 1:");
                nhanvien1.Hoten = Console.ReadLine();

                Console.Write("Nhap so ngay cong:");
                nhanvien1.SoNgayCong = int.Parse(Console.ReadLine());

                Console.Write("Nhap so ngay lam them:");
                nhanvien1.SoNgayLamThem = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhan vien xep loai A/B/C");
                nhanvien1.XepLoai = Console.ReadLine();

                Console.WriteLine("Nhap bo phan(Truc tiep/Gian tiep)");
                nhanvien1.BoPhan = Console.ReadLine();

                Console.Write("\n Thong tin nhan vien vua nhap");
                nhanvien1.InThongTin();

                NhanVien nhanvien2 = new NhanVien();
                Console.Write("Nhap Ho ten Nhan vien 2:");
                nhanvien2.Hoten = Console.ReadLine();

                Console.Write("Nhap so ngay cong:");
                nhanvien2.SoNgayCong = int.Parse(Console.ReadLine());

                Console.Write("Nhap so ngay lam them:");
                nhanvien2.SoNgayLamThem = int.Parse(Console.ReadLine());

               Console.Write("Nhan vien xep loai A/B/C");
                nhanvien2.XepLoai = Console.ReadLine();

                Console.Write("Nhap bo phan(Truc tiep/Gian tiep");
                nhanvien2.BoPhan = Console.ReadLine();

                Console.Write("\n Thong tin nhan vien vua nhap");
                nhanvien2.InThongTin();

                Console.ReadLine();
            }
        }
    } }

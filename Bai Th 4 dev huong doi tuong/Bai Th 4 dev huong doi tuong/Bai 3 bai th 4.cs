using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Th_4_dev_huong_doi_tuong
{
    class Bai_3_bai_th_4
    {
    }
    class Person
    {
        private string hoten;
        private int namsinh;
        private double diemthi;

        public Person()
        {
            hoten = " ";
            diemthi = 0;
            namsinh = 1900;

        }
        public Person(string hoten, double diemthi, int namsinh)
        {
            this.hoten = hoten;
            this.diemthi = diemthi;
            this.namsinh = namsinh;
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Họ tên học viên : ");
            hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Điểm thi= ");
            diemthi = double.Parse(Console.ReadLine());
            Console.Write("Năm sinh");
            namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("HỌ TÊN HỌC VIÊN {0}", hoten);
            Console.WriteLine("NĂM SINH{0} ", namsinh);
            Console.WriteLine("ĐIỂM THI{0} ", diemthi);
        }
    }
    class TEst
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Nhap();
            p.Hien();
            Console.ReadKey();
        }
    }
}


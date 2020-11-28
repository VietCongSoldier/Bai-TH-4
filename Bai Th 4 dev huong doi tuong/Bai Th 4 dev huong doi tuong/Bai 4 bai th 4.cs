using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Th_4_dev_huong_doi_tuong
{
    class Bai_4_bai_th_4
    {
    }
    class phantu
    {
        private double heso;
        private int somu;
        public phantu()
        {
            heso = somu = 0;
        }
        public phantu(double heso, int somu)
        {
            this.heso = heso;
            this.somu = somu;
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Hệ số= ");
            heso = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Số mũ: ");
            somu = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("HỆ SỐ :{0}", heso);
            Console.Write("SỐ  MŨ :{0}", somu);
        }
    }

    class DaThuc
    {
        private int n;
        private phantu[] p;
        private double x;
        public void nhap()
        {

        }
        public void hien()
        {

        }
    }
    class program2
    {
        static void Main()
        {
            phantu pt=new phantu();
            pt.Nhap();
            pt.Hien();
            DaThuc dt = new DaThuc();
        }
    }
}

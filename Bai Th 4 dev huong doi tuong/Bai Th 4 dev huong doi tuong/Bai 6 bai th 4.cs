using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Th_4_dev_huong_doi_tuong
{
    class Bai_6_bai_th_4
    {
    }
    class NGUOI
    {
        private string hoten;
        private int namsinh;
        private double chieucao, trongluong;
        public NGUOI()
        {
            hoten = " ";
            namsinh = 1900;
            chieucao = trongluong = 0;
        }
        public NGUOI(string hoten, double chieucao, double trongluong, int namsinh)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.chieucao = chieucao;
            this.trongluong = trongluong;
        }
    }
    class program4
    {
        static void Main()
        {
            NGUOI ng = new NGUOI();
        }
    }
}

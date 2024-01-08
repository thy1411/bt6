using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron htron = new HinhTron(5);
            Console.WriteLine("*******Thông tin hình tròn: ");
            Console.WriteLine("Ban kinh:{0} - Dien tich: {1} - Chu vi: {2}",
                htron.getBanKinh(), htron.tinhDienTich(), htron.tinhchuvi());

            HinhTru htru = new HinhTru(3, 4);
            Console.WriteLine("*******Thông tin hình tru: ");
            Console.WriteLine("Ban kinh:{0} - Chieu Dai: {1} - The Tich: {2}",
                htru.getBanKinh(), htru.getChieuCao(), htru.tinhDienTich());

            Console.ReadLine();
        }
    }
}
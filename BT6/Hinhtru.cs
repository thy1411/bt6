using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class HinhTru : HinhTron
    {
        private double chieuCao;
        public HinhTru() : base()
        {
            chieuCao = 1.0;
        }
        public HinhTru(double banKinh, double chieuCao) : base(banKinh)
        {
            setChieuCao(chieuCao);
        }
        public void setChieuCao(double chieuCao)
        {
            this.chieuCao = Math.Abs(chieuCao);
        }
        public double getChieuCao()
        {
            return chieuCao;
        }
        public double tinhDienTich2()
        {
            return base.tinhDienTich() * chieuCao;
        }
        public new double tinhDienTich()
        {
            return 2 * base.tinhDienTich() + tinhchuvi() * chieuCao;
        }
    }
}
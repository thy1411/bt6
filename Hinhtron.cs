using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class HinhTron
    {
        private double bankinh;
        public HinhTron()
        {
            bankinh = 1.0;
        }
        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public void setBanKinh(double bankinh)
        {
            this.bankinh = Math.Abs(bankinh);
        }
        public double getBanKinh()
        {
            return bankinh;
        }
        public double tinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
        public double tinhchuvi()
        {
            return 2 * bankinh * Math.PI;
        }
    }
}

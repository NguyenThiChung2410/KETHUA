using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Hinhtron
    {
        private double bankinh;

        public Hinhtron()
        {
            bankinh = 1.0;
        }
        public Hinhtron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public void setbankinh(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public double getbankinh()
        {
            return bankinh;
        }
        public double tinhdientich()
        {
            return Math.PI * bankinh * bankinh;
        }
        public double tinhchuvi()
        {
            return Math.PI * 2 * bankinh;
        }
    }
}

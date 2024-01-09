using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class HinhTru:Hinhtron
    {
        private double chieucao;
        public HinhTru() : base()
        {
            chieucao = 1.0;
        }
        public HinhTru(double bankinh,double chieucao) : base(bankinh)
        {
            setchieucao(chieucao);
        }
        public void setchieucao(double chieucao)
        {
            this.chieucao = Math.Abs(chieucao);
        }
        public double getchieucao()
        {
            return chieucao;
        }
        public double tinhdientich()
        {
            return 2 * base.tinhdientich() + tinhchuvi() * chieucao;

        }
        public double tinhthetich()
        {
            return base.tinhdientich() * chieucao;
        }
    }
}

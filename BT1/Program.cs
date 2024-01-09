using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ban kinh hinh tron la: ");
            double bankinh = double.Parse(Console.ReadLine());
            Hinhtron htron = new Hinhtron(bankinh);
            

            Console.WriteLine("******Thong tin hinh tron la:*****");
            Console.WriteLine("Ban kinh:{0}\nDien tich:{1}\nChu vi:{2}", htron.getbankinh(), htron.tinhdientich(), htron.tinhchuvi());
            
            Console.Write("Ban kinh hinh tru la: ");
            double Bankinh = double.Parse(Console.ReadLine());
            Console.Write("Chieu cao hinh tru la: ");
            double chieucao = double.Parse(Console.ReadLine());
            HinhTru htru = new HinhTru (Bankinh,chieucao);
           

            Console.WriteLine("******Thong tin hinh tru la:*****");
            Console.WriteLine("Ban kinh:{0}\nChieu cao:{1}\nDien tich:{2}\nThe tich:{3}", htru.getbankinh(), htru.getchieucao(), htru.tinhdientich(), htru.tinhthetich());
            Console.ReadLine();
        }
    }
}

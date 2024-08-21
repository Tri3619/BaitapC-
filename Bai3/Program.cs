using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        const double Pi = 3.14;
        static void Main(string[] args)
        {
            double C, S, r;
            Console.Write("Nhap vao ban kinh hinh cau r = ");
            r = Convert.ToDouble(Console.ReadLine());
            S = Pi * r * r;
            C = 2 * Pi * r;
            Console.WriteLine("Dien tich cua hinh cau la {0} Chu vi cua hinh cau la = {1}", S, C);
            Console.ReadKey();
        }
    }
}

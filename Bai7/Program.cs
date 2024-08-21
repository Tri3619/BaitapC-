using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao gia tri cua x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao gia tri cua y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao gia tri cua a: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao gia tri cua b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao gia tri cua c: ");
            double c = Convert.ToInt32(Console.ReadLine());
            double Tong = a * x + b * y + c;
            double Tu = Math.Sqrt(Tong);
            double Mau = Math.Sqrt(a * a + b * b);
            double Khoang_cach = Tu / Mau;
            Console.WriteLine("Khoang cach {0}", Khoang_cach);
            Console.ReadKey();
        }
    }
}

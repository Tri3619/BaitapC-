using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F, K;
            Console.Write("Nhap vao do C = ");
            C = Convert.ToDouble(Console.ReadLine());
            F = (9.0 / 5) * C + 32;
            K = C + 273.15;
            Console.WriteLine("Do F = {0}", F);
            Console.WriteLine("Do K = {0}", K);
            Console.ReadKey();
        }
    }
}

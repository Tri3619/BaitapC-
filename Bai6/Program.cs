using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập họ tên từ bàn phím
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            // Nhập ngày sinh từ bàn phím
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            // Giả sử tuổi về hưu là 60
            DateTime ngayVeHuu = ngaySinh.AddYears(60);

            // Hiển thị họ tên và ngày về hưu
            Console.WriteLine("Ho ten: {0}", hoTen);
            Console.WriteLine("Ngay ve huu: {0:dd/MM/yyyy}", ngayVeHuu);

            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_dai_AB
{
    class Program
    {
        static void Main(string[] args)
        {
            float Xa, Ya, Xb, Yb, d;
            Console.WriteLine("Chuong trinh tinh do dai doan thang AB");
            Console.WriteLine("Nhap toa do diem A:");
            Console.Write("Xa=");
            Xa = float.Parse(Console.ReadLine());
            Console.WriteLine("Ya=");
            Ya = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do diem B:");
            Console.Write("Xb=");
            Xb = float.Parse(Console.ReadLine());
            Console.Write("Yb=");
            Yb = float.Parse(Console.ReadLine());
            d = (float)Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));
            Console.WriteLine(" do dai doan thang AB:" + d);
            Console.ReadLine();
        }
    }
}

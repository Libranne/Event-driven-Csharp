using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s;
            Console.WriteLine("Chuong trinh tinh tong hai so nguyen");
            Console.Write("nhap a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("nhap b=");
            b = int.Parse(Console.ReadLine());

            s = (new Program()).Sum(a, b);
            Console.WriteLine("Tong cua {0} va {1} la: {2}", a, b, s);
            Console.ReadLine();


        }
        private int Sum(int a, int b)
        {
            return a + b;
        }
    
    }
}

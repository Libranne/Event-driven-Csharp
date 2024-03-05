using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write(" nhap so nguyen duong N:");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("n khong phai so nguyen duong");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Tong tu 0 den {0}:", n);
                for (int i = 0; i <= n; i++)
                {
                    sum = sum + i;
                }
                Console.Write(sum);
                Console.ReadLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, x, x1, x2, delta;
            Console.WriteLine("Chuong trinh giai PT bac 2");
            Console.Write("nhap a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("nhap b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("nhap c=");
            c = int.Parse(Console.ReadLine());

            if (a == 0)

            {

                if (b == 0)

                {

                    if (c == 0) Console.WriteLine("Phuong trinh co vo so nghiem");

                    else Console.WriteLine("Phuong trinh vo nghiem");

                }

                else Console.WriteLine("Phuong trinh co nghiem duy nhat x = " + (-c / b));

            }

            else

            {

                delta = b * b - 4 * a * c;

                if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem");

                if (delta == 0)

                {

                    x = -b / (2 * a);

                    Console.WriteLine("Phuong trinh co nghiem kep x = " + x);

                }

                if (delta > 0)

                {

                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);

                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.Write("Phuong trinh co hai nghiem phan biet: x1 = " + x1);

                    Console.WriteLine(";   x2 = " + x2);

                }

            }

            Console.ReadLine();

        }
    }
    
}

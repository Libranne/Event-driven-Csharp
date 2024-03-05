using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {


        static void Main(string[] args)
        {

            float BMI, tl, cc;
            //BMI=trong luong/(cc*cc)
            Console.WriteLine("Body Mass Index - BMI");
            Console.WriteLine("Nhap trong luong co the:");
            tl = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao:");
            cc = float.Parse(Console.ReadLine());
            BMI = tl / (cc * cc);
            if (BMI < 18.5)
            {
                Console.WriteLine("Duoi Chuan");
                Console.ReadLine();
            }
            else if (BMI < 25)
            {
                Console.WriteLine("Chuan");
                Console.ReadLine();
            }
            else if (BMI < 30)
            {
                Console.WriteLine("Thua can");
                Console.ReadLine();
            }
            else if (BMI < 40)
            {
                Console.WriteLine("Beo,can giam can");
                Console.ReadLine();
            }
            else
                Console.WriteLine("Rat beo,can giam can ngay");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            float R, C, S;
            Console.WriteLine("Chuong trinh tinh chu vi va dien tich hinh tron");
            Console.Write("Nhap ban kinh R:");
            R = float.Parse(Console.ReadLine());
            C = (float)(R * 2 * 3.14);
            S = (float)(R * R * 3.14);
            Console.WriteLine("Chu vi hinh tron co ban kinh {0} la : {1}", R, C);
            Console.Write("Dien tich hinh tron co ban kinh {0} la:{1}", R, S);
            Console.ReadLine();
        }
    }
}

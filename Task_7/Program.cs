using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, x1, y1, z1;
            Console.WriteLine("Первый треугольник");
            Console.Write("Введите длину x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину z = ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второй треугольник");
            Console.Write("Введите длину x = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину y = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину z = ");
            z1 = Convert.ToInt32(Console.ReadLine());
        }
        static void Trey(int x, int y, int z, out P1, out P2)
            double p1 = (x1 + y1 + z1)/2;
            double p2 = (x2 + y2 + z2) / 2;
            double P1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p - z));
            double P2 = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            if (Trey(x, y, z) > Trey(x1, y1, z1))
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (Trey(x, y, z) < Trey(x1, y1, z1))
                Console.WriteLine("Площадь второго треугольника больше");
            else Console.WriteLine("Площади равны");


        }
    }
}


static double Treyg(double a, double b, double c)
{
    double p;
    p = (a + b + c) / 2;
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба = ");
            int a = Convert.ToInt32(Console.ReadLine());
             
                double P, S;
                GetParam(a, out P, out S);
                Console.WriteLine("Периметр куба = {0}", P);
                Console.WriteLine("Площадь куба = {0}", S);
                Console.ReadKey();
        }
            static void GetParam(int a, out double P, out double S)
            {
                P = (a * a) * 6;
                S = a * a * a ;
            }
        
    }
}

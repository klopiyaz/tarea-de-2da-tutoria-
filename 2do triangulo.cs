using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese t: ");
            double t = double.Parse(Console.ReadLine());

            double aGrados = a * (180.0 / Math.PI);

            double y = t * Math.Sin(a);
            double z = t * Math.Cos(a);
            double c = 180 - 90 - a;

            Console.WriteLine("el cateto y es: " + y);
            Console.WriteLine("el cateto z es: " + z);
            Console.WriteLine("el angulo c es: " + c);
        }
    }
}

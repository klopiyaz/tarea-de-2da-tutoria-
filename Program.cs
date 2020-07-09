using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3er_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar los respectivos valores de z y c
            Console.WriteLine("ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            //Conversion de grados a radianes
            double cGrados = c * (180 / Math.PI);

            //Calculo de valores
            double a = 180 - 90 - c;
            double t = z / Math.Sin(c);
            double y = z / Math.Cos(c);

            Console.WriteLine("el angulo a es: " + a);
            Console.WriteLine("la hipotenusa es: " + t);
            Console.WriteLine("el cateto y es: " + y);
        }
    }
}

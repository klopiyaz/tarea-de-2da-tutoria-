using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
                {
                    //Console.Write("cateto Z: ");
                    //double z = int.Parse(Console.ReadLine());
                    double z = 3;

                    //Console.Write("cateto Y: ");
                    //double y = int.Parse(Console.ReadLine());
                    double y = 2;


                    double t = Math.Sqrt((y * y) + (z * z));
                    double c = Math.Atan(z / y);
                    double a = Math.Atan(y / z);

                    double cGrados = c * (180 / Math.PI);
                    double aGrados = a * (180 / Math.PI);

                    Console.WriteLine("hipotenusa T es: " + t);
                    Console.WriteLine("angulo c es: " + cGrados);
                    Console.WriteLine("angulo a es: " + aGrados);

                }
            }
        }

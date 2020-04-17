using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaciSmiljanic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string op;
            Console.WriteLine("Unesite dva broja:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite znak za zeljenu racunsku operaciju:");
            op = Console.ReadLine();
            c = Calculator(a, b, op);
            Console.WriteLine("Rezultat je {0:0.00}.", c);
            Console.ReadKey();
        }

        static public double Calculator(double x, double y, string z)
        {
            double rez=0;
            if (z=="+")
            {
                rez = x + y;
            }
            if (z == "-")
            {
                rez = x - y;
            }
            if (z == "*")
            {
                rez = x * y;
            }
            if (z == "/")
            {
                if (y != 0)
                {
                    rez = x / y;
                }
                else
                {
                    Console.WriteLine("Nije dozvoljeno deljenje nulom!");
                }
            }
            
            return rez;
        }
    }
}

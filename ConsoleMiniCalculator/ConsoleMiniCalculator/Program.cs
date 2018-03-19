using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMiniCalculator
{
    class Program
    {
        public double a { get; set; }
        public double b { get; set; }
        public char znak { get; set; }

        public static double Sum(double a, double b)
        {
            double arif;
            arif = a + b;
            return arif;
        }

        public static double Subtract(double a, double b)
        {
            double arif;
            arif = a - b;
            return arif;
        }

        public static double Multiplication(double a, double b)
        {
            double arif;
            arif = a * b;
            return arif;
        }

        public static double Divide(double a, double b)
        {
            double arif;
            arif = a / b;
            return arif;
        }

        static void Main(string[] args)
        {

            Program prg = new Program();

            
            Console.WriteLine("a =");
            prg.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Знак:");
            prg.znak = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("b =");
            prg.b = Convert.ToDouble(Console.ReadLine());


            if (prg.znak == '+')
            {
                double temp = Sum(prg.a, prg.b);
                Console.WriteLine(temp);
            }
            else if (prg.znak == '-')
            {
                double temp = Subtract(prg.a, prg.b);
                Console.WriteLine(temp);
            }
            else if (prg.znak == '*')
            {
                double temp = Multiplication(prg.a, prg.b);
                Console.WriteLine(temp);
            }
            else if (prg.znak == '/')
            {
                double temp = Divide(prg.a, prg.b);
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("Some error =( \nTry again");
            }



            Console.ReadKey();

        }
    }
}

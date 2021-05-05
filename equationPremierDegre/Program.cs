using System;

namespace equationPremierDegre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nombre a");
            Double.TryParse(Console.ReadLine(), out double a);

            Console.WriteLine("Entrez le nombre b");
            Double.TryParse(Console.ReadLine(), out double b);

            Console.WriteLine("x = " + Equation(a, b));
        }

        public static double Equation(double a, double b)
        {
            if(a == 0)
                throw new Exception("on ne peut pas diviser par zéro");

            if (a == 0 && b == 0)
                throw new Exception("équation indéterminée");
            else
            {
                double x = (-b) / a;
                return x;
            }
        }
    }
}

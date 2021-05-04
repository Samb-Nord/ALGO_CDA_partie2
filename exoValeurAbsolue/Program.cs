using System;

namespace exoValeurAbsolue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            double number = Double.Parse(Console.ReadLine());

            Console.WriteLine("La valeur absolue est : " + valeurAbsolue(number));
        }

        public static double valeurAbsolue(double nombre)
        {

            double valeurAbs = Math.Abs(nombre);

            return valeurAbs;

        }
    }
}

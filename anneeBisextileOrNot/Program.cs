using System;

namespace anneeBisextileOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez une année");
            int annee = Int32.Parse(Console.ReadLine());

            if (isBisextile(annee))
                Console.WriteLine("L'année est bisextile");
            else
                Console.WriteLine("L'année n'est pas bisextile");

        }

        public static bool isBisextile(int year)
        {
           
            if (DateTime.IsLeapYear(year))
                return true;
            else
                return false;
        }
    }
}

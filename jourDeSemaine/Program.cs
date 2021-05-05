using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jourDeSemaine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le jour");
            string day = Console.ReadLine();

            Console.WriteLine("Entrez le mois");
            string month = Console.ReadLine();

            Console.WriteLine("Entrez les deux derniers chiffres de l'année");
            Int32.TryParse(Console.ReadLine(), out int year);

            FindDay(day, month, year);
        }

        public static int FindDay(string jour, string mois, int annee)
        {
            //transformer l'année en 4 chiffres
            string yearString = "19" + annee;
            int newYear = Int32.Parse(yearString);


            if (newYear < 1901 && newYear > 1999)
                throw new Exception("l'année doit être comprise entre 1901 et 1999 inclus");
            else
            {
                int resultat4 = newYear%4;
                             
                jour = jour.ToLower();
                mois = mois.ToLower();

                int jourNumber = Conversion.Day(jour);
                int valeurMois = Conversion.Month(mois, newYear);

                double reste = (newYear + resultat4 + valeurMois + jourNumber);
                int reste7 = (Convert.ToInt32(reste)) % 7;

                return reste7;

            }
        }
    }
}

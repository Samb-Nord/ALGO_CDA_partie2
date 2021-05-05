using System;

namespace findDayOfWeek
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
                int jourNumber;
                int valeurMois;
                jour = jour.ToLower();
                mois = mois.ToLower();
                //switch pour stocker le numéro du jour entrée par l'utilisateur
                switch(jour)
                {
                    case "lundi":
                        jourNumber = 2;
                        break;
                    case "mardi":
                        jourNumber = 3;
                        break;
                    case "mercredi":
                        jourNumber = 4;
                        break;
                    case "jeudi":
                        jourNumber = 5;
                        break;
                    case "vendredi":
                        jourNumber = 6;
                        break;
                    case "samedi":
                        jourNumber = 0;
                        break;
                    case "dimanche":
                        jourNumber = 1;
                        break;
                    default:
                        throw new Exception("le jour ne correspond pas à un jour de la semaine");
                }

            
                //switch pour stocker le numéro du mois
                switch(mois)
                {
                    case "janvier":
                        if (DateTime.IsLeapYear(newYear))
                            valeurMois = 0;
                        else
                            valeurMois = 1;
                        break;
                    case "février":
                        if (DateTime.IsLeapYear(newYear))
                            valeurMois = 3;
                        else
                            valeurMois = 4;
                        break;
                    case "mars":
                        valeurMois = 4;
                        break;
                    case "avril":
                        valeurMois = 0;
                        break;
                    case "mai":
                        valeurMois = 2;
                        break;
                    case "juin":
                        valeurMois = 5;
                        break;
                    case "juillet":
                        valeurMois = 0;
                        break;
                    case "août":
                        valeurMois = 3;
                        break;
                    case "septembre":
                        valeurMois = 6;
                        break;
                    case "octobre":
                        valeurMois = 1;
                        break;
                    case "novembre":
                        valeurMois = 4;
                        break;
                    case "décembre":
                        valeurMois = 6;
                        break;
                    default:
                        throw new Exception("le mois ne corresponds pas à un mois de l'année");                       
                }

                double reste = (newYear + resultat4 + valeurMois + jourNumber);
                int reste7 = (Convert.ToInt32(reste))%7;

                return reste7;

            }

        }
    }
}

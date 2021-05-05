using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jourDeSemaine
{
    public class Conversion
    {
        public static int Day(string jour)
        {

            jour = jour.ToLower();
            int jourNumber;

            switch (jour)
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

            return jourNumber;
        }

        public static int Month(string mois, int annee)
        {
            mois = mois.ToLower();
            int valeurMois;

            //transformer l'année en 4 chiffres
            string yearString = "19" + annee;
            int newYear = Int32.Parse(yearString);


            //switch pour stocker le numéro du mois
            switch (mois)
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

            return valeurMois;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2._1
{
    public class Trier
    {
        public static List<double> Tri(ref List<double> liste)
        {

            for (int i = 0; i < liste.Count-1; i++)
            {
                double a = liste[i];
                double b = liste[i +1];
                if (a > b)
                {
                    double tmp = a;
                    a = b;
                    b = tmp;
                }
            }

            return liste;
        }

        public static List<double> Tri2(ref List<double> liste)
        {
            bool list_en_ordre = false;
            int taille = liste.Count();
            while (!list_en_ordre)
            {
                list_en_ordre = true;
                for (int i = 0; i < taille - 1; i++)
                {
                    if (liste[i] > liste[i + 1])
                    {
                        double tmp = liste[i];
                        liste[i] = liste[i + 1];
                        liste[i + 1] = tmp;
                        list_en_ordre = false;
                    }
                }
                taille--;
            }

            return liste;
        }
    }
}

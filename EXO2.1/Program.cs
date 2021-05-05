using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO2._1
{
     class Program
    {
        static void Main(string[] args)
        {


            List<double> list = new List<double>();
            list.Add(20);
            list.Add(201);
            list.Add(11);
            list.Add(41);
            list.Add(55);
            list.Add(-12);
            list.Add(13);

            Trier.Tri2(ref list);
            
            
            //Lire 2 nombres a et b. Les écrire dans l'ordre croissant.
            //Console.WriteLine("Entrez un premier nombre : ");
            //double nombre1 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Entrez un deuxième nombre : ");
            //double nombre2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Entrez un troisième nombre : ");
            //double nombre3 = Double.Parse(Console.ReadLine());

            //List<double> liste = triCroissant(nombre1, nombre2, nombre3);

            //Console.WriteLine("nombres trié par ordre croissant : ");

     
        }


        public static List<double> triCroissant(double a, double b, double c)
        {


            List<double> listNombres = new List<double>();
            if (a.GetType() == typeof(double))
            {

                if (a != b)
                {
                    listNombres.Add(a);
                    listNombres.Add(b);
                    listNombres.Add(c);

                    Trier.Tri(ref listNombres);

                    return listNombres;
                }
                else
                {
                    throw new Exception("les nombres doivent être différents");
                }


            }
            else
            {

                throw new Exception("Vous devez entrez des nombres.");
            }


        }

        
    }
}

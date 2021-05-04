﻿using System;
using System.Collections.Generic;

namespace EXO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lire 2 nombres a et b. Les écrire dans l'ordre croissant.
            Console.WriteLine("Entrez un premier nombre : ");
            double nombre1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un deuxième nombre : ");
            double nombre2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un troisième nombre : ");
            double nombre3 = Double.Parse(Console.ReadLine());

            List<double> liste = triCroissant(nombre1, nombre2, nombre3);

            Console.WriteLine("nombres trié par ordre croissant : ");

            foreach (double nombre in liste)
            {
                Console.WriteLine(nombre + "\r\n");
            }
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

                    listNombres.Sort();

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

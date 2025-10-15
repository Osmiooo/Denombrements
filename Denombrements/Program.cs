using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) 
                { 
                    Environment.Exit(0); 
                }

                if (choix == 1)
                {
                    int nombre = saisie("nombre total d'éléments à gérer = ");
                    // calcul de r
                    long r = 1;
                    for (int k = 1; k <= nombre; k++)
                        r *= k;
                    Console.WriteLine(nombre + "! = " + r);
                }
                else
                {
                    if (choix == 2)
                    {
                        int total = saisie("nombre total d'éléments à gérer = ");
                        int nombre2 = saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r
                        long r = 1;
                        for (int k = (total - nombre2 + 1); k <= total; k++)
                            r *= k;
                        Console.WriteLine("A(" + total + "/" + nombre2 + ") = " + r);
                    }
                    else if (choix == 3)
                    {
                        int total2 = saisie("nombre total d'éléments à gérer = ");
                        int nombre3 = saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (total2 - nombre3 + 1); k <= total2; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= nombre3; k++)
                            r2 *= k;
                        // calcul de r3
                        Console.WriteLine("C(" + total2 + "/" + nombre3 + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }

        static int saisie(string phrase)
        {
            int element;
            Console.Write(phrase);
            element = int.Parse(Console.ReadLine());

            return element;

        }
    }
}

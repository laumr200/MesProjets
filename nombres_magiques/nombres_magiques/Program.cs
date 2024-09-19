using System;

namespace nombres_magiques
{
    internal class Program
    {
        static int DemanderNombre(int min, int max)
        {

            int nombreUtilisateur = min - 1;

            while (nombreUtilisateur < min || nombreUtilisateur > max)
            {
                Console.Write("Rentrez un nombre entre " + min + " et " + max);
                string reponse = Console.ReadLine();
                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if (nombreUtilisateur < min || nombreUtilisateur > max)
                    {
                        Console.WriteLine("ERREUR:Le nombre doit etre entre " + min + " et " + max);

                    }

                }
                catch
                {
                    Console.WriteLine("EREUR :rentrez un nombre entre VALIDE");
                }
            }
            return nombreUtilisateur;
        }


        static void Main(string[] args)
        {
            Random rand = new Random();
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = NOMBRE_MIN - 1;

            int nbVies = 4;

            //int nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

            while (nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restant:" + nbVies);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand ");

                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit ");

                }
                break;//forcer a sortir de la boucle 
                nbVies--;

            }

            if (nombre == NOMBRE_MAGIQUE)
            {
                Console.WriteLine("bravo vous avez trouvez le nombre magique");
            }
            else
            {
                Console.WriteLine("Vous avez perdu, le nombre magique etait  :" + NOMBRE_MAGIQUE);



                // Console.WriteLine("Votre nombre est :"+ nombre);

            }
        }
    }
}
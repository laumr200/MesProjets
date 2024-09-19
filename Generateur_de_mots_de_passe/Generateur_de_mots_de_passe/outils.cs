using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur_de_mots_de_passe
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: Le nombre doit être positif et non nul");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPresonnalise = null)
        {
          

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            if (messageErreurPresonnalise == null)
            {
                Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);
            }
            else
            {
                Console.WriteLine(messageErreurPresonnalise);
            }

            Console.WriteLine();

            return DemanderNombreEntre(question, min, max, messageErreurPresonnalise);
        }

        public static int DemanderNombre(string question)
        {
            while (true) // boucle infini
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
        }

    }
}

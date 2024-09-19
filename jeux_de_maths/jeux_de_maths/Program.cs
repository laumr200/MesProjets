using System;

namespace jeux_de_maths
{
    internal class Program
    {
        enum e_Operateur
        {
           ADDITION = 1,
            MULTIPLICATION=2,
            SOUSTRACTION=3,
        }
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random(); //creation de l'objet rand
            int reponseInt = 0;
            int a = rand.Next(min, max + 1);
            int b = rand.Next(min, max + 1);
            e_Operateur o =(e_Operateur) rand.Next(1, 3);
            int resultatAttendu;
            while (true)
            {
                //pour cette excercice on peut aussi proceder avec switch - case
                /*switch (o)
                {
                    case e_Operateur.ADDITION:
                        Console.Write(a + " + " + b + " = "); // addition 
                        resultatAttendu = a + b;
                        break;
                        case e_Operateur.MULTIPLICATION:
                        Console.Write(a + " x " + b + " = ");
                        resultatAttendu = a * b;
                        break;
                        default:
                        // cas inconnu
                        Console.WriteLine("ERREUR :Operateur inconue");
                        return false;
                } */
                
                if (o == e_Operateur.ADDITION)
                {
                    Console.Write(a + " + " + b + " = "); // addition 
                    resultatAttendu = a + b;
                }
                else if (o == e_Operateur.MULTIPLICATION)
                {
                    Console.Write(a + " x " + b + " = ");
                    resultatAttendu = a * b;
                } else 
                {    // cas inconnu
                    Console.WriteLine("ERREUR :Operateur inconue");
                    return false;
                }
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
            // normalment a cette niveau ont a une returne quelque chose mais dans cette cas ce n'est pas neccesaire
            //parce qu'on a une boucle infinit donc on va jamais sortir d'elle et on a  2 returs dasn la boucle qui indiquent qu'on sort de la fontion  
        }

        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NBR_QUESTION = 3;
            int points = 0;


            for (int i = 0; i < NBR_QUESTION; i++)
            {
                Console.WriteLine("Question numero " + (i + 1) + "/" + NBR_QUESTION);
                bool bonnereponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonnereponse == true)
                {
                    Console.WriteLine("Bonne reponse");
                    points++;
                }
                else { Console.WriteLine("Mauvaise reponse "); }
                Console.WriteLine("   ");
            }
            Console.WriteLine("Nombre des points : " + points + "/" + NBR_QUESTION);

            int moyenne = NBR_QUESTION / 2; //quantite des questions entre 2

            if (points == NBR_QUESTION) { Console.WriteLine("EXCELLENT"); }
            else if (points == 0) { Console.WriteLine("REvisez vos maths "); }
            else if (points > moyenne) { Console.WriteLine("Pas mal"); }
            else { Console.WriteLine("peut mieux faire "); }


        }

    }
}
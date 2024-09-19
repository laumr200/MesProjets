using System;

namespace premierformation {
    internal class Program
    {
        static int DemanderAge(string nom) {
            int age_num = 0;
            while (age_num <= 0)
            {

                Console.Write(nom + "quelle est votre age  ?");
                string age_str = Console.ReadLine();

                // on fais try (que ca veux dire essai de faire ca et a l'interieur de le acolades on mets ce qu'on veut q'il fasse)
                //mais s'il peut pas le faire a causse que l'utilisateur a mal rentre les info donc on va capturer et metre un message d'erreur dans la parti catch
                try
                {
                    age_num = int.Parse(age_str);
                    if (age_num < 0){ Console.WriteLine("L'age ne peut pa etre negatif");  }
                    if (age_num == 0){ Console.WriteLine("L'age ne peut pa etre cero");  }
                }
                catch
                {
                    Console.WriteLine("erreur, vous devez rentrer un age valide ");
                }
            }
            // pour retourner la valeur final  de l'age apres la boucle 
            return age_num;
        }

        static string DemanderNom(int numeroPersonne) {
            string nomDeLaPersonne = "";
            while (nomDeLaPersonne == "")
            {
                Console.Write("quelle est ton nom ?");
                nomDeLaPersonne = Console.ReadLine();
                //apres qu'on a recupere le nom de la personne la fontion trim va eliminer les espaces 
                //comme ca si l'utilisateur a juste rentre des espaces sans rien ecrire ca va pas marcher 
                nomDeLaPersonne = nomDeLaPersonne.Trim();
                if (nomDeLaPersonne == "") { Console.WriteLine("Le nom ne peut pas etre vide "); }
            }
            return nomDeLaPersonne;


        }

        static void AfficherInfoPersonne(string nomDeLaPersonne, int age_num , float taille)
        {
            Console.WriteLine();//pour ajouter une ligne vide
            Console.WriteLine("Bonjour vous vous appellez " + nomDeLaPersonne + " et vous avez " + age_num + " ans ");
            int ageProchain = age_num + 1;
            Console.WriteLine(" bientot vous aurez " + ageProchain + " ans");
            //sinon on pourrais faire aussi 
            //boll personneMajeur = age>=18 
            // et apres rentrer dans la condition de if (personneMajeur )
            if (age_num == 18)
            { Console.WriteLine("Vous etes tout juste  majeur"); }
            else if (age_num == 17)
            { Console.WriteLine("Vous serez bientot majeur"); }
            else if (age_num ==1 || age_num == 2) { Console.WriteLine("Vous etes un bebe"); }
            else if (age_num >=12 && age_num < 18) { Console.WriteLine("Vous etes adolescent"); }
            else if (age_num >= 60) { Console.WriteLine("Vous etes senior "); }
            else if (age_num <10) { Console.WriteLine("Vous etes un enfant  "); }
            else if (age_num >= 18) { Console.WriteLine("Vous etes majeur  "); }
            else { Console.WriteLine("Vous etes mineur"); }


            if (taille != 0) {
                Console.WriteLine("Vous faites " + taille + "m de hauteur"); }
        } 

        static void Main(string[] args)
        {
            //On fait appelle a la fontion pour demander le nom 
             string nomDeLaPersonne1 = DemanderNom(1);
             string nomDeLaPersonne2 = DemanderNom(2);

             //demander l'age , on doit redeclarer la variable age du qu'elle est juste a l'inyterieur de la fontion aged
             int age_num1=DemanderAge(nomDeLaPersonne1);
             int age_num2 = DemanderAge(nomDeLaPersonne2);

            float taille = 1.75f;
             //afficher les resultat 
            AfficherInfoPersonne(nomDeLaPersonne1, age_num1,taille);
            AfficherInfoPersonne(nomDeLaPersonne2, age_num2 , taille); 
            
          /* const  int nb_personne= 3

            for (int i = 1; i <=nb_personne; i++)
            {
                string nom = "Personne" + i;
                int age= DemanderAge(nom);
                AfficherInfoPersonne(nom, age);*/
            }
            
        }
    }
 
using System;

namespace ConsoleApp1
{
    class Test
    {
        static void Main(string[] args)
        {
            string fileName;
            int nombreDeEtudiants;
            int nombreDeCours;


            Console.WriteLine("Entrez le nombres d'etudiants a gerer");
            nombreDeEtudiants = int.Parse(Console.ReadLine());
           
            //TODO demande le nombre de cours
            Console.WriteLine("Entrez le nombres de cours a gerer");
            nombreDeCours = int.Parse(Console.ReadLine());
            
            Console.WriteLine("#d'Etudiants: "+nombreDeEtudiants+"\n#de Cours"+ nombreDeCours);
            //TODO Boucle for qui demande l'information de chaque Etudiant et le stock dans un tableau de n Etudiant

            //TODO Boucle for qui demande l'information de chaque Cours et le stock dans un tableau de n Cour

            //TODO Boucle for qui affiche les Etudiants et les cours

            //TODO demande de choisir le cours
            //TODO demande de choisir l'etudiant

            //TODO demande de rentrer une note

            //TODO demande le nom du fichier

            //TODO ajoute une note puis l'informations du cours et de l'etudiant au fichier texte

            //TODO demande si on veut ajouter une autre note
        }
    }
}

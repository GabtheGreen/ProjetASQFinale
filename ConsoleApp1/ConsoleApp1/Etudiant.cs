using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Etudiant
    {
        private static int numeroEtudiantDeBase = 1000000;
        private string nomEtudiant { get; set; }
        private string prenomEtudiant { get; set; }
        private int numeroEtudiant { get; set; }

        public Etudiant(string prenom, string nom) {
            this.numeroEtudiant = ++numeroEtudiantDeBase;
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;
        }


    }
}

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

        public Etudiant() {
            this.numeroEtudiant = 0;
            this.prenomEtudiant = null;
            this.nomEtudiant = null;
        }
        public Etudiant(string prenom, string nom) {
            this.numeroEtudiant = ++numeroEtudiantDeBase;
            this.prenomEtudiant = prenom;
            this.nomEtudiant = nom;
        }
        
        public override string ToString()
        {
            return "#Etudiant: "+this.numeroEtudiant+
                   "\n"+this.GetNomComplet();
        }
        
        public string GetNomComplet(){
        return this.prenomEtudiant+" "+this.nomEtudiant;
        }

    }
}

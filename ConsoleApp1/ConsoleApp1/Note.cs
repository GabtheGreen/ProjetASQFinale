using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Note
    {
        private int noteDeCour { get; set; }
        public Etudiant instanceEtudiant;
        public Cour instanceCour;
        public Note(Etudiant unEtudiant, Cour unCour, int note)
        {
            this.instanceEtudiant = unEtudiant;
            this.instanceCour = unCour;
            this.noteDeCour = note;
        }
        
    }
}

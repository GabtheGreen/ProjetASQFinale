using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Note
    {
        private int noteDeCour { get; set; }
        private int numeroEtudiant { get; set; }
        private int numerosDeCour { get; set; }

        public Note(int Etudiant, int cour, int note)
        {
            this.numeroEtudiant = Etudiant;
            this.numerosDeCour = cour;
            this.noteDeCour = note;
        }
    }
}

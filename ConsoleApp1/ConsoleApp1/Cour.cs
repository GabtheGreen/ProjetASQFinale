using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cour
    {
        private static int numeroCoursDeBase = 1000000;
        private string titreDeCour { get; set; }
        private string codeDeCour { get; set; }
        private int numerosDeCour { get; set; }

        public Cour(string titre, string code)
        {
            this.numerosDeCour = ++numeroCoursDeBase;
            this.titreDeCour = titre;
            this.codeDeCour = code;
        }

    }
}

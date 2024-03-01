using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vet
{
    public class Turtle : Animal
    {
        public Turtle(string date, string name, string place, string family, string species, double weight) : base (date, name, place, family, species, weight) { }
        public int NewAfectionDegree(int afectionDegree, int option)
        {
            /// <summary>
            /// Mètode que retorna el nou GA
            /// </summary>
            /// <returns>Retorna la nova GA</returns>
            const int X = 5;
            int newAfectionDegree;

            switch (option)
            {
                case 1:
                    newAfectionDegree = (int)(afectionDegree - ((afectionDegree - 2) * (2 * afectionDegree + 3) - X));
                    return newAfectionDegree;

                case 2:
                    newAfectionDegree = (int)(afectionDegree - ((afectionDegree - 2) * (2 * afectionDegree + 3) - X));
                    return newAfectionDegree;
            }
            return X;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace vet
{
    public class Cetacean : Animal
    {
        public Cetacean(string date, string name, string place, string family, string species, double weight) : base(date, name, place, family, species, weight) { }
        public int NewAfectionDegree(int afectionDegree, int option)
        {
            /// <summary>
            /// Mètode que retorna el nou GA
            /// </summary>
            /// <returns>Retorna la nova GA</returns>
            const int XPLACE = 25;
            const int XCRAM = 0;
            int newAfectionDegree;
            
            switch (option)
            {
                case 1:
                    newAfectionDegree = (int)(afectionDegree - Math.Log10(afectionDegree) - XPLACE);
                    return newAfectionDegree;
                        
                case 2:
                    newAfectionDegree = (int)(afectionDegree - Math.Log10(afectionDegree) - XCRAM);
                    return newAfectionDegree;
            }
            return XCRAM;
        } 
    }
}

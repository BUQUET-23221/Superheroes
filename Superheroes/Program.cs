using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.KindOfSuperheroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Alien hero1 = new Alien("CLark", "Kent", "Superman", "Kryptonite", PowerEnum.Fly, PlanetEnum.Krypton);
            human human1 = new human("Peter", "Parker", "Spiderman", "cantKill", PowerEnum.Supersense, "spider");
            Mutant mutant1 = new Mutant("ProfXAvier", "iiii","dontremeber", "incapacityToMove", PowerEnum.Telepathy, "with");
        }
    }
}

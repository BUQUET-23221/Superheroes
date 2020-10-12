using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.KindOfSuperheroes
{
    public class Alien: superheroes
    {
        
        PlanetEnum Planet;

        public Alien(string name, string surname, string heroName, string weakness, PowerEnum power, PlanetEnum planet) //wAy = what are you
            : base(name, surname, heroName,power,weakness)
        {
            Weakness = weakness;
            Planet = planet;
        }
    }
}

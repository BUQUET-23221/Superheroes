using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.KindOfSuperheroes
{
    public abstract class superheroes
    {
        public string Name;
        public string Surname;
        public string HeroName;
        PowerEnum Power;
        public string Weakness;

        public superheroes(string name,string surname,string heroName, PowerEnum power,string weakness)
        {
            Name = surname;
            Surname = surname;
            HeroName = heroName;
            Power = power;
            Weakness = weakness;
        }




    }
}

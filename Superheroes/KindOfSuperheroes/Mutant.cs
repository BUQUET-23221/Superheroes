using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.KindOfSuperheroes
{
    public class Mutant: superheroes
    {
        string WithOrNotXmen;

        public Mutant(string name, string surname, string heroName, string weakness, PowerEnum power,string withOrNotXmen ) //wAy = what are you
            : base(name, surname, heroName,power,weakness)
        {
            WithOrNotXmen = withOrNotXmen;
        }
    }
}

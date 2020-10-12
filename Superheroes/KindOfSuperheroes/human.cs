using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.KindOfSuperheroes
{
    public class human: superheroes
    {

        string Acquisition;

        public human(string name, string surname, string heroName,string weakness, PowerEnum power,string acquisition) //wAy = what are you
            :base(name, surname, heroName,power,weakness)
        {

            Acquisition = acquisition;
        }

        

    }
}

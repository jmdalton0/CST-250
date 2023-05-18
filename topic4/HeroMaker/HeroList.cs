using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class HeroList
    {
        private List<Hero> heroes;

        public HeroList()
        {
            heroes = new List<Hero>();
        }

        public List<Hero> all()
        {
            return heroes;
        }

        public void add(Hero hero)
        {
            heroes.Add(hero);
        }

        public Hero getByName(string name)
        {
            foreach (Hero hero in heroes)
            {
                if (hero.getName() == name)
                {
                    return hero;
                }
            }
            return new Hero();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ThisWorks
{
    class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("A Player Does The Death");
        }
    }

    class Mage : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Mage Whips");
        }
    }

    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Warrior Does The Link");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player());
            players.Add(new Mage());
            players.Add(new Warrior());

            foreach (Player p in players)
            {
                p.Attack();
            }
        }
    }
}
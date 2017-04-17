using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace Lemonade_Stand_game
{
    public class Player
    {
        public Inventory inventory;
        public Purse purse;
        public double dailyMoneyMade;
        public Player()
        {
            inventory = new Inventory();
            purse = new Purse();
            dailyMoneyMade = 0;
    }
        public string GetName()
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome {0}.", playerName);
            return playerName;
        }


    }

}
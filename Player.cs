﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    public class Player

    {

        public Inventory inventory;

        public purse purse;





        public Player()

        {
            inventory = new Inventory();
            this.purse = new purse();
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
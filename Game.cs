using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lemonade_Stand_game

{

    public class Game

    {



        Inventory inventory;
        Player player;
        Store store;
        Day day;
        UserInterface ui;
        private int numberOfDays;

        public Game()
        {
            inventory = new Inventory();
            player = new Player();
            store = new Store();
            day = new Day();
            ui = new UserInterface();
              numberOfDays = 7;
        }
        
        public void StartGame()
        {

            ui.title();
            inventory.inventoryReport();
            RestockOpition(store);
            Console.WriteLine("Press enter to see how your day went");
            Console.ReadLine();
            for (int i = 1; i < numberOfDays; i++)
            {
                store.showStoreMenu(player);
                Console.Clear();
            }


        }
        public void RestockOpition(Store store)
        {
           Console.WriteLine("Would you like to buy some ingredients\n\n\t[Y] or [N]\n");
            string stock = Console.ReadLine();
            if (stock.ToUpper() == "Y")
            {
                Console.Clear();

                store.showStoreMenu(player);
                gameDay();
            }
            else
            {
                 day.setSellingPriceForDay();
                day.sellLemonade();

            }

        }

        public void gameDay()

        {
            day.setSellingPriceForDay();
            Console.ReadLine();
        }

    }
}
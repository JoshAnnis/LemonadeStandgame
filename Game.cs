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
        Weather weather;
        UserInterface ui;
        public Game()
        {
            inventory = new Inventory();
            player = new Player();
            store = new Store();
            day = new Day();
            weather = new Weather();
            ui = new UserInterface();
            
        }
        
        public void StartGame()
        {

            ui.title();
            weather.StartingWeather();
            inventory.inventoryReport();
            RestockOpition(store);
            Console.ReadLine();
        }
        public void RestockOpition(Store store)


        {


            Console.WriteLine("Would you like to buy some ingredients\n\n\t[Y] or [N]\n");
            string stock = Console.ReadLine();
            if (stock.ToUpper() == "Y")
            {
                Console.Clear();

                store.showStoreMenu(this.player);
            }
            else
            {
                 day.setSellingPriceForDay();  

            }

        }

        public void gameDay()

        {


            Console.WriteLine("Now that you got your surplies, are you ready to start your day");
            day.setSellingPriceForDay();


            Console.ReadLine();


        }

    }
}
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Lemonade_Stand_game

{

    public class Game

    {

        Inventory inventory = new Inventory();

        Player player = new Player();

        Store store = new Store();

        int dayNumber = 1;

        Day day = new Day();

        Weather weather = new Weather();

        UserInterface ui = new UserInterface();







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



                // day.setSellingPriceForDay();



            }





        }



        public void gameDay()

        {

            Console.WriteLine("Now that you got your surplies, are you ready to start your day");

            Console.ReadLine();

        }







    }

}
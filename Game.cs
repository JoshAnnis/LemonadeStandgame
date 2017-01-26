using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    class Game
    {
        Inventory inventory = new Inventory();
        Player player = new Player();
        Store store = new Store();
        Store showStoreMenu;
        int dayNumber = 1;
        Day day = new Day();

        



        public void StartGame()
        {

            
            Console.WriteLine("Welcome to Lemonade Stand\nDo you have what it takes to start you lemonade stand empire?");
            Console.WriteLine("If you think you have what it takes then you have to prove it cupcake but let me tell you it's not going to be easy");
            Console.WriteLine("but since you seem so sure that you wont fail then by all means prove yourself");
            Console.WriteLine("But fist you have to get ingredients so head on over to the store and pick some up.");
            inventory.inventoryReport();
            RestockOpition(this.store);
            
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

  

    }
}

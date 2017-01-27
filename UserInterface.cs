using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    public class UserInterface
    {



        public UserInterface()
            {

            }
        public void title()
        {
            Console.WriteLine("Welcome to Lemonade Stand\nDo you have what it takes to start you lemonade stand empire?\n");

            Console.WriteLine("If you think you have what it takes then you have to prove it cupcake but let me tell you it's not going to be easy\n");

            Console.WriteLine("but since you seem so sure that you wont fail then by all means prove yourself\n");

            
            Console.WriteLine("=====================================================================================================");

            Console.WriteLine("\n-RULES-");

            Console.WriteLine("__________");

            Console.WriteLine("\nYou will have one week,to make as much money as you can by selling lemonade.");

            Console.WriteLine("\nAt the beginning of each day, the weather  will be displayed.");

            Console.WriteLine("     -It is in your best interest to pay attention to this so you can maximize your sales.");

            Console.WriteLine("\nYou will then have the chance to buy supplies at the store, change your recipe, make and sell lemonade.");

            Console.WriteLine("     -In order to sell lemonade, you will need to  ");

            Console.WriteLine("\nYou have $20 to your name. Good luck!");

            Console.WriteLine("=====================================================================================================");

            Console.ReadKey();
        }
    }
}

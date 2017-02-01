using Lemonade_Stand_game;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Lemonade_Stand_game

{

    public class Day
    {

        Customer customer = new Customer();


        List<string> dayOfTheWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public Day()

        {

        }

        public void ChooseDays(Weather weather, Game game, Purse purse, Store store, Inventory inventory, Customer customer, Day day)

        {

            foreach (var dayOfTheWeek in dayOfTheWeek)

            {

                Console.WriteLine("Today is {0}", dayOfTheWeek);



            }

        }

    }
}
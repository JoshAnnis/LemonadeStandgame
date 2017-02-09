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
        List<Customer> customers = new List<Customer> { };
        List<string> day = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public decimal SetPrice = 0;
        public Day()


        {


        }


        public void ChooseDays(Weather weather, Game game, Purse purse, Store store, Inventory inventory, Customer customer, Day day)
        {
            foreach (var dayOfTheWeek in this.day)

            {

                Console.WriteLine("Today is {0}", dayOfTheWeek);
            }

        }
        public void setSellingPriceForDay()
        {
            Console.WriteLine("Your price for each cup of lemonade is $[0.25]:Do you want to keep it or [change] it?");
            string changeprice = Console.ReadLine();
            if (changeprice == "change")
            {
                Console.Write("\nEnter the price you want to charge per cup for today.\n");
                decimal newPriceForToday = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nTodays price is ( $ " + (newPriceForToday) + " )");
                SetPrice = newPriceForToday;
            }


            else
            {
                Console.WriteLine("Alright lets play");
            }




        }
  }
}
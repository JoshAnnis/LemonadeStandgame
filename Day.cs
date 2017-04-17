using Lemonade_Stand_game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace Lemonade_Stand_game


{

    public class Day
    {
        Weather weather = new Weather();
        List<Customer> customers = new List<Customer> { };
        public decimal SetPrice = 0.25M;
        public double dayProfit;
        Customer customer = new Customer();
        private int cashMoney = 15;



        public void setSellingPriceForDay()
        {
            Console.Clear();
            weather.StartingWeather();
            Console.WriteLine("Your price for each cup of lemonade is $[0.25]: Would you like to change it [Y] or [N]");
            string changeprice = Console.ReadLine();
            if (changeprice.ToUpper() == "Y")
            {
                Console.Write("\nEnter the price you want to charge per cup for today.\n");
                decimal newPriceForToday = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nTodays price is ( $ " + (newPriceForToday) + " )");
                SetPrice = newPriceForToday;
                getCustomers();
            }


            else
            {
                getCustomers();

            }
        }

        public void getCustomers()
        {
            for (int i = 0; i < weather.temperature; i++)

            {



                customers.Add(customer);


            }

        }


      

        public void DailyReoprt(Player player)
        {

            Console.WriteLine("You have {0}$", player.purse.purseBalance);
            Console.ReadLine();

        }


        public void sellLemonade(Player player)
        {
            customer.Mightbuy(weather);
            if (customer.isThirsty == true)
            {
               
                player.inventory.paperCupList.RemoveRange(1, 20);
                player.inventory.iceList.RemoveRange(1, 20);
                player.inventory.lemonList.RemoveRange(1, 11);
                player.inventory.sugarList.RemoveRange(1, 11);
                player.purse.purseBalance += cashMoney;
            }
        }

       

        




    }
}
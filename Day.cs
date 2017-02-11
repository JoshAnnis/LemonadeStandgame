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
        public decimal SetPrice = 0.25M ;
        





       
        public void startDay()
        {
        }
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

                Customer customer = new Customer();

                customers.Add(customer);

            }
        }


        public void sellLemonade()
        {
            
        }



       

       

    }
}
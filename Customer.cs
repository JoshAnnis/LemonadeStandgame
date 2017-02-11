using Lemonade_Stand_game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lemonade_Stand_game
{
    public class Customer
    {






        bool isThirsty;

        double willingnessToPay;




        public Customer()
            {
            Random random = new Random();
            isThirsty = true;
            willingnessToPay = random.Next(30, 80);

            }
        public void Mightbuy(Player player, Weather weather)
        {

            if (weather.TemperatureGenerator() > 40)
            {
                willingnessToPay *= 0.55;
            }
            else if ((weather.TemperatureGenerator() > 50) && (weather.TemperatureGenerator() <= 60))
            {
                willingnessToPay *=1.0;
            }
            else if ((weather.TemperatureGenerator() > 65) && (weather.TemperatureGenerator() <= 75))
            {
                willingnessToPay *=1.5;
            }
            else if ((weather.TemperatureGenerator() > 80) && (weather.TemperatureGenerator() <= 101))
            {
                willingnessToPay *=2.5;
            }


        }





        public bool customerIsThirsty()
        {
            if(willingnessToPay < 34)
            {
                isThirsty = false;
            }
            return isThirsty;
        }
    }
}


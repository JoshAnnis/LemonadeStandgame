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
         public bool isThirsty;
        double willingnessToPay;
        public int CashMoney = 20;
            public Customer()
            {
            Random random = new Random();
            isThirsty = true;
            willingnessToPay = random.Next(30, 80);
           

    }
        public void Mightbuy(Weather weather)
        {

            if (weather.temperature < 40)
            {
                willingnessToPay *= 0.55;

            }
            else if ((weather.temperature > 50) && (weather.temperature <= 60))
            {
                willingnessToPay *=1.0;
            }
            else if ((weather.temperature > 65) && (weather.temperature <= 75))
            {
                willingnessToPay *=1.5;
            }
            else if ((weather.temperature > 80) && (weather.temperature <= 101))
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    class Weather
    {

        int temperature;
        string cond;
      
        public void StartingWeather()
        {
            TemperatureGenerator();
            CondGenerator();
            Console.WriteLine("The Weather forcast for today is " + temperature +  " degress " + cond+ "");
            Console.ReadLine();
        }


        public int TemperatureGenerator()
        {
            Random random = new Random();
            temperature = random.Next(40, 110);
            return temperature;
        }

        public void CondGenerator()
        {
            int randomCond;
            Random random = new Random();
            randomCond = random.Next(1, 5);
            if (randomCond == 1)
            {
                cond = "Clear and Sunny";
            }
            else if (randomCond==2)
            {
                cond = "overcast";
            }
            else if (randomCond == 3)
            {
                cond = "raniny";
            }
            else if (randomCond == 4)
            {
                cond = "Partly cloudly";
            }


        }
    }
}
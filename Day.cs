using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    class Day
       {
        Weather weather = new Weather();
        public int day1;

         public void GetWeather()
        {
            weather.StartingWeather();
            weather.CondGenerator();

        }
        


        public void StartingDay()
        {

        }



    }
     
}

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Lemonade_Stand_game

{

   public  class Weather

    {



      public  int temperature;

        public string condition;



        public void StartingWeather()

        {

            TemperatureGenerator();

            ConditionGenerator();

            Console.WriteLine("The Weather forcast for today is " + temperature + " degress " + condition + "");

            Console.ReadLine();

        }





        public int TemperatureGenerator()

        {

            Random random = new Random();

            temperature = random.Next(40, 101);

            return temperature;

        }



        public void ConditionGenerator()

        {

            int randomCondition;

            Random random = new Random();

            randomCondition = random.Next(1, 5);

            if (randomCondition == 1)

            {

                condition = "Clear and Sunny";

            }

            else if (randomCondition == 2)

            {

                condition = "Stormy";

            }

            else if (randomCondition == 3)

            {

                condition = "Rainy";

            }

            else if (randomCondition == 4)

            {

                condition = "Partly cloudly";

            }





        }

    }

}
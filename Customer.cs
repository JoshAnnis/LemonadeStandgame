using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    class Customer
    {
        Random random = new Random();
        string name;
        



        public void CustomerRandomizer()
        {
            string[] Customers = new string[40] { "Peter", "Heriberto", "Kent", "Lee", "Olen", "Bryant", "Lucius", "Ramo", "Rigoerto", "Booker", "Matthew", "Tommie", "Steven", "Nick", "Haywood", "Zachariah", "Andreas", "Waylon", "Columbus", "Peter", "Kaylee", "Vicenta", "Mireya", "Lashawnda", "Jackelyn", "Ronna", "Nova", "Georgine", "Ashely", "Antonette", "Sunday", "Ming", "Blanca", "Lashandra", "Latrice", "Mamie", "Patti", "Debby", "Valeri", "Shirely" };
            string firstNames = Customers[random.Next(0, 40)];
            name = Customers + "";
            }



        public void Mightbuy(Player player, Weather weather)
        {

        }








    }
}
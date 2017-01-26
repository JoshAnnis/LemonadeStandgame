using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    public class Inventory

    {

        public List<ice> iceList;

        public List<lemons> lemonList;

        public List<paperCups> paperCupList;

        public List<sugar> sugarList;

        public  Inventory()

        {
            iceList = new List<ice>();

            lemonList = new List<lemons>();

            paperCupList = new List<paperCups>();

            sugarList = new List<sugar>();

        }

        public void inventoryReport()

        {



            Console.WriteLine("Ice cubes on hand are\t\t[" + (iceList.Count) + "]" + "\nLemons on hand are\t\t[" + (lemonList.Count) + "]" + "\nPaper cups on hand are\t\t[" + (paperCupList.Count) + "]" + "\nCups of Sugar on hand are\t[" + (sugarList.Count) + "]");
            Console.ReadLine();

        }
    }
}
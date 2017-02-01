using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    public class Inventory

    {

        public List<Ice> iceList;

        public List<Lemons> lemonList;

        public List<PaperCups> paperCupList;

        public List<Sugar> sugarList;

        public  Inventory()

        {
            iceList = new List<Ice>();

            lemonList = new List<Lemons>();

            paperCupList = new List<PaperCups>();

            sugarList = new List<Sugar>();

        }

        public void inventoryReport()

        {
            Console.WriteLine("\nIce cubes on hand are\t\t[" + (iceList.Count) + "]" + "\nLemons on hand are\t\t[" + (lemonList.Count) + "]" + "\nPaper cups on hand are\t\t[" + (paperCupList.Count) + "]" + "\nCups of Sugar on hand are\t[" + (sugarList.Count) + "]");
            Console.ReadLine();

        }
    }
}
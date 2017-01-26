using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_game
{
    
    public class Store
    {
        
        public decimal singleIceCube = .0075M, singleLemon = .075M, singleCupOfSugar = .075M, singlePaperCup = .0075M;

        public decimal ice100Unit = 1.00M, ice250Unit = 2.25M, ice300Unit = 3.50M;

        public decimal lemons10Units = .75M, lemons25Units = 1.75M, lemons75Units = 2.75M;

        public decimal cups100Unit = 1.75M, cups250Unit = 2.25M, cups300Unit = 3.50M;

        public decimal sugar10Unit = .75M, sugar30Unit = 2.00M, sugar75Unit = 6.50M;
        





        public void showStoreMenu(Player player)
        {
            Console.WriteLine("Welcome to the store here you can buy all the ingredients that you will need");
            Console.WriteLine("What would you like to over purchase today?\n\n[1] Paper Cups\n[2] Lemons\n[3] Sugar\n[4] Ice\nor exit");

            Console.Write("Please enter one of the store choices");

            string storeChoice = Console.ReadLine();

            if (storeChoice == "1")

            {

                buyMoreCups(player);

            }

            else if (storeChoice == "2")

            {

                buyMoreLemons(player);

            }

            else if (storeChoice == "3")

            {

                buyMoreSugar(player);

            }

            else if (storeChoice == "4")

            {

                buyMoreIce(player);

            }
            else 
            {
                Console.WriteLine("Are you sure your ready to leave the store? \n\n\t[Y] or [N]\n");
                string Leave = Console.ReadLine();
                if (Leave == "Y")
                {


                    this.LeaveStore;
                        {

                    }
                    
                }




            }

        }
        public void buyMoreCups(Player player)

        {

            Console.Clear();



            Console.WriteLine("You have $" + (player.purse.purseBalance) + " in your cashbox.\n\n");

            Console.WriteLine("Select a quantity for your order.\n\n[1]\t100  Cups for $1.75\n[2]\t250  Cups for $2.25\n[3]\t300 Cups for $3.50\n\n");

            Console.Write("Your choice ");

            string usersChoice = Console.ReadLine();



            if (usersChoice == "1")

            {

                for (int i = 0; i < 100; i++)

                {

                    player.inventory.paperCupList.Add(new paperCups());

                }

                player.purse.purseBalance -= cups100Unit;

            }

            else if (usersChoice == "2")

            {

                for (int i = 0; i < 250; i++)

                {

                    player.inventory.paperCupList.Add(new paperCups());

                }

                player.purse.purseBalance -= cups250Unit;

            }

            else if (usersChoice == "3")

            {

                for (int i = 0; i < 300; i++)

                {

                    player.inventory.paperCupList.Add(new paperCups());

                }

                player.purse.purseBalance -= cups300Unit;

            }

            player.inventory.inventoryReport();

            Console.WriteLine("\nThis is your new cashbox balance " + (player.purse.purseBalance));

            showStoreMenu(player);

        }

        public void buyMoreLemons(Player player)

        {

            Console.Clear();



            Console.WriteLine("\nSelect a quantity for your order.\n\n [1] \t10 Lemons for $.75 \n [2] \t25 Lemons for $1.75 \n [3] \t75 Lemons for $2.75\n");

            Console.Write("Your choice ");

            string usersChoice = Console.ReadLine();

            if (usersChoice == "1")

            {

                for (int lemons = 0; lemons < 10; lemons++)

                {

                    player.inventory.lemonList.Add(new lemons());

                }

                player.purse.purseBalance -= lemons10Units;

            }

            else if (usersChoice == "2")

            {

                for (int lemons = 0; lemons < 25; lemons++)

                {

                    player.inventory.lemonList.Add(new lemons());

                }

                player.purse.purseBalance -= lemons25Units;

            }

            else if (usersChoice == "3")

            {

                for (int lemons = 0; lemons < 75; lemons++)

                {

                    player.inventory.lemonList.Add(new lemons());

                }

                player.purse.purseBalance -= lemons75Units;

            }
            player.inventory.inventoryReport();
            Console.WriteLine("\n\nThis is your new cashbox balance $ " + (player.purse.purseBalance));
            showStoreMenu(player);


        }

        public void buyMoreSugar(Player player)

        {

            Console.Clear();



            Console.WriteLine("\nSelect a quantity for your order.\n\n[1]\t10 Cups for $.75\n[2]\t30 Cups for $2.00\n[3]\t75 Cups $6.50");

            string usersChoice = Console.ReadLine();

            Console.Write("Your choice ");

            if (usersChoice == "1")

            {

                for (int i = 0; i < 10; i++)

                {

                    player.inventory.sugarList.Add(new sugar());

                }

                player.purse.purseBalance -= ice100Unit;

            }

            else if (usersChoice == "2")

            {

                for (int i = 0; i < 30; i++)

                {

                    player.inventory.sugarList.Add(new sugar());

                }

                player.purse.purseBalance -= ice300Unit;

            }

            else if (usersChoice == "3")

            {

                for (int i = 0; i < 75; i++)

                {

                    player.inventory.sugarList.Add(new sugar());

                }

                player.purse.purseBalance -= ice250Unit;

            }
            player.inventory.inventoryReport();
            Console.WriteLine("\n\nThis is your new balance " + (player.purse.purseBalance));

            showStoreMenu(player);

        }

        public void buyMoreIce(Player player)

        {

            Console.Clear();



            Console.WriteLine("\nSelect a quantity for your order.\n\n[1]\t100 Cubes for $1.00\n[2]\t250 Cubes for $2.25\n[3]\t300 Cubes for $3.50");

            Console.Write("Your choice ");

            string usersChoice = Console.ReadLine();

            if (usersChoice == "1")

            {

                for (int i = 0; i < 100; i++)

                {

                    player.inventory.iceList.Add(new ice());

                    player.purse.purseBalance -= singleIceCube;

                }

            }

            else if (usersChoice == "2")

            {

                for (int i = 0; i < 250; i++)

                {

                    player.inventory.iceList.Add(new ice());

                    player.purse.purseBalance -= (singleIceCube * .8M);

                }

            }

            else if (usersChoice == "3")

            {

                for (int i = 0; i < 300; i++)

                {

                    player.inventory.iceList.Add(new ice());

                    player.purse.purseBalance -= (singleIceCube * .8M);

                }

            }
            player.inventory.inventoryReport();
            Console.WriteLine("\n\nThis is your new balance " + (player.purse.purseBalance));
            showStoreMenu(player);                       
        }       
       
    }
    }

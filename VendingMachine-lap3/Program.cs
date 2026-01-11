using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_lap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object
            VendingMachine__lap3 vendingMachinelap3A = new VendingMachine__lap3(10000, 10000, 10000, 10000);
            bool isRuning = true;

            while (isRuning)
            {
                //menu interface
                Console.WriteLine("------------------------");
                Console.WriteLine("Wellocome to Vending Machine");
                Console.WriteLine("------------------------");
                Console.WriteLine("1 : Buy Black Coffee");
                Console.WriteLine("2 : Buy Mocha");
                Console.WriteLine("3 : But Latte");
                Console.WriteLine("4 : Buy chocoLate");
                Console.WriteLine("5 : Show stock");
                Console.WriteLine("6 : Increase stock");
                Console.WriteLine("0 : Exit program");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            vendingMachinelap3A.Buyblackcoffee(IAmount);
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            vendingMachinelap3A.Buymocha(IAmount);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            vendingMachinelap3A.Buylatte(IAmount);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            vendingMachinelap3A.Buychocolate(IAmount);
                            break;
                        }
                    case "5":
                        {
                            vendingMachinelap3A.ShowStock();
                            break;
                        }

                    case "6":
                        {
                            vendingMachinelap3A.IncreaseStock(5000, 5000, 5000, 5000);
                            break;
                        }

                    case "0":
                        Console.WriteLine("Thank you! Goodbye.");
                        isRuning = false; // เปลี่ยนค่าเป็น false เพื่อออกจาก while loop
                        break;
                    default:
                        Console.WriteLine("Wrong input Try again");
                        break;
                }

            }
        }
    }
}

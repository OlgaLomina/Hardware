using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAPI
{
    class Program
    {

        static void Main(string[] args)
        {
            //var device = new Keyboard();
            //device.Id = 1;
            //device.Model = "MB110LL/B";
            //device.SerialNumber = "1508LZ00AR68";
            //device.Price = 34.18M;
            //device.Count = 10;

            //Stock.AddKeyboard(device);

            //device = new Keyboard();
            //device.Id = 2;
            //device.Model = "MK200";
            //device.SerialNumber = "6108LZ0034DF";
            //device.Price = 29.99M;
            //device.Count = 35;

            //Stock.AddKeyboard(device);

            Console.WriteLine("****Welcome****");
            int choice = -1;
            bool invalidChoice = false;

            while (choice !=0 || invalidChoice )
            {
                Console.WriteLine("1. Add a keyboard to the stock");
                Console.WriteLine("2. Sale a keyboard from the stock");
                Console.WriteLine("3. Return a keyboard to the stock");
                Console.WriteLine("0. Exit");
                Console.Write("Please choose an option: ");

                var input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    invalidChoice = true;
                    Console.WriteLine("Invalid choice. Try again...");
                    continue;
                }
                invalidChoice = false;

                //if (choice == 1)
                //{
                //}
                //else if (choice == 2)
                //{
                //}
                //else if (choice == 3)
                //{
                //}
                //else
                //{
                //}
                switch (choice)
                {
                    case 1:
                        Console.Write("Model: ");
                        var model = Console.ReadLine();
                        Console.Write("Price: ");
                        decimal price;
                        if (!decimal.TryParse(Console.ReadLine(), out price))
                            return;

                        var keyboard = new Keyboard();
                        keyboard.Model = model;
                        keyboard.Price = price;
                        keyboard.BrandId = 1;
                        Stock.AddKeyboard(keyboard);
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
                //Console.WriteLine(choice);
            }
            
            //Console.WriteLine(choice);

            //Stock.CreateKeyboards();
            
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     i hope you think this is good because its stolen hours from me
            // 
            double price = 0; //defining price outside of the loop so it isnt overwritten
            bool running = true; //defining loop so the whole thing can loop if user wants to buy more
            while (running == true) //program repeats
            {
                Console.WriteLine("Welcome to the vending machine. We sell soda, cookies, and chips.\nWhat would you like?");
                bool inSelection = true;
                while (inSelection == true) //loop so this can be reused if user enters invalid number
                        {
                    Console.WriteLine("Type 1 for soda, 2 for cookies, 3 for chips");
                    string selection = Console.ReadLine();
                    if (Convert.ToInt32(selection) == 1) //user picks soda
                    {
                        Console.WriteLine("\nYou've selected soda. Soda is $1 each.");
                        inSelection = false;
                        Console.WriteLine("Please enter the amount of sodas you'd like to purchase as an integer, or type 0 to return to the selection interface");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num > 0) //if user enters correct number
                        {
                            int sodas = num;
                            price = price + sodas;
                            Console.WriteLine("You've purchased " + num + " sodas for a total of $" + sodas);
                        }
                        else //if user enters invalid number
                        {
                            Console.WriteLine("You have entered an invalid number. Returning you to the selection interface...");
                            inSelection = true;
                            //loops back to line 19
                        }
                    }
                    else if (Convert.ToInt32(selection) == 2) //user picks cookies
                    {
                        Console.WriteLine("\nYou've selected cookies. Cookies are $2 each.");
                        inSelection = false;
                        Console.WriteLine("Please enter the amount of cookies you'd like to purchase as an integer, or type 0 to return to the selection interface");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num > 0)
                        {
                            int cookies = num * 2;
                            price = price + cookies;
                            Console.WriteLine("You've purchased " + num + " cookies for a total of $" + cookies);
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid number. Returning you to the selection interface...");
                            inSelection = true;
                            //loops back to line 19
                        }
                    }
                    else if (Convert.ToInt32(selection) == 3) //user picks chips
                    {
                        Console.WriteLine("\nYou've selected chips. Chips are $1.50 each.");
                        inSelection = false;
                        Console.WriteLine("Please enter the amount of chips you'd like to purchase as an integer, or type 0 to return to the selection interface");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num > 0)
                        {
                            double chips = num * 1.5;
                            price = price + chips;
                            Console.WriteLine("You've purchased " + num + " chips for a total of $" + chips);
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid number. Returning you to the selection interface...");
                            inSelection = true; //loops back to line 19
                        }
                    }
                    else //user inputs an invalid argument
                    {
                        Console.WriteLine("Invalid expression. Please input again.");
                        //loops back to line 19
                    }
                }
                Console.WriteLine("Your total price is now $" + price); //total price
                Console.WriteLine("Would you like to buy more? input Y or N"); //asking user if they want to buy more
                bool choosing = true; 
                string choice = Console.ReadLine();
                while (choosing == true) //loops in event of invalid entry
                {
                    if (choice == "Y") //defining a yes
                    {
                        inSelection = true;
                        choosing = false;
                        //loops back to beginning
                    }
                    else if (choice == "N") //defining a no
                    {
                        inSelection = false;
                        choosing = false;
                        running = false; //this breaks the loop and user can exit
                    }
                    else //invalid entry
                    {
                        Console.WriteLine("You have entered an invalid expression. Please type Y or N exactly\n this is cAsE sEnSiTiVe");
                        choosing = true;
                        //loops back to line 89
                    }
                } 
            }
            Console.WriteLine("\nThank you for using the vending machine.");
            Console.WriteLine("\nYour total is $" + price); //showing total price
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey(); //allowing user to exit
            //program ends
        }
    }
}

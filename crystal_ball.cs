using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crystal_ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //below: creating list of prediction answers
            List<string> prediction = new List<string>() { "It is certain", "It is decidedly so", "Yes", "Hazy", "Ask again later", "My answer is no", "Concentrate and ask again", "Outlook not good", "Doubtful" };
            Console.WriteLine("You have come upon a magic crystal ball. \nAsk any yes/no question, and it will respond with one of the following outcomes\n"); //introductory sentence
            System.Threading.Thread.Sleep(1000);
            foreach (string i in prediction)
            {
                Console.WriteLine(i); //writing all possible output
                System.Threading.Thread.Sleep(500);
            }
            System.Threading.Thread.Sleep(1000); //waits
            Console.WriteLine("\nPress any key to clear the screen");
            Console.ReadKey(); 
            while (true) //loop
            {
                Console.Clear(); //clears screen
                Console.WriteLine("Now, ask any question, and I will predict your fate.\n");
                Console.ReadLine(); //allows input so it seems more legit
                Console.WriteLine("Hmmm....");
                System.Threading.Thread.Sleep(1500);
                Random rnd = new Random(); //creating random class
                int predictionNum = rnd.Next(10); //generate random
                Console.WriteLine("\n" + prediction[predictionNum]); //generate predcition off of random number
                System.Threading.Thread.Sleep(500); //waits a second for user to read
                Console.WriteLine("Press y to ask another question, or press any other key to exit."); //prompting user to play again or not
                if (Console.ReadKey().Key != ConsoleKey.Y) //if user does not input y
                {
                    break;
                }
            }


        }
    }
}

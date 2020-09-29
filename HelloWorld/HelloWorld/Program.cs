using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{//Task : Write a program that prints ‘Hello World’ to the screen. 
 //Additionally ask the user's name and display it with the message "Hello World" 
    class Program
    {
        static void Main(string[] args)
        {
            // CREATE NAME WHICH WILL BE STRING
            string name;

            //DISPLAY MESSAGE BEGGING FOR USER'S NAME
            Console.WriteLine("Please entr your name (:");

            //READ THE INPUT OF COURSE
            name = Console.ReadLine();

            //DISPLAY THE USER'S NAME WITH THE SPECIAL MESSAGE TO THE WORLD 
            Console.WriteLine($"Hello World my name is :{name}");

            // SHOULD BE OUTSIDE OF THE WHILE DO LOOP
            string choice;
            do
            {
                //ASK AGAIN
                Console.WriteLine("Do you want to display goodbye message? (y or n)");
                string yes;
                yes = Console.ReadLine();

                if (yes == "y")
                {
                    Console.WriteLine("Bye and have a good day/evening");
                }
                else
                {
                    Console.WriteLine("Press to any keyword to exit (:");
                }

                Console.WriteLine("Do you want to exit?");
                choice = Console.ReadLine();

                //CHECK IF THE UER WANTS TO EXIT AND FORCE IT TO EXIT THE APPLICATION IN NET.FRAMEWORK ENVIRONMENT
                if (choice == "Y" || choice == "y" || choice=="yes" || choice=="YES" || choice=="" || choice==" ")
                {
                    Environment.Exit(-1);
                }

            }
            while (choice=="n" || choice=="N");

            //DO NOT FORGET CONSOLE.READLINE() OR CONSOLE.READKEY();
            Console.ReadKey();
        }
    }
}

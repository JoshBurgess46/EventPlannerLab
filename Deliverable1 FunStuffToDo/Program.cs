using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1_FunStuffToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //part of different method.
            string pack, /*Action, Chilling, Danger, Food,*/ activity;
            int a;
        /*Action = Convert.ToString(Console.ReadLine());
        // Chilling = Convert.ToString(Console.ReadLine());
        //Danger = Convert.ToString(Console.ReadLine());
        // Food = Convert.ToString(Console.ReadLine());*/
        
            Console.Write("Hello! Welcome to Event Planner. Whats your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hey " + name + "! What would you like to do today?");


            Console.WriteLine("Pick which adventure you'd like to go on?" +
                " Action, " +
                " Chilling, " +
                " Danger, " +
                " Food.");
            activity = Console.ReadLine();
            switch (activity)
            {
                case "Chilling":
                case "chilling":
                case "CHILLING":
                    Console.WriteLine("Sounds relaxing! Lets take a walk on the local beach.");
                    goto there;
                case "Action":
                case "action":
                case "ACTION":
                    Console.WriteLine("Awesome! John Wick is playing in the local theater today!");
                    goto there;
                case "Danger":
                case "danger":
                case "DANGER":
                    Console.WriteLine("Woah! Looks like we have an adrenaline junkie here. There is a spot off the coast here where you can swim with the sharks!");
                    goto there;
                case "Food":
                case "food":
                case "FOOD":
                    Console.WriteLine("Yum! My favorite choice. There is a 5 star Mexican resturaunt close by.");
                    goto there;
            }
            //was trying to use a different method.
        /* here:
             Console.WriteLine(
                 "I have a few ideas!(Pick a number!);\n" +
                 "1. The movies are showing John Wick. \n" +
                 "2. Swim with sharks!\n" +
                 "3. Take a relaxing stroll on the beach.\n" +
                 "4. Get some food!");*/
        //  pickone = Console.ReadLine();
        //a = Convert.ToInt32(pickone);

        there:
            Console.WriteLine("How many people are you going with?");
            pack = Console.ReadLine();
            a = Convert.ToInt32(pack);

            if ((a == 0))
            {

                Console.WriteLine("Nothings better then taking the Heel Toe Express. Lets walk!");

            }

            if ((a >= 1) && (a <= 4))
            {
                Console.WriteLine("Lets take a sedan there.");
            }

            if ((a >= 5) && (a <= 10))
            {
                Console.WriteLine("Awesome! The gangs all here! Lets take a Volkswagon bus there.");
            }

            if ((a >= 11) && (a <= 100))
            {
                Console.WriteLine("Wow! brought the whole squad, awesome. I recommend we take an airplane there.");

            }
           
            Console.WriteLine("Thanks for using Event Planner! Have a great day.");
            Console.ReadLine();
        }
       


    }
}

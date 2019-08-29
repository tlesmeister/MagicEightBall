using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class Magic8Ball
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic 8 Ball!");
            Console.Title = "8 Ball is All Knowing!";

            /*
             * Requirments
             * 1. Ask the user their yes or no question. 
             * 2. Respond with a random answer from you set (collection) of answers. 
             * 3. Set the program to loop based on user choice. 
             */

            //Do I spend a million dollars today?
            //Answers - Yes, No, Never

            Console.WriteLine("Hi, please ask your yes or no question?");
            Console.ReadLine();
            string[] allTheAnswers = { "Whatever floats your boat! ", "You only live once.", "What kind of question is that?", "That's ridiculous!", "Wow, next question", "Bad Idea", "abso-freakin-lutely ", "Cannot predict now.", "Ask again later", "Very doubtful.", "Without a doubt"};
            Random r = new Random();
            int index = r.Next(allTheAnswers.Length);
            Console.WriteLine(allTheAnswers[index]);
            
            bool repeat = true;


            do
            {
                Console.WriteLine("Would you like to ask another question Y:N?");
                string userInput = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userInput)
                {
                    case "Y":
                    case "YES":

                        Console.WriteLine("Please ask your question");
                        Console.ReadLine();
                        Random s = new Random();
                        int indexOne = s.Next(allTheAnswers.Length);
                        Console.WriteLine(allTheAnswers[indexOne]);
                        break;

                    case "N":
                    case "NO":
                        Console.WriteLine("Thank you for playing, the game have a good day!");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }//end Switch

            } while (repeat);
            

        }//end Main()
    }//end class
}//end namespace


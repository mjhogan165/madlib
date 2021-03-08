using System;

namespace Mad_Man_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
   This program ...Mad Libs  
   Author: ... Matt
   */


            // Let the user know that the program is starting:
            Console.WriteLine("WELCOME TO MAD LIBS");
           
            Console.WriteLine("****************");
            Console.WriteLine();
            // Give the Mad Lib a title:
            string title = "GARRET AND BRAD: Space Adventures";
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("****************");

          

          

            //adjectives
            Console.WriteLine("Please enter an adjective");
            string adjOne = Console.ReadLine();
            Console.WriteLine("Please enter an adjective");
            string adjTwo = Console.ReadLine();
            Console.WriteLine("Please enter an adjective");
            string adjThree = Console.ReadLine();
            Console.WriteLine("Please enter an adjective");
            string adjFour = Console.ReadLine();
            Console.WriteLine("Please enter an adjective");
            string adjFive = Console.ReadLine();
            

            //verbs
            Console.WriteLine("Please enter a verb");
            string verbOne = Console.ReadLine();
            Console.WriteLine("Please enter a verb");
            string verbTwo = Console.ReadLine();
            Console.WriteLine("Please enter a verb");
            string verbThree = Console.ReadLine();
            Console.WriteLine("Please enter a verb");
            string verbFour = Console.ReadLine();
            Console.WriteLine("Please enter a verb");
            string verbFive = Console.ReadLine();

            //emotions
            Console.WriteLine("Please enter an emotion");
            string eOne = Console.ReadLine();
            Console.WriteLine("Please enter an emotion");
            string eTwo = Console.ReadLine();
            Console.WriteLine("Please enter an emotion");
            string eThree = Console.ReadLine();

            Console.WriteLine("Please enter an adverb");
            string adverb = Console.ReadLine();

            //specifics
            Console.WriteLine("Please enter a place");
            string place = Console.ReadLine();
            Console.WriteLine("Please enter an animal");
            string animal = Console.ReadLine();
            Console.WriteLine("Please enter a celebrity");
            string celebrity = Console.ReadLine();
            Console.WriteLine("Please enter a fictional character name");
            string ficChar = Console.ReadLine();
            Console.WriteLine("Please enter a retail business");
            string retBus = Console.ReadLine();
            Console.WriteLine("Please enter a vehicle");
            string vehicle = Console.ReadLine();
            Console.WriteLine("Please enter an object");
            string objectOne = Console.ReadLine();
            Console.WriteLine("Please enter an object");
            string objectTwo = Console.ReadLine();
            Console.WriteLine("Please enter a tool");
            string tool = Console.ReadLine();
            Console.WriteLine("Please enter a common saying or phrase");
            string phrase = Console.ReadLine();
            Console.WriteLine("Please enter a body part");
            string body = Console.ReadLine();
            // The template for the story:

            string story1 = $"Brad and Garret are visiting a {adjOne} planet called {place} that is inhabited by a hybrid species that is half-{animal} and half-{celebrity}. ";
            string story2 = $"Suddenly, a {adjTwo} mutant entity appears and begins tearing up the planetary surface with its {body}!";
            string story3 = $"There is little known about this entity, but the local population call it {ficChar}. Brad and Garret ";
            string story4 = $"seek refuge in a nearby {retBus} while the locals perish. ";
            string story5 = $"In a {adjThree} debate, Brad and Garret try to decide how they should respond.";
            string story6 = $"to this attack. On the one hand, Brad is feeling {eOne} and suggests we should {verbOne}. While garret feels {eTwo} and believes we should try to {verbTwo}. ";
            string story7 = $"Brad and Garret hop in their trusty {adjFour} {vehicle} and pursue the evil monster through space. In a state of panic,";
            string story8 = $"Garret grabs his favorite {objectOne} and {verbThree}s at the entity. His attempt fails! Brad finds an old {tool} on the ground and tries to {adverb} {verbFour} the entity.";
            string story9 = $"“{phrase}!!!” Garret exclaims!";
            string story10 = $"The creature is {eTwo}. ";
            string story11 = $"In a desperate attempt at redemption, Brad finds an old {adjFive} {objectTwo} on the ground and throws it at the entity.";
            string story12 = $"It is a success! Finally our heroes can {verbFive} in peace.";
            // Print the story:

            Console.WriteLine();
            Console.WriteLine("Here is the story!");
            Console.WriteLine();
            Console.WriteLine("Enjoy!!!");
            Console.WriteLine();
            Console.WriteLine("*****************");

            Console.WriteLine(story1);
            Console.WriteLine(story2);
            Console.WriteLine(story3);
            Console.WriteLine(story4);
            Console.WriteLine();
            Console.WriteLine(story5);
            Console.WriteLine(story6);
            Console.WriteLine(story7);
            Console.WriteLine(story8);
            Console.WriteLine();
            Console.WriteLine(story9);
            Console.WriteLine(story10);
            Console.WriteLine();
            Console.WriteLine(story11);
            Console.WriteLine(story12);
            Console.WriteLine();
           
            Console.WriteLine("The End");
            Console.WriteLine();
            Console.WriteLine("*********************");
        }
    }
}

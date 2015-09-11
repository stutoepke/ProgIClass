// Stuart Toepke
// ICE 08 
// Programming I
// Teacher: Brian Trager

// This is a sort of Mad Libs-style simple program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Title = "Mad Libs in C#";

            string presentTenseVerb;
            string placeName;
            string celebrityName;
            string friendName;
            string adjectiveEntry;
            string vehicleType;
            string nounEntry;
            string numberValue;
            string dollarsNCents;

            Console.WriteLine("Enter a verb in present tense: ");
            presentTenseVerb = Console.ReadLine();

            Console.WriteLine("Enter a place: ");
            placeName = Console.ReadLine();

            Console.WriteLine("Enter a celebrity's name: ");
            celebrityName = Console.ReadLine();

            Console.WriteLine("Enter a friend's name: ");
            friendName = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveEntry = Console.ReadLine();

            Console.WriteLine("Enter a vehicle: ");
            vehicleType = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            nounEntry = Console.ReadLine();

            Console.WriteLine("Enter a number between 1 and 10: ");
            numberValue = Console.ReadLine();

            Console.WriteLine("Enter a dollar value with cents included: ");
            dollarsNCents = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Once upon a time, there was a " + adjectiveEntry + " " + nounEntry + ". It was really " + adjectiveEntry + ". It liked to " + presentTenseVerb + " all the time. One day, the " + nounEntry + " went to " + placeName + " to see " + celebrityName + ". To get there, it rode in a " + vehicleType + " with " + friendName + ", but on the way, the " + vehicleType + " crashed. It took " + numberValue + " hours for the " + adjectiveEntry + " " + nounEntry + " and " + friendName + " to walk the rest of the way.  There was " + dollarsNCents + " worth of damage to the " + vehicleType + ".");

            Console.ReadLine();
        }
    }
}

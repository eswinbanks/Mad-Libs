using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program allows a user to play mad libs
      Author: Evan Swinbanks
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs has started");

      // Give the Mad Lib a title:
      string title = "MADLIBS";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter a word: ");
      string word = Console.ReadLine();

      Console.WriteLine("Enter a first adjective: ");
      string firstAdjective = Console.ReadLine();

      Console.WriteLine("Enter a second adjective");
      string secondAdjective = Console.ReadLine();

      Console.WriteLine("Enter a final adjective");
      string finalAdjective = Console.ReadLine();

      Console.WriteLine("Enter a verb: ");
      string verb = Console.ReadLine();

      Console.WriteLine("Enter a noun: ");
      string firstNoun = Console.ReadLine();

      Console.WriteLine("Enter another noun: ");
      string secondNoun = Console.ReadLine();

      Console.WriteLine("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.WriteLine("Enter a food: ");
      string food = Console.ReadLine();

      Console.WriteLine("Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.WriteLine("Superhero: ");
      string superhero = Console.ReadLine();

      Console.WriteLine("Country: ");
      string country = Console.ReadLine();

      Console.WriteLine("Dessert: ");
      string dessert = Console.ReadLine();

      Console.WriteLine("Year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {finalAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen . {dessert} woke up in the year {name}, in a world where {year}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}

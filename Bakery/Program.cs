using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("");
      Console.WriteLine("MENU");
      Console.WriteLine("================");
      Console.WriteLine("Bread");
      Console.WriteLine("SPECIAL PROMOTION!! Buy 2, get 1 free!");
      Console.WriteLine("   One loaf: $5");
      Console.WriteLine("   Two or three loaves: $10");
      Console.WriteLine("----------------");
      Console.WriteLine("Pastries");
      Console.WriteLine("Buy one for $2 or three for $5");
      Console.WriteLine("================");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      string stringLoaves = Console.ReadLine();
      int numberOfLoaves = int.Parse(stringLoaves);
      Console.WriteLine("How many pastries would you like to buy?");
      string stringPastries = Console.ReadLine();
      int numberOfPastries = int.Parse(stringPastries);
      Console.WriteLine("You would like to buy " + numberOfLoaves + " loaves of bread and " + numberOfPastries + " pastries. Is that correct? Y/N"); 
    }
  }
}
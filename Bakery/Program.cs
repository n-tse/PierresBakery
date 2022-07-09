using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Store
{
  public class Program
  {
    public static void Main()
    {
      Bread breadOrder = new Bread(0);
      Pastry pastryOrder = new Pastry(0);
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("");
      Console.WriteLine("MENU");
      Console.WriteLine("================");
      Console.WriteLine("Bread");
      Console.WriteLine("SPECIAL PROMOTION!! Buy 2, get 1 free!");
      Console.WriteLine(" One loaf: $5");
      Console.WriteLine(" Two or three loaves: $10");
      Console.WriteLine("----------------");
      Console.WriteLine("Pastries");
      Console.WriteLine("Buy one for $2 or three for $5");
      OrderInquiry(breadOrder, pastryOrder);
      int totalCost = breadOrder.CalculateTotalCost(breadOrder.QuantityOrdered) + pastryOrder.CalculateTotalCost(pastryOrder.QuantityOrdered);
      Console.WriteLine("Thanks for visiting Pierre's. The total for your order is $" + totalCost);
    }

    static void IsOrderCorrect(string userResponse, Bread breadOrder, Pastry pastryOrder)
    {
      if (userResponse.ToLower() == "y")
      {
        Console.WriteLine("Order confirmed");
      } 
      else if (userResponse.ToLower() == "n")
      {
        OrderInquiry(breadOrder, pastryOrder);
      }
      else
      {
        Console.WriteLine("Please confirm your order by entering Y/N");
        string yesOrNo = Console.ReadLine();
        IsOrderCorrect(yesOrNo, breadOrder, pastryOrder);
      }
    }

    static void OrderInquiry(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("================");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      string stringLoaves = Console.ReadLine();
      int numberOfLoaves = int.Parse(stringLoaves);
      breadOrder.QuantityOrdered = numberOfLoaves;
      Console.WriteLine("How many pastries would you like to buy?");
      string stringPastries = Console.ReadLine();
      int numberOfPastries = int.Parse(stringPastries);
      pastryOrder.QuantityOrdered = numberOfPastries;
      Console.WriteLine("You would like to buy " + numberOfLoaves + " loaves of bread and " + numberOfPastries + " pastries. Is that correct? Y/N"); 
      string yesOrNo = Console.ReadLine();
      IsOrderCorrect(yesOrNo, breadOrder, pastryOrder);
    }
  }
}
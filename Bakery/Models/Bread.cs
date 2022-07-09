using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int QuantityOrdered { get; set; }

    public Bread (int quantityOrdered)
    {
      QuantityOrdered = quantityOrdered;
    }

    public int CalculateTotalCost (int quantityOrdered)
    {
      if (quantityOrdered >= 2)
      {
        if (quantityOrdered % 3 == 1)
        {
          return quantityOrdered / 3 * 10 + 5;
        }
        else
        {
          return quantityOrdered / 3 * 10 + quantityOrdered % 3 * 5;
        }
      }
      else
      {
        return 5;
      }
    }
  }
}
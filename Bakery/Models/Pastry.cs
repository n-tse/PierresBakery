using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int QuantityOrdered { get; set; }

    public Pastry (int quantityOrdered)
    {
      QuantityOrdered = quantityOrdered;
    }

    public int CalculateTotalCost (int quantityOrdered)
    {
      if (quantityOrdered > 2)
      {
        if (quantityOrdered % 3 == 0)
        {
          return quantityOrdered / 3 * 5;
        }
        else
        {
          return 0;
        }
      }
      else
      {
        return quantityOrdered * 2;
      }
    }
  }
}
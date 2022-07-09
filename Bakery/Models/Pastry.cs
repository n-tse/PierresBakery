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
        return 0;
      }
      else
      {
        return quantityOrdered * 2;
      }
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void CalculateTotalCost_Return5_5()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(5, testBread.CalculateTotalCost(1));
    }

    [TestMethod]
    public void CalculateTotalCost_CorrectlyAddTotalCost_15()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(15, testBread.CalculateTotalCost(4));
    }

    [TestMethod]
    public void CalculateTotalCost_CorrectlyAddTotalCost_10()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(10, testBread.CalculateTotalCost(3));
    }

    [TestMethod]
    public void CalculateTotalCost_CorrectlyAddTotalCost_30()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(30, testBread.CalculateTotalCost(9));
    }

    [TestMethod]
    public void CalculateTotalCost_Return2_2()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(2, testPastry.CalculateTotalCost(1));
    }

    [TestMethod]
    public void CalculateTotalCost_CostForTwoPastries_4()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(4, testPastry.CalculateTotalCost(2));
    }

    [TestMethod]
    public void CalculateTotalCost_CostForThreePastries_5()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(5, testPastry.CalculateTotalCost(3));
    }

    [TestMethod]
    public void CalculateTotalCost_CostForFourPastries_7()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(7, testPastry.CalculateTotalCost(4));
    }
  }
}

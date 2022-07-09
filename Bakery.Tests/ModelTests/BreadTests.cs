using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateTotalCost_Return5_5()
    {
      Bread testBread = new Bread(0, 0);
      Assert.AreEqual(5, testBread.CalculateTotalCost(1));
    }

    [TestMethod]
    public void CalculateTotalCost_CorrectlyAddTotalCost_15()
    {
      Bread testBread = new Bread(0, 0);
      Assert.AreEqual(15, testBread.CalculateTotalCost(4));
    }

    [TestMethod]
    public void CalculateTotalCost_CorrectlyAddTotalCost_10()
    {
      Bread testBread = new Bread(0, 0);
      Assert.AreEqual(10, testBread.CalculateTotalCost(3));
    }

    [TestMethod]
    public void CalculateTotalCost_CorrectlyAddTotalCost_30()
    {
      Bread testBread = new Bread(0, 0);
      Assert.AreEqual(30, testBread.CalculateTotalCost(9));
    }
  }
}

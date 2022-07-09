using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateTotalCost_Return1_1()
    {
      Bread testBread = new Bread(0, 0);
      Assert.AreEqual(1, testBread.CalculateTotalCost(5));
    }
  }
}

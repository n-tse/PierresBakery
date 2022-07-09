using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateTotalCost_Return1_True()
    {
      Bread testBread = new Bread(0, 0);
      Assert.AreEqual(true, testBread.CalculateTotalCost(5));
    }
  }
}

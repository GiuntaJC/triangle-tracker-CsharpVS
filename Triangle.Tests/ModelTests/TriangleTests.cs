using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_Side1EqualToSide2_True()
    {
      IsTriangle testIsTriangle = new IsTriangle();
      Assert.AreEqual(true, testIsTriangle.CheckSide1AndSide2(3, 3));
    }

    [TestMethod]
    public void IsTriangle_Side2EqualToSide3_True()
    {
      IsTriangle testIsTriangle = new IsTriangle();
      Assert.AreEqual(true, testIsTriangle.CheckSide2AndSide3(3, 3));
    }

    // Rest of Tests down here.. //
  }
}
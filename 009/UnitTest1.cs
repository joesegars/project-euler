using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _009
{
  /// <summary>
  /// Summary description for UnitTest1
  /// </summary>
  [TestClass]
  public class UnitTest1
  {
    public UnitTest1()
    {
      //
      // TODO: Add constructor logic here
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void Can_Evaluate_Valid_Pythagorean_Triplet()
    {
      int a = 3;
      int b = 4;
      int c = 5;

      bool isPythagoreanTriplet = PythagoreanTriplet.IsPythagoreanTriplet(a, b, c);

      Assert.IsTrue(isPythagoreanTriplet);
    }

    [TestMethod]
    public void Can_Evaluate_Invalid_Pythagorean_Triplet()
    {
      int a = 4;
      int b = 3;
      int c = 5;

      bool isPythagoreanTriplet = PythagoreanTriplet.IsPythagoreanTriplet(a, b, c);

      Assert.IsFalse(isPythagoreanTriplet);
    }

    [TestMethod]
    public void Should_Find_Product_Of_Pythagorean_Triplet_That_Sum_Is_1000()
    {
      int expectedValue = 31875000;
      
      PythagoreanTriplet triplet = Calculator.FindProductOfPythagoreanTripletWhoseSumIsOneThousand();
      int actualValue = triplet.MultiplyValues();

      Assert.AreEqual(expectedValue, actualValue);
    }
  }
}

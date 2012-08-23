using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _012
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
    public void Can_Calculate_First_Triangle_Number()
    {
      int expectedValue = 1;
      int actualValue = TriangleNumberCalculator.CalculateTriangleNumberOf(1);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Calculate_Second_Triangle_Number()
    {
      int expectedValue = 3;
      int actualValue = TriangleNumberCalculator.CalculateTriangleNumberOf(2);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Calculate_Seventh_Triangle_Number()
    {
      int expectedValue = 28;
      int actualValue = TriangleNumberCalculator.CalculateTriangleNumberOf(7);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Determine_Number_Of_Factors_Of_1()
    {
      int expectedValue = 1;
      int actualValue = FactorFinder.FindTotalNumberOfFactorsFor(1);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Determine_Number_Of_Factors_Of_3()
    {
      int expectedValue = 2;
      int actualValue = FactorFinder.FindTotalNumberOfFactorsFor(3);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Determine_Number_Of_Factors_Of_28()
    {
      int expectedValue = 6;
      int actualValue = FactorFinder.FindTotalNumberOfFactorsFor(28);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Find_First_Triangle_Number_With_More_Than_3_Factors()
    {
      int expectedValue = 6;
      int actualValue = Calculator.FindFirstTriangleNumberWithFactorsTotalingMoreThan(3);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Find_First_Triangle_Number_With_More_Than_5_Factors()
    {
      int expectedValue = 28;
      int actualValue = Calculator.FindFirstTriangleNumberWithFactorsTotalingMoreThan(5);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    [Ignore]
    public void Can_Find_First_Triangle_Number_With_More_Than_500_Factors()
    {
      int expectedValue = 28;
      int actualValue = Calculator.FindFirstTriangleNumberWithFactorsTotalingMoreThan(500);

      Assert.AreEqual(expectedValue, actualValue);
    }
  }
}

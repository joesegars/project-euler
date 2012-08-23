using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _005
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
    public void smallest_value_divisible_by_values_1_to_2_should_be_2()
    {
      int expectedValue = 2;
      int actualvalue = Calculator.FindSmallestValueDivisibleByEachNumberInRange(1, 2);

      Assert.AreEqual(expectedValue, actualvalue);
    }

    [TestMethod]
    public void smallest_value_divisible_by_values_1_to_10_should_be_2520()
    {
      int expectedValue = 2520;
      int actualvalue = Calculator.FindSmallestValueDivisibleByEachNumberInRange(1, 10);

      Assert.AreEqual(expectedValue, actualvalue);
    }

    [TestMethod]
    public void smallest_value_divisible_by_values_1_to_20_should_be_232792560()
    {
      int expectedValue = 232792560; //answer
      int actualvalue = Calculator.FindSmallestValueDivisibleByEachNumberInRange(1, 20);

      Assert.AreEqual(expectedValue, actualvalue);
    }
  }
}

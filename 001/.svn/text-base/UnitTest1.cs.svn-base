using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _001
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
    public void sum_of_multiples_for_0_should_be_0()
    {
      int expectedSum = 0;
      int actualSum = Calculator.SumAllMultiplesOfThreeOrFiveBelow(0);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void sum_of_multiples_for_4_should_be_3()
    {
      int expectedSum = 3;
      int actualSum = Calculator.SumAllMultiplesOfThreeOrFiveBelow(4);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void sum_of_multiples_for_6_should_be_8()
    {
      int expectedSum = 8;
      int actualSum = Calculator.SumAllMultiplesOfThreeOrFiveBelow(6);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void sum_of_multiples_for_10_should_be_23()
    {
      int expectedSum = 23;
      int actualSum = Calculator.SumAllMultiplesOfThreeOrFiveBelow(10);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void multiples_of_3_and_5_should_only_be_counted_once()
    {
      int expectedSum = 60;
      int actualSum = Calculator.SumAllMultiplesOfThreeOrFiveBelow(16);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void sum_of_multiples_for_1000_should_be_266333()
    {
      int expectedSum = 233168; //answer
      int actualSum = Calculator.SumAllMultiplesOfThreeOrFiveBelow(1000);

      Assert.AreEqual(expectedSum, actualSum);
    }
  }
}

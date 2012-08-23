using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _002
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
    public void should_equal_0_when_no_even_values()
    {
      int expectedSum = 0;
      int actualSum = Calculator.SumAllEvenFibonacciValuesNotExceeding(1);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void should_equal_2_when_passed_2()
    {
      int expectedSum = 2;
      int actualSum = Calculator.SumAllEvenFibonacciValuesNotExceeding(2);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void should_equal_2_when_passed_5()
    {
      int expectedSum = 2;
      int actualSum = Calculator.SumAllEvenFibonacciValuesNotExceeding(5);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void should_equal_10_when_passed_8()
    {
      int expectedSum = 10;
      int actualSum = Calculator.SumAllEvenFibonacciValuesNotExceeding(8);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void should_equal_44_when_passed_89()
    {
      int expectedSum = 44;
      int actualSum = Calculator.SumAllEvenFibonacciValuesNotExceeding(89);

      Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void should_equal_x_when_passed_4000000()
    {
      int expectedSum = 4613732; //answer
      int actualSum = Calculator.SumAllEvenFibonacciValuesNotExceeding(4000000);

      Assert.AreEqual(expectedSum, actualSum);
    }
  }
}

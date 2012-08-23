using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _006
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
    public void difference_for_numbers_1_to_2_should_be_4()
    {
      int expectedValue = 4;
      int actualValue = Calculator.FindDifferenceBetweenSumOfTheSquaresAndSquareOfTheSumsForNaturalNumbersFromOneTo(2);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void difference_for_numbers_1_to_10_should_be_2640()
    {
      int expectedValue = 2640;
      int actualValue = Calculator.FindDifferenceBetweenSumOfTheSquaresAndSquareOfTheSumsForNaturalNumbersFromOneTo(10);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void difference_for_numbers_1_to_100_should_be_25164150()
    {
      int expectedValue = 25164150; //answer
      int actualValue = Calculator.FindDifferenceBetweenSumOfTheSquaresAndSquareOfTheSumsForNaturalNumbersFromOneTo(100);

      Assert.AreEqual(expectedValue, actualValue);
    }
  }
}

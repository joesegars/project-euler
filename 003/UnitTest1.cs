using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _003
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
    public void largest_prime_factor_of_0_should_be_0()
    {
      long expectedValue = 0;
      long actualValue = Calculator.FindLargestPrimeFactorOf(0);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void largest_prime_factor_of_2_should_be_2()
    {
      long expectedValue = 2;
      long actualValue = Calculator.FindLargestPrimeFactorOf(2);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void largest_prime_factor_of_13195_should_be_29()
    {
      long expectedValue = 29;
      long actualValue = Calculator.FindLargestPrimeFactorOf(13195);

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void largest_prime_factor_of_600851475143_should_be_6857()
    {
      long expectedValue = 6857; //answer
      long actualValue = Calculator.FindLargestPrimeFactorOf(600851475143);

      Assert.AreEqual(expectedValue, actualValue);
    }
  }
}

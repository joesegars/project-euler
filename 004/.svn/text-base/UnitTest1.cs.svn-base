using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _004
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
    public void all_single_digit_numbers_should_be_palindromes()
    {
      for (int i = 0 ; i < 10 ; i++)
      {
        Assert.IsTrue(i.IsPalindrome());
      }
    }

    [TestMethod]
    public void twenty_two_should_be_a_palindrome()
    {
      Assert.IsTrue(22.IsPalindrome());
    }

    [TestMethod]
    public void twenty_three_should_not_be_a_palindrome()
    {
      Assert.IsFalse(23.IsPalindrome());
    }

    [TestMethod]
    public void can_evaluate_large_values()
    {
      Assert.IsTrue(9016109.IsPalindrome());
    }

    [TestMethod]
    public void should_find_the_largest_palindrome_from_product_of_two_two_digit_numbers()
    {
      int expectedValue = 9009;
      int actualValue = Calculator.FindLargestPalindromeMadeFromProductOfTwoTwoDigitNumbers();

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void should_find_the_largest_palindrome_from_product_of_two_three_digit_numbers()
    {
      int expectedValue = 906609; //answer
      int actualValue = Calculator.FindLargestPalindromeMadeFromProductOfTwoThreeDigitNumbers();

      Assert.AreEqual(expectedValue, actualValue);
    }
  }
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace _008
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
    public void Numbers_With_Less_Than_Five_Digits_Should_Return_Zero()
    {
      string oneDigitNumber = "1";
      string twoDigitNumber = "12";
      string threeDigitNumber = "123";
      string fourDigitNumber = "1234";

      int expectedValue = 0;

      Assert.AreEqual(expectedValue, Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn(oneDigitNumber));
      Assert.AreEqual(expectedValue, Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn(twoDigitNumber));
      Assert.AreEqual(expectedValue, Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn(threeDigitNumber));
      Assert.AreEqual(expectedValue, Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn(fourDigitNumber));
    }

    [TestMethod]
    public void Can_Find_Product_For_Number_With_Exactly_Five_Digits()
    {
      int expectedValue = 120;
      int actualValue = Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn("12345");

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Find_Product_For_Number_With_Six_Digits()
    {
      int expectedValue = 720;
      int actualValue = Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn("123456");

      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void Can_Find_Product_For_Number_With_One_Thousand_Digits()
    {
      string testValue = "73167176531330624919225119674426574742355349194934" +
                         "96983520312774506326239578318016984801869478851843" +
                         "85861560789112949495459501737958331952853208805511" +
                         "12540698747158523863050715693290963295227443043557" +
                         "66896648950445244523161731856403098711121722383113" +
                         "62229893423380308135336276614282806444486645238749" +
                         "30358907296290491560440772390713810515859307960866" +
                         "70172427121883998797908792274921901699720888093776" +
                         "65727333001053367881220235421809751254540594752243" +
                         "52584907711670556013604839586446706324415722155397" +
                         "53697817977846174064955149290862569321978468622482" +
                         "83972241375657056057490261407972968652414535100474" +
                         "82166370484403199890008895243450658541227588666881" +
                         "16427171479924442928230863465674813919123162824586" +
                         "17866458359124566529476545682848912883142607690042" +
                         "24219022671055626321111109370544217506941658960408" +
                         "07198403850962455444362981230987879927244284909188" +
                         "84580156166097919133875499200524063689912560717606" +
                         "05886116467109405077541002256983155200055935729725" +
                         "71636269561882670428252483600823257530420752963450";


      int expectedValue = 40824;
      int actualValue = Calculator.FindGreatestProductOfFiveConsecutiveNumbersIn(testValue);

      Assert.AreEqual(expectedValue, actualValue);
    }
  }
}

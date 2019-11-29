using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignments;

namespace TestSuite
{
  [TestClass]
  public class StringModifierTests
  {
    [TestMethod]
    public void ShouldReverseString()
    {
      // Arrange
      var someString = "Hello World!";
      var modifier = new StringModifier();
      // Act
      var result = modifier.ReverseString(someString);
      // Assert
      Assert.AreEqual(result, "!dlroW olleH");
    }


    [TestMethod]
    public void ShouldAssertPalindrome()
    {
      // Arrange
      var palindrome = "boolloob";
      var asserter = new StringAsserter();
      // Act
      var result = asserter.CheckPalindrome(palindrome);
      // Assert
      Assert.IsTrue(result);

    }

    [TestMethod]
    public void shouldRejectNonPalindrome()
    {
      // Arrange
      var notAPalindrome = "notapalindrome";
      var asserter = new StringAsserter();
      // Act
      var result = asserter.CheckPalindrome(notAPalindrome);
      // Assert
      Assert.IsFalse(result);
    }


  }
}

using System;

namespace Assignments
{
  public class StringModifier
  {
    public string ReverseString(string input)
    {
      var stringArray = input.ToCharArray();
      Array.Reverse(stringArray);
      return new String(stringArray);
    }
  }

  public class StringAsserter
  {
    private StringModifier strMod = new StringModifier();
    public bool CheckPalindrome(string input)
    {
      var reverseResult = strMod.ReverseString(input);
      return reverseResult == input;
    }
  }
}

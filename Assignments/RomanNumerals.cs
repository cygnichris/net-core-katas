using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments
{
  public class NumberModifier
  {
    private void CheckInput(int input)
    {
      if (input < 1) throw new ArgumentException("Value must be above 0");
    }

    private Dictionary<int, string> RomanNumberMapper = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

    public string NumberToRoman(int input)
    {
      CheckInput(input);

      var roman = new List<string>();

      foreach (var item in RomanNumberMapper)
      {
        while (input >= item.Key)
        {
          roman.Add(item.Value);
          input -= item.Key;
        }
      }

      return String.Join("", roman);
    }
  }
}


using System;
using Assignments;

namespace Executor
{
  class Program
  {
    private static StringModifier strMod = new StringModifier();
    static void Main(string[] args)
    {
      Console.WriteLine("Executing Assignments...");
      RunStringModifier();
    }

    public static void RunStringModifier()
    {
      var input = "Hello World!";
      var output = strMod.ReverseString(input);
      Console.WriteLine(output);
    }
  }
}

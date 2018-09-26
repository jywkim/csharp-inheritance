using System;

namespace csharp_inheritance
{
  public class Program
  {
      public static void Main()
      {
          var packard = new Automobile("Packard", "Custom Eight", 1948);
          Console.WriteLine(packard);
      }
  }
  // The example displays the following output:
  //        1948 Packard Custom Eight
}

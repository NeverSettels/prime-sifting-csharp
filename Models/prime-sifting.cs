using System;
using System.Collections.Generic;

namespace Prime.Models
{
  public class PrimeFinder
  {
    public static List<int> PrimeFunction(int input)
    {
      List<int> found = new List<int> { };
      int prime = 2;
      for (int i = 2; i <= input; i++)
      {
        found.Add(i);
      }

      for (int i = found.Count - 1; i > 2; i--)
      {
        for (int j = prime; j < found.Count - 1; j++)
        {
          if (i % j == 0 && i != j)
          {
            Console.WriteLine("This should be not prime " + j);
            found.Remove(j);
          }
        }



      }
      return found;
    }
  }
}
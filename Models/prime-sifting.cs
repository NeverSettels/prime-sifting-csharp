using System;
using System.Collections.Generic;

namespace Prime.Models
{
  public class PrimeFinder
  {
    public static List<int> PrimeFunction(int input)
    {
      List<int> found = new List<int> { };
      List<int> primeList = new List<int> { };
      List<int> nonPrimeList = new List<int> { };
      int prime = 2;
      for (int i = 2; i <= input; i++)
      {
        found.Add(i);
      }
      int counter = found.Count;
      for (int j = 0; j < found.Count; j++)
      {
        for (int i = found[j] + 1; i <= counter + 1; i++)
        {
          if (found[j] / i != 1 && i % found[j] == 0)
          {
            found.Remove(i);
          }
        }
      }
      return found;
    }
  }
}
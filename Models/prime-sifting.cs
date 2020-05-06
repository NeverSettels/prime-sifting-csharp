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
      int prime = 2;
      for (int i = 2; i <= input; i++)
      {
        found.Add(i);
      }
      // Console.WriteLine(found.Count);
      int counter = found.Count;
      for (int i = counter - 1; i >= 2; i--)
      {
        for (int j = prime; j < counter - 1; j++)
        {
          Console.WriteLine($"this is i:{i} this is j: {j}");
          if (found[i] % j == 0 && found[i] != j)
          {
            //Console.WriteLine("This should be not prime " + found[i]);
            //found.Remove(i); 
          }
          else
          {
            if (!primeList.Contains(j))
              primeList.Add(j);
          }
        }
      }
      return primeList;
    }
  }
}
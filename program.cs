using System;
using System.Collections.Generic;
using Prime.Models;

namespace Prime
{

  public class Program
  {
    public static void Main()
    {

      Console.Write("Enter a number and I'll find all prime numbers up to that number: ");
      int response = int.Parse(Console.ReadLine());
      List<int> primeList = PrimeFinder.PrimeFunction(response);

      foreach (int num in primeList)
      {
        Console.Write(num + " ");

      }





    }

  }
}
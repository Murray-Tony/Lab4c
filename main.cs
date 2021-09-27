using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please provide a number:");
    double number = Math.Abs(Convert.ToDouble(Console.ReadLine()));
    int prime = 0;
    if (number <= 1)
    {
      Console.WriteLine("Your number is not prime.");
      prime++;
    }
    for (int divisor = 2; divisor < number; divisor++)
    {
      double remainder = number % divisor;
      if (remainder == 0) 
      {Console.WriteLine("Your number is not prime.");
      prime++;
      break;
      }  
    }
    if (prime == 0)
    {
      Console.WriteLine("Your number is prime.");
    }
  }
}
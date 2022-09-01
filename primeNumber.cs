// Write a simple console app that takes a number input and upon provision writes out all the prime numbers leading to that number. 

using System;
     
class PrimeNumber
{
    public static void Main (String[] args)
    {
      Console.Write("Enter a number: ");
      double num = Convert.ToDouble(Console.ReadLine());
      
// loop over input number num
        for(int i=1; i<=num; i++) {
// check if current number is prime
        if(isPrime(i)) {
        Console.Write(i + " ");
           }
        }
        
// check if a given number is prime
     static bool isPrime(int n){
// return false if 0 and 1 are not prime numbers
        if(n==1||n==0) return false;
 
// run a loop from 2 to n-1
        for(int i=2; i<n; i++) {
// if the number is divisible by i, then n is not a prime number.
        if(n%i==0) return false;
      }
// otherwise, n is prime number.
        return true;
    }
    Console.ReadLine();
    }
}
 

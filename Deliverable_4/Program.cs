/* Programmer: James Mandouma
 * Description: C# Console App to compute first 25 numbers of fibonacci sequence.
 * 
 * Date: 2/9/2023 */ 

using System;

namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create fibonacci array, initial values
            int[] fibonacci = new int[25];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            // Loop through remaining values
            for (int i = 2; i < 25; i++)
            {
                fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
            }
            
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}
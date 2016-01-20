using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_2_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6-2  Write a program that reads from the console a series 
            of integers and prints the smallest and largest of them. 
            (Chapter 6, Exercise 3)
            */

            /*
              First read the count of numbers, for example in a variable n. 
              Then consequently enter n numbers with one for loop. While entering each new number, 
              save in two variables the smallest and the largest number until this moment. 
              At the start initialize the smallest and the largest number with Int32.MaxValue 
              and Int32.MinValue respectively.
            */

            //read the array from the console
            Console.WriteLine("Enter the number of integers in your series = ");
            int n = int.Parse(Console.ReadLine());

            //Declaring the array
            int[] arr = new int[n];

            //Filling the array
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            // This will track the lowest number found
            int lowestFound = int.MaxValue;

            foreach (int i in arr)
            {
                // By using int.MaxValue as the initial value,
                // this check will usually succeed.
                if (lowestFound > i)
                {
                    lowestFound = i;
                    Console.WriteLine("Smallest Integer = " + lowestFound);
                }
            }
            // This will track the highest number found
            int highestFound = int.MinValue;

            foreach (int i in arr)
            {
                // By using int.minValue as the initial value,
                // this check will usually succeed.
                if (highestFound > i)
                {
                    highestFound = i;
                    Console.WriteLine("Largest Integer = " + highestFound);
                }
            }
            Console.ReadKey();
        }
    }
}

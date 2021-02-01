using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
           

            //Create a List called "numbers"
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            // Create a do-while loop and use the template below:
            // < ----While your variable is less than 100

            var numbers = new List<int>();
            var num = 0;
            do
            {
                num++;
                numbers.Add(num);
            }
            while (num < 100);



            // Create a while loop
            // <--- While num is less than 200
            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            {
                // place numbers[i] inside of the Console.WriteLine() method
            }

            for(int i = 199; i < numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------


            //TODO START HERE:
            var arr = new char[] {'a', 'b', 'c', '1', '2','3'};
            var numbers = new List<int>();
            string str = "";

            // Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {

                // Now create a try catch
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list
                    str = item.ToString();
                    int cast = Int32.Parse(str);
                    numbers.Add(cast);
                    int prob = 1 / (cast - cast);
                }
                // catch your Exception:
                // in the scope of your catch you can use the following, 
                catch (FormatException ex)
                {
                    Console.WriteLine($"Unable to Parse '{item}'"); //character will be the name of each item in your collection
                    Console.WriteLine(ex.Message); //character will be the name of each item in your collection
                    //throw new DivideByZeroException();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                    //throw new DivideByZeroException();
                }
             }


            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

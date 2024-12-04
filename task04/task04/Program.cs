namespace task04
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program

    {
        /*    Problem: Write a program that: 
   o Initializes a one-dimensional array in three different ways(new int[size], 
   initializer list, and Array syntax sugar). 
   o Assigns values to each element in the array and prints them.
   o Demonstrates an IndexOutOfRangeException.*/
        /*  static void Main()
          {

              int[] array1 = new int[5];
              array1[0] = 10;
              array1[1] = 20;
              array1[2] = 30;
              array1[3] = 40;
              array1[4] = 50;

              Console.WriteLine("Array 1 (new int[size]):");
              foreach (var item in array1)
              {
                  Console.WriteLine(item);
              }
              int[] array2 = { 100, 200, 300, 400, 500 };

              Console.WriteLine("\nArray 2 (initializer list):");
              foreach (var item in array2)
              {
                  Console.WriteLine(item);
              }

              int[] array3 = new[] { 1, 2, 3, 4, 5 };

              Console.WriteLine("\nArray 3 (Array syntax sugar):");
              foreach (var item in array3)
              {
                  Console.WriteLine(item);
              }

              try
              {
                  Console.WriteLine("\nAttempting to access an out-of-bounds index...");
                  int outOfBoundsValue = array1[10];
              }
              catch (IndexOutOfRangeException ex)
              {
                  Console.WriteLine($"Exception caught: {ex.Message}");
              }
          }
        */


        /*   Problem: Write a program to: 
        o Create two arrays(arr1 and arr2). 
        o Perform a shallow copy and demonstrate how modifying one affects the other.
        o Perform a deep copy using the Clone method and show that modifications do not
        affect the copied array*/
        /* static void Main()
         {
             // Step 1: Create two arrays
             int[] arr1 = { 10, 20, 30, 40, 50 };

             // Step 2: Perform a shallow copy
             int[] arr2 = arr1; // Shallow copy: arr2 refers to the same array as arr1

             Console.WriteLine("Before modification (Shallow Copy):");
             Console.WriteLine("arr1: " + string.Join(", ", arr1));
             Console.WriteLine("arr2: " + string.Join(", ", arr2));

             // Modify an element in arr2
             arr2[2] = 99;

             Console.WriteLine("\nAfter modifying arr2 (Shallow Copy):");
             Console.WriteLine("arr1: " + string.Join(", ", arr1)); // arr1 reflects the change
             Console.WriteLine("arr2: " + string.Join(", ", arr2)); // arr2 reflects the same change

             // Step 3: Perform a deep copy using the Clone method
             int[] arr3 = (int[])arr1.Clone(); // Deep copy: arr3 is a separate copy of arr1

             Console.WriteLine("\nBefore modification (Deep Copy):");
             Console.WriteLine("arr1: " + string.Join(", ", arr1));
             Console.WriteLine("arr3: " + string.Join(", ", arr3));

             // Modify an element in arr3
             arr3[2] = 77;

             Console.WriteLine("\nAfter modifying arr3 (Deep Copy):");
             Console.WriteLine("arr1: " + string.Join(", ", arr1)); // arr1 remains unchanged
             Console.WriteLine("arr3: " + string.Join(", ", arr3)); // arr3 reflects the change
         }*/

        /*  Problem: Write a program to: 
        o Create a 2D array with student grades(3 students, 3 subjects each). 
        o Take input from the user to fill the array.
        o Print the grades for each student using nested loops.*/



        /* static void Main()
         {

             int[,] grades = new int[3, 3];

             Console.WriteLine("Enter grades for 3 students (3 subjects each):");

             for (int student = 0; student < 3; student++)
             {
                 Console.WriteLine($"\nEntering grades for Student {student + 1}:");
                 for (int subject = 0; subject < 3; subject++)
                 {
                     Console.Write($"  Enter grade for Subject {subject + 1}: ");
                     grades[student, subject] = int.Parse(Console.ReadLine());
                 }
             }

             Console.WriteLine("\nGrades for each student:");

             for (int student = 0; student < 3; student++)
             {
                 Console.WriteLine($"\nStudent {student + 1}:");
                 for (int subject = 0; subject < 3; subject++)
                 {
                     Console.WriteLine($"  Subject {subject + 1}: {grades[student, subject]}");
                 }
             }
         }*/


        /* Problem: Write a program that: 
        o Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear). 
        o Explains the changes before and after applying each method. */

        /*
        //        static void Main()
        //        {

        //            int[] arr = { 5, 3, 8, 1, 4 };
        //            Console.WriteLine("Original Array: " + string.Join(", ", arr));


        //            Array.Sort(arr);
        //            Console.WriteLine("\nAfter Sort (ascending order): " + string.Join(", ", arr));

        //            Array.Reverse(arr);
        //            Console.WriteLine("\nAfter Reverse (descending order): " + string.Join(", ", arr));

        //            int index = Array.IndexOf(arr, 8);
        //            Console.WriteLine($"\nIndex of element 8: {index}");

        //            int[] newArr = new int[5];
        //            Array.Copy(arr, newArr, arr.Length);
        //            Console.WriteLine("\nNew Array after Copy: " + string.Join(", ", newArr));

        //            Array.Clear(arr, 1, 2); 
        //            Console.WriteLine("\nAfter Clear (set elements at index 1 and 2 to 0): " + string.Join(", ", arr));

        //        }
        //    }*/


        /* Problem: Create a program that: 
        o Uses a for loop to print all elements of a 1D array. 
        o Uses a foreach loop to print all elements of the same array. 
        o Uses a while loop to print all elements in reverse order. */

        /*  static void Main()
          {
              // Step 1: Initialize a 1D array
              int[] array = { 10, 20, 30, 40, 50 };

              // Step 2: Use a for loop to print all elements
              Console.WriteLine("Using for loop:");
              for (int i = 0; i < array.Length; i++)
              {
                  Console.WriteLine(array[i]);
              }

              // Step 3: Use a foreach loop to print all elements
              Console.WriteLine("\nUsing foreach loop:");
              foreach (int element in array)
              {
                  Console.WriteLine(element);
              }

              // Step 4: Use a while loop to print all elements in reverse order
              Console.WriteLine("\nUsing while loop (reverse order):");
              int index = array.Length - 1; // Start from the last index
              while (index >= 0)
              {
                  Console.WriteLine(array[index]);
                  index--;
              }
          }*/



        /*    Problem: Write a program that: 
        o Repeatedly asks the user for a positive odd number.
        o Uses defensive coding to validate input using int.TryParse and a do-while 
        loop.*/


        /*   static void Main()
           {
               int number; // Variable to store the user input
               bool isValid; // Variable to check if input is valid

               do
               {
                   Console.Write("Please enter a positive odd number: ");
                   string input = Console.ReadLine(); // Read user input

                   // Step 1: Validate input using int.TryParse
                   isValid = int.TryParse(input, out number);

                   // Step 2: Check additional conditions (positive and odd)
                   if (isValid)
                   {
                       if (number <= 0)
                       {
                           Console.WriteLine("Error: The number must be positive.");
                           isValid = false;
                       }
                       else if (number % 2 == 0)
                       {
                           Console.WriteLine("Error: The number must be odd.");
                           isValid = false;
                       }
                   }
                   else
                   {
                       Console.WriteLine("Error: Please enter a valid integer.");
                   }

               } while (!isValid); // Repeat until valid input is provided

               // Step 3: Confirm the input
               Console.WriteLine($"Thank you! You entered a valid positive odd number: {number}");
           }
        }
        }
        */

        /* Problem: Write a program to: 
        o Create a 2D array with fixed values. 
        o Print the array elements in a matrix format (rows and columns). */

        /*
                //        static void Main()
                //        {
                //            int[,] matrix = {
                //            { 1, 2, 3 },
                //            { 4, 5, 6 },
                //            { 7, 8, 9 }
                //        };

                //            
                //            Console.WriteLine("2D Array in Matrix Format:");
                //            for (int row = 0; row < matrix.GetLength(0); row++) 
                //            {
                //                for (int col = 0; col < matrix.GetLength(1); col++) 
                //                {
                //                    Console.Write(matrix[row, col] + "\t"); 
                //                }
                //                Console.WriteLine(); 
                //            }
                //        }
                //    }
                //}*/


        /* Problem: Write a program that: 
        o Asks the user to enter a month number. 
        o Uses an if-else statement to determine the month name. 
        o Uses a switch statement to perform the same task. */

        /*

        //        static void Main()
        //        {

        //            Console.Write("Enter a month number (1-12): ");
        //            string input = Console.ReadLine();
        //            int monthNumber;


        //            if (!int.TryParse(input, out monthNumber) || monthNumber < 1 || monthNumber > 12)
        //            {
        //                Console.WriteLine("Invalid input! Please enter a number between 1 and 12.");
        //                return; 
        //            }

        //            string monthNameIfElse = "";
        //            if (monthNumber == 1) monthNameIfElse = "January";
        //            else if (monthNumber == 2) monthNameIfElse = "February";
        //            else if (monthNumber == 3) monthNameIfElse = "March";
        //            else if (monthNumber == 4) monthNameIfElse = "April";
        //            else if (monthNumber == 5) monthNameIfElse = "May";
        //            else if (monthNumber == 6) monthNameIfElse = "June";
        //            else if (monthNumber == 7) monthNameIfElse = "July";
        //            else if (monthNumber == 8) monthNameIfElse = "August";
        //            else if (monthNumber == 9) monthNameIfElse = "September";
        //            else if (monthNumber == 10) monthNameIfElse = "October";
        //            else if (monthNumber == 11) monthNameIfElse = "November";
        //            else if (monthNumber == 12) monthNameIfElse = "December";

        //            Console.WriteLine($"(Using if-else) The month is: {monthNameIfElse}");

        //            string monthNameSwitch = monthNumber switch
        //            {
        //                1 => "January",
        //                2 => "February",
        //                3 => "March",
        //                4 => "April",
        //                5 => "May",
        //                6 => "June",
        //                7 => "July",
        //                8 => "August",
        //                9 => "September",
        //                10 => "October",
        //                11 => "November",
        //                12 => "December",
        //                _ => "Invalid" 
        //            };

        //            Console.WriteLine($"(Using switch) The month is: {monthNameSwitch}");
        //        }
        //    }
        //}*/
        /* Problem: Write a program to: 
        o Sort an array of integers using Array.Sort(). 
        o Search for a specific value using Array.IndexOf() and Array.LastIndexOf(). */

        /*
        //        static void Main()
        //        {
        //            int[] numbers = { 5, 3, 8, 5, 1, 7, 3, 9 };

        //            Console.WriteLine("Original Array: " + string.Join(", ", numbers));


        //            Array.Sort(numbers);
        //            Console.WriteLine("\nSorted Array: " + string.Join(", ", numbers));

        //            Console.Write("\nEnter a value to search: ");
        //            string input = Console.ReadLine();
        //            int searchValue;

        //            if (!int.TryParse(input, out searchValue))
        //            {
        //                Console.WriteLine("Invalid input! Please enter a valid integer.");
        //                return;
        //            }

        //            int firstIndex = Array.IndexOf(numbers, searchValue);
        //            if (firstIndex != -1)
        //            {
        //                Console.WriteLine($"First occurrence of {searchValue} is at index: {firstIndex}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{searchValue} was not found in the array.");
        //            }

        //            int lastIndex = Array.LastIndexOf(numbers, searchValue);
        //            if (lastIndex != -1)
        //            {
        //                Console.WriteLine($"Last occurrence of {searchValue} is at index: {lastIndex}");
        //            }
        //        }
        //    }
        //}*/


        /* Problem: Write a program that: 
        o Creates an array of integers. 
        o Uses a for loop to calculate and print the sum of all elements. 
        o Uses a foreach loop to calculate the same sum. */

        static void Main()
        {
           
            int[] numbers = { 10, 20, 30, 40, 50 };

            
            int sumFor = 0; 
            for (int i = 0; i < numbers.Length; i++)
            {
                sumFor += numbers[i];
            }
            Console.WriteLine($"Sum calculated using for loop: {sumFor}");

            int sumForeach = 0; 
            foreach (int number in numbers)
            {
                sumForeach += number;
            }
            Console.WriteLine($"Sum calculated using foreach loop: {sumForeach}");
        }
    }
}

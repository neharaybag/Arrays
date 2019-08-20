using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
    class Arrays
    {
            static public void Main(string[] args)
            {
                // Single dimensional array

                Console.WriteLine("Single Dimensional array");

                int[] array = new int[5];

                array[0] = 1;
                array[1] = 2;
                array[2] = 3;
                array[3] = 4;
                array[4] = 5;


                Console.WriteLine("Length of array" + array.Length);

                Console.WriteLine(string.Join(" ", array));

                int[] array1 = new int[] { 1, 4, 9, 16, 25 };

                Console.WriteLine(string.Join(" ", array1));

                string[] colors = new string[] { "blue", "red", "black" };

                Console.WriteLine(string.Join(" ", colors));



                // MultiDimensional Array

                Console.WriteLine("Multidimensional Array");

                int[,] multiarray = new int[3, 3]{
                {1,2 ,4},
                {3,4 ,6},
                {6,7,7 }
            };

                int rowLength = multiarray.GetLength(0);
                int colLength = multiarray.GetLength(1);

                for (int row = 0; row < rowLength; row++)
                {
                    for (int col = 0; col < colLength; col++)
                    {
                        Console.Write(string.Format("{0} ", multiarray[row, col]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }


                // Jagged Array

                int[][] jagged_arr = new int[4][];
                jagged_arr[0] = new int[] { 1, 2, 3, 4 };
                jagged_arr[1] = new int[] { 11, 34, 67 };
                jagged_arr[2] = new int[] { 89, 23 };
                jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

                // Display the array elements: 

                Console.WriteLine("Jagged Array");

                for (int n = 0; n < jagged_arr.Length; n++)
                {

                    // Print the row number 
                    System.Console.Write("Row({0}): ", n);

                    for (int k = 0; k < jagged_arr[n].Length; k++)
                    {

                        // Print the elements in the row 
                        System.Console.Write("{0} ", jagged_arr[n][k]);
                    }
                    System.Console.WriteLine();
                }

                Console.ReadLine();
            }

        }
    }


    
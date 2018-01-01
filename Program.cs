using System;

namespace SortingAlgorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] items = { 5, 2, 3, 4, 1, 0, -6, -6, 1, 2, 5, -10 };

            /*
                Bubble Sort Pseudocode:
                    Outer loop
                        var i = 5;
                        
                    Inner loop
                        var j = 2;

                        If var j is less than var j Swap the values... 
                        (note: do this in the entire items until they got reach the lowest value in the items..
                        if j < i
                            Swap the values
                            items[i] = items[j]
                        
            */

            #region Bubble Sort Algorithm

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = (i + 1); j < items.Length; j++)
                {
                    int tmp = items[i];
                    if (items[j] < items[i])
                    {
                        items[i] = items[j]; // Swap values

                        items[j] = tmp;
                    }
                }
            }

            Console.WriteLine("After Performing Buble Sort...");

            // Display the items...
            for (int k = 0; k < items.Length; k++)
            {
                Console.WriteLine("{0} ", items[k]);
            }

            #endregion

            /*
                Insertion Sort Pseudocode:

                    Counter in loop...
                    var counter = items.Count


                    Outer loop

                        var i = items[i];

                    Inner loop

                        var j = items[j] + 1;

                        Compare the two values if j is lesser than i
                        
                        if j < i
                            
                
            */

            #region Insertion Sort Algorithm

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j > 0 && j < items.Length; j--)
                {

                    var tmp = items[j - 1];

                    if (items[j] < items[j - 1])
                    {
                        items[j - 1] = items[j];

                        items[j] = tmp;
                    }
                }

            }

            Console.WriteLine("After Performing Insertion Sort...");
            
            for (int k = 0; k < items.Length; k++)
            {
                Console.Write("{0}  ", items[k]);
            }
            

            #endregion


            /*
                Selection Sort Pseudocode


                Find the lowest element in the array and place it in the index

                    1. Loop First in entire array (Outer loop) ...
                    2. Find the most lowest element in the array (Inner loop)...
                    3. Get the lowest element that and place it in the index in Outer loop...

            */


            #region Selection Sort Algorithm

            for (int i = 0; i < items.Length; i++)
            {
                int j = i, pos = i;

                int min = items[j]; // Set the lowest elem in array into index 0...

                for (j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < min) // Check if there was lowest elem in the entire array then swap the values...
                    {
                        min = items[j];

                        pos = j;
                    }
                }

                int tmp = items[i];

                items[i] = min;

                items[pos] = tmp;
            }

            Console.WriteLine("After Performing Selection Sort...");

            // Display the list after performing selection sort...
            for (int k = 0; k < items.Length; k++)
            {
                Console.Write("{0}  ", items[k]);
            }


            #endregion



        }
    }
}

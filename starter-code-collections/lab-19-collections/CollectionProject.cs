﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_19_collections
{

    public class CollectionProject
    {
        // have to make static as is for labs 1 and 2
        static int[,,] myCubicArray = new int[11, 11, 11];

        // used for lab 3
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // used for lab 4
        static Queue<int> queue = new Queue<int>();

        // used for lab 5
        static Stack<int> stack = new Stack<int>();

        /*
         
        ### Lab 1 : Cubic Array 10x10x10

        Build a three dimensional array and populate it with numbers 
        which are products of the input numbers.  
        
        Make the size of the cube to be 11x11x11 
        and your numbers will run from 0 at (0,0,0) 
        through 1000 at (10,10,10).  
        
        Numbering starts at 1 here instead of 0.

        Tip : use a loop within a loop within a loop to accomplish this!

        Finally output the value at (2,3,7) and check it has value 2x3x7=42

     */

        public int CubicArray()
        {
            for (int i = 0; i < myCubicArray.GetLength(0); i++)
            {
                for (int j = 0; j < myCubicArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myCubicArray.GetLength(2); k++)
                    {
                        Console.WriteLine(myCubicArray[i, j, k] = i * j * k);
                    }
                }
            }


            return myCubicArray[2,3,7];


        }
        /*
         * 
         * 
         * 
                 ### Lab 2 : List

            Create a one-dimensional list of integers called List01.

            Iterate over the three dimensional array above, and for every number in the array, add it to the list.

            Finally add up the total sum of all numbers in the list and output the result.

         */


        public int List()
        {
            var List01 = new List<int>();
            for (int i = 0; i < myCubicArray.GetLength(0); i++)
            {
                for (int j = 0; j < myCubicArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myCubicArray.GetLength(2); k++)
                    {
                        List01.Add(myCubicArray[i, j, k]);
                    }
                }
            }
            int ans = 0;
            foreach (int i in List01)
            {
                ans += i;
            }
            return ans;
        }


        /*
         * 
         

            ### Lab 3 : Dictionary

            Create a dictionary of 10 countries as the index, with the capital city as the data.

            Iterate over the data and display it.

            return the completed dictionary to complete the test

         *
         * 
         * 
         */

        public Dictionary<string, string> DictionaryTest() {

            dictionary.Add("England", "London");
            dictionary.Add("Ireland", "Dublin");
            dictionary.Add("France", "Paris");
            dictionary.Add("Germany", "Berlin");
            dictionary.Add("Italy", "Rome");
            dictionary.Add("Russia", "Moscco");
            dictionary.Add("Peru", "Lima");
            dictionary.Add("Ghana", "Accra");
            dictionary.Add("Oslo", "Norway");
            dictionary.Add("Jamaica", "Kingston");

            return dictionary;
        }
        
        

        /*
         * 
         * 
         
           ### Lab 4 : Queue

            Count from 1 to 100 and add the cubes of each number to a queue.  

            Run dequeue 10 times and sum the output

            Return this sum.

            


         *
         * 
         * 
         */

        public int QueueTest()
        {
            int sum;
            for (int i = 1; i < 101; i++)
            {
                queue.Enqueue(i * i * i);
            }

            sum = queue.Dequeue();
            for (int i = 0; i < 9; i++)
            {

            sum =  sum + queue.Dequeue();
            }

            return sum;
        }




        /*
        * 
        * 

            ### Lab 5 : Stack

            Repeat this for a stack ie count from 1 to 100, 
            add the cube of each number to the stack, 
            then `pop` 10 items off the top of the stack 
            and sum the output of those 10 numbers.

            Return this sum

        *
        * 
        * 
        */

        public int StackTest()
        {
            int sum;
            for (int i = 1; i < 101; i++)
            {
                stack.Push(i * i * i);
            }

            sum = stack.Pop();
            for (int i = 0; i < 9; i++)
            {

                sum = sum + stack.Pop();
            }

            return sum;
        }



    }
}

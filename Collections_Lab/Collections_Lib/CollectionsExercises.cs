using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {
        //Not sure how this works
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            List<string> q = new List<string>();
            if(num > queue.Count)
            {
                for(int i =1; i < 6; i++)
                {
                    q.Add(queue.Dequeue());
                }
                string result = string.Join(", ", q);
                return result;
            }
            else
            {
                for(int i = 0; i < num; i++)
                {
                    q.Add(queue.Dequeue());
                }
                string result = string.Join(", ", q);
                return result;
            }
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] reversed = new int[original.Length]; 
            var stack = new Stack<int>();
            foreach(var n in original)
            {
                stack.Push(n);
            }
            for(int i = 0; i < original.Length; i++)
            {
                reversed[i] = stack.Pop();
            }
            return reversed;
        }


        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            //input string
            //go through string
            //find numbers 0 -9, count them
            //return the number and count as a string
            string result = "";
            Dictionary<char, int> countDict = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (Char.IsDigit(c))
                {
                    if (countDict.ContainsKey(c))
                    {
                        countDict[c]++;
                    }
                    else
                    {
                        countDict.Add(c, 1);
                    }
                }
            }
            foreach (var entry in countDict)
            {  
                result += $"[{entry.Key}, {entry.Value}]";
            }
            return result;

          

            //foreach (char c in input)
            //{
            //    if (Char.IsDigit(c))
            //    {
            //        countDict[c]++;
            //    }
            //}
            //return $"{countDict.Keys}{countDict.Values}";

            //foreach (KeyValuePair<char, int> digits in countDict)
            //{
            //   Console.WriteLine($"{digits.Key}{digits.Value}");
            //}
            // return $"{digits.Key}{digits.Value}";

            // return $"{digits.Key}{digits.Value}";


        }
    }
}

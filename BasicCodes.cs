using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class BasicCodes
    {
        // Reverse a string without using built-in functions.
        public string ReverseString(string strInput)
        {
            string result = string.Empty;
            char[] charArray = strInput.ToCharArray();
            for(int i = strInput.Length-1; i >=0; i--)
            {
                result += charArray[i];
            }
            return result;
        }

        //Find the largest element in an integer array.
        public int LargestElement(int[] arr)
        {
            int size = arr.Length;
            int maxelement = Int32.MinValue;//maxvalue is the highest value in the system
            for(int i = 0; i < size; i++)
            {
                if (maxelement < arr[i])
                {
                    maxelement = arr[i];
                }
            }
            return maxelement;
        }

        //hashset example
        public void HashSetExample()
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(10);
            numbers.Add(0);
            numbers.Add(20);
            foreach(int num in numbers)
            Console.WriteLine(num);
        }
        //Remove duplicates from a list using a HashSet.
        public void RemoveDuplicate(int[] arr)
        {
            HashSet<int> uniqueArray = new HashSet<int>(arr);
            foreach (int element in uniqueArray)
                Console.WriteLine(element);
        }

        //dictionary example
        public void DictExample()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("s1", 12);
            students.Add("s2", 12);
            students.Add("s3", 54);
            students.Add("s4", 43);
            foreach (var student in students)
                Console.WriteLine($"{student.Key}::{student.Value}");
        }

        //Find the frequency of elements in an array using a Dictionary.
        public void Frequencies(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (var num in arr)// check for each element in array
            {
                if (frequency.ContainsKey(num)) // if the num exists in frequency dict
                {
                    frequency[num]++; //frequncy of that num is incremented
                }
                else
                {
                    frequency[num] = 1;
                }
            }
            foreach (var freq in frequency)
            {
                Console.WriteLine($"{freq.Key}::{freq.Value}");
            }
        }

        //Check if a given string is a palindrome.
        public bool IsPalindrome(string input)
        {
            string reversed = string.Empty;
            char[] charArray = input.ToCharArray();
            for(int i = input.Length-1; i >=0; i--)
            {
                reversed += charArray[i];
            }
            Console.WriteLine($"reversed::{reversed}");

            return reversed.Equals(input) ;
        }

        //Find the sum of all elements in an array.
        public int ArraySum(int[] arr)
        {
            int sum = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        //Merge two sorted arrays into a single sorted array.
        public void MergeSortArrays(int[] arr1, int[] arr2)
        {
            int[] resultArray=new int[arr1.Length+arr2.Length];
            int size = resultArray.Length;
            for (int i = 0; i < arr1.Length; i++)
            {
                resultArray[i] = arr1[i];
            }
            for(int j = 0; j < arr2.Length; j++)
            {
                resultArray[arr1.Length+j] = arr2[j];
            }
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size- i - 1; j++)
                {
                    if (resultArray[j] > resultArray[j + 1])
                    {
                        int temp = resultArray[j];
                        resultArray[j] = resultArray[j + 1];
                        resultArray[j + 1] = temp;
                    }
                }
                Console.WriteLine(resultArray[i]);
            }
        }

        //Implement a simple stack using an array.

    }
}

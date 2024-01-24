using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] array3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(array3.Max());
            Console.WriteLine(array3.Min());
            Console.ReadLine();

            Console.WriteLine("*******");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*******\n");


            Console.WriteLine("********");
            Console.WriteLine("*******");
            Console.WriteLine("******");
            Console.WriteLine("*****");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*\n");



            int[] a = { 1, 2, 2, 3, 4, 5, 6, 6, 6, 6, 7, 7, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{a[i]}. {count}");

            }

            int[] array = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1, 8, 9, 5 };

            Console.WriteLine("\nUnique elements in the array:");

            // Use a HashSet to track unique elements
            HashSet<int> uniqueElements = new HashSet<int>();

            foreach (int num in array)
            {
                // Add the element to the HashSet
                // HashSet will automatically discard duplicates
                uniqueElements.Add(num);
            }

            // Print unique elements
            foreach (int uniqueElement in uniqueElements)
            {
                Console.Write(uniqueElement + " ");
            }



            int[] array1 = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1, 8, 9, 5 };

            Console.WriteLine("\n\nFrequency of each element in the array:");

            // Use a Dictionary to track the frequency of each element
            Dictionary<int, int> frequencyDictionary = CountFrequency(array1);

            // Print the frequency of each element
            foreach (var kvp in frequencyDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
            }

            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            string reversedString = ReverseEachWord(inputString);

            Console.WriteLine("Result after reversing each word:\n");
            Console.WriteLine(reversedString);


        }
        static Dictionary<int, int> CountFrequency(int[] array1)
        {
            Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

            foreach (int num in array1)
            {
                if (frequencyDictionary.ContainsKey(num))
                {
                    // Increment the count if the number is already in the dictionary
                    frequencyDictionary[num]++;
                }
                else
                {
                    // Add the number to the dictionary with a count of 1
                    frequencyDictionary.Add(num, 1);
                }
            }

            return frequencyDictionary;

        }

        static string ReverseEachWord(string inputString)
        {
            string[] words = inputString.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }

            return string.Join(" ", words);
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

     
        
    }

           
}

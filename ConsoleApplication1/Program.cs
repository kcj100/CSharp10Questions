using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "John", "Tim", "Rick", "Tom", "Steve" };
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("string array = ");
            PrintArray(names);
            Console.Write("int array = ");
            PrintArray(ints);
            Console.WriteLine("Question 1 GetLastIndex: " + GetLastIndex(names));
            Console.WriteLine("Question 2 GetSecondToLastIndex: " + GetSecondToLastIndex(names));
            Console.WriteLine("Question 3 GetFirstElement: " + GetFirstElement(names));
            Console.WriteLine("Question 4 GetLastElement: " + GetLastElement(names));
            Console.WriteLine("Question 5 GetSecondToLastElement: " + GetSecondToLastElement(names));
            Console.WriteLine("Question 6 GetSum: " + GetSum(ints));
            Console.WriteLine("Question 7 GetAverage: " + GetAverage(ints));
            Console.WriteLine("Question 8 ExtractAllOddNumbers: " + ExtractAllOddNumbers(ints));
            Console.WriteLine("Question 9 ExtractAllEvenNumbers: " + ExtractAllEvenNumbers(ints));
            Console.WriteLine("Question 10 Contains: " + Contains(names, "Tom"));
        }

        private static void PrintArray<T>(T[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine("]");
        }

        // Question 1
        static int GetLastIndex(string[] names)
        {
            return names.Length;
        }

        // Question 2
        static int GetSecondToLastIndex(string[] names)
        {
            return names.Length - 1;
        }

        // Question 3
        static string GetFirstElement(string[] names)
        {
            return names[0];
        }

        // Question 4
        static string GetLastElement(string[] names)
        {
            return names[names.Length - 1];
        }

        // Question 5
        static string GetSecondToLastElement(string[] names)
        {
            return names[names.Length - 2];
        }

        // Question 6
        static int GetSum(int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            return sum;
        }

        // Question 7
        static int GetAverage(int[] ints)
        {
            return GetSum(ints) / ints.Length;
        }

        // Question 8
        static string ExtractAllOddNumbers(int[] numbers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    stringBuilder.Append(numbers[i] + ", ");
                }
            }

            return stringBuilder.ToString().Substring(0, stringBuilder.Length - 2);
        }

        // Question 9
        static string ExtractAllEvenNumbers(int[] numbers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    stringBuilder.Append(numbers[i] + ", ");
                }
            }

            return stringBuilder.ToString().Substring(0, stringBuilder.Length - 2);
        }

        // Question 10
        static bool Contains(string[] names, string element)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
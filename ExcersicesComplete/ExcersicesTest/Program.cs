using ExcersicesTest;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] ints = { 5, 6, 1, 9, 3, 15, 7, 2, 8, 4 };
            foreach (int i in ints) { Console.Write(i+" "); }

            Algorithms algorithms = new Algorithms();
            //algorithms.BubbleSort(ints);
            //algorithms.InsertionSort(ints);
            algorithms.QuickSort(ints, 0, ints.Length - 1);
            Console.WriteLine("");
            int number = 15;
            
            foreach (int i in ints) { Console.Write(i+" "); }
            int r = algorithms.BinarySearch(ints, number);
            Console.WriteLine("");
            Console.WriteLine(number + " is in position: " + r);
            
            
            //Problems
            Problems problems = new Problems();
            string word = "anitalavalatona";
            Console.WriteLine("is palndrome " + word + ": " + problems.Palindrome(word));

            problems.ReverseWord("Carlos");
            Console.WriteLine("");
            problems.ReverseWords("Carlos Perez Ramirez");
            Console.WriteLine("");
            problems.SubString("carlos");*/
            Problems problems = new Problems();
            problems.CountLetters();
        }

        
    }
}
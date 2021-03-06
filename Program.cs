﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();
            Console.WriteLine("The L Fruits");
            Console.WriteLine(LFruits);

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 2 == 0);
            Console.WriteLine("The multiples");
            Console.WriteLine(fourSixMultiples);


            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };
            List<string> descend = names.OrderByDescending(name => names).ToList();
            Console.WriteLine("The names");
            Console.WriteLine(descend);

            // Build a collection of these numbers sorted in ascending order
            List<int> theNumbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            List<int> ascending = theNumbers.OrderBy(number => number).ToList();
            Console.WriteLine("Ascending numbers");
            Console.WriteLine(ascending);

            // Output how many numbers are in this list
            List<int> numberCount = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            int count = numberCount.Count();
            Console.WriteLine("How many numbers?");
            Console.WriteLine(count);

            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };
            double totalAmount = purchases.Sum();
            Console.WriteLine("Total money made");
            Console.WriteLine(totalAmount);

            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };
            double expensive = prices.Max();
            Console.WriteLine("Most expensive");
            Console.WriteLine(expensive);

        }
    }
}

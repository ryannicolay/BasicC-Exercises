using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithText
{
    class Exercise1
    {
        public void ConsectiveNumbers()
        {
            Console.WriteLine("Please enter some numbers separated by a hyphen:");
            var input = Console.ReadLine();

            var numbers = input.Split('-').Select(int.Parse).ToList();

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]  != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    }

    class Exercise2
    {
        public void Duplicates()
        {
            Console.WriteLine("Please enter some numbers separated by a hyphen:");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = input.Split('-').Select(int.Parse).ToList();

            if (numbers.Distinct().Count() != numbers.Count())
                Console.WriteLine("Duplicates");
        }
    }

    class Exercise3
    {
        public void Validtime()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }


            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

    }

    class Exercise4
    {
        public void PascalCase()
        {
            Console.WriteLine("Enter a few words: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }
    }

    class Exercise5
    {
        public void CountVowels()
        {
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var exercise1 = new Exercise1();
            exercise1.ConsectiveNumbers();

            var exercise2 = new Exercise2();
            exercise2.Duplicates();

            var exercise3 = new Exercise3();
            exercise3.Validtime();

            var exercise4 = new Exercise4();
            exercise4.PascalCase();


        }
    }
}

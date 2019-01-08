using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Exercise1
    {
        public string GetNames()
        {
            var likes = new List<string>();
            var name = "";

            do
            {
                Console.WriteLine("Please Enter a Name.");
                name = Console.ReadLine();
                Console.WriteLine(name);
                if (!string.IsNullOrEmpty(name))
                {
                    likes.Add(name);
                }
                   
                
            } while (name != "");

            if (likes.Count == 1)
            {
                return likes[0] + " likes your post";
            }
            if (likes.Count == 2)
            {
                return likes[0] + " and " + likes[1] + " likes your post";
            }
            if (likes.Count >= 3)
            {
                return likes[0] + ", " + likes[1] + " and " + (likes.Count-2) + " others likes your post";
            }

            return name;
        }
    }

    class Exercise2
    {
        public string ReverseName()
        {
            Console.WriteLine("Please enter a name.");
            var name = Console.ReadLine();
            char[] array = name.ToCharArray(0, name.Length);
            
            Array.Reverse(array);

            return new string(array);

        }
    }

    class Exercise3
    {
        public void UniqueNumbers()
        {
            var numberList = new List<int>();

            while (numberList.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                var inputedNumber = Convert.ToInt32(Console.ReadLine());
                if (numberList.Contains(inputedNumber))
                {
                    Console.WriteLine("You've previously entered " + inputedNumber);
                    continue;
                }

                numberList.Add(inputedNumber);
            }

            numberList.Sort();

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
        }
    }

    class Exercise4
    {
        public void ListUniqueNumbers()
        {
            var input = "";
            var numbers = new List<int>();

            while (input != "Quit")
            {
                Console.WriteLine("Please enter a number:");
                input = Console.ReadLine();

                if (Int32.TryParse(input, out int result))
                {
                    numbers.Add(result);
                }
            }

            var newList = numbers.Distinct().ToList();

            foreach (var number in newList)
            {
                Console.WriteLine(number);
            }
        }
    }

    class Exercise5
    {
        public void SmallestThree()
        {
            Console.WriteLine("Please enter at least five numbers seperated by commas");
            var input = Console.ReadLine();

            var listNumbers = input.Split(',').Select(int.Parse).ToList();

            if (listNumbers.Count < 5)
            {
                Console.WriteLine("Invalid List \n");
                Console.WriteLine("Please re-try entering numbers.");
            }

            listNumbers.Sort();

            for (var i = 0; i <= 2; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var exercise1 = new Exercise1();
            var exercise2 = new Exercise2();
            var exercise3 = new Exercise3();
            var exercise4 = new Exercise4();
            var exercise5 = new Exercise5();

            Console.WriteLine(exercise1.GetNames());

            Console.WriteLine(exercise2.ReverseName());

            exercise3.UniqueNumbers();

            exercise4.ListUniqueNumbers();

            exercise5.SmallestThree();
        }
    }
}

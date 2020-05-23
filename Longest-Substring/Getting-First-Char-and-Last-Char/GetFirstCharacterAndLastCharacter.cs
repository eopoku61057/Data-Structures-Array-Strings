using System;

namespace DataStructure
{
    class Program : SortedZeros
    {
        static void Main(string[] args)
        {
            // Array of string
            string[] stringValues = { "Dot Net Pearls", "D", "", "Sam" };

            // loop over string values
            foreach (var value in stringValues)
            {
                // display string
                Console.WriteLine("--- '{0}' ----", value);

                // We can't get chars from empty or null strings
                if (!string.IsNullOrEmpty(value))
                {
                    char first = value[0];
                    char second = value[value.Length - 1];

                    Console.WriteLine("First Char: ");
                    Console.WriteLine(first);

                    Console.WriteLine("Second Char: ");
                    Console.WriteLine(second);
                }
            }
        }

    }
}

using System;

namespace vericlaim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cases: ");
            if (int.TryParse(Console.ReadLine(), out int numOfCases))
            {
                for (int i = 1; i <= numOfCases; i++)
                {
                    Console.WriteLine($"Enter sentence {i}: ");
                    string sentence = Console.ReadLine();

                    try
                    {
                        string reversedSentence = sentence.ReverseWords();
                        Console.WriteLine($"Case {i}: {reversedSentence}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error occurred while processing sentence {i}: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the number of cases.");
            }
        }
    }
    }


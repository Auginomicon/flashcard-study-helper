using System;
using System.Collections.Generic;
using System.Linq;

namespace FlashcardStudyHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create general flashcard dictionary to hold questions and answers
            Dictionary<string, string> genericFlashcards = new Dictionary<string, string>();

            // Add in flashcards to the generic question dictionary
            genericFlashcards.Add(".NET Compilier", "C# Compiler → Intermediate Language → Common Language Runtime → Just-In-Time (JIT)");
            genericFlashcards.Add("Name the different naming conventions.","-PascalCase\n-camelCase\n-snake_case");
            genericFlashcards.Add("What are the components of a Method Signature?","Descriptive name, return type, input parameters");
            genericFlashcards.Add("Describe the Ternary Operator", @"Shorthand conditon for if-else. Looks like this\n(condition) ? [Result if True] : [Result if False];");
            genericFlashcards.Add("What is a do while loop?", "Essentially a while loop but it will always run at least once.");
            genericFlashcards.Add("What is the new keyword?", "Using it allows us to instantiate a brand new object or instance of a class.");

            // Create a interviewer flashcard dictionary to hold questions and answers
            Dictionary<string, string> interviewFlashcards = new Dictionary<string, string>();

            // Add in flashcards to the interview question dictionary
            interviewFlashcards.Add("What is an instance of a class?", "An in-memory data structure that combines state and behavior");
            interviewFlashcards.Add("Difference between an interface and abstract class?", "Abstract Class: \n-Contains method bodies and fields \n-Is inherited \n Interface \n-No method bodies or fields. \n-Are implemented.");
            interviewFlashcards.Add("How should a unit test be structured?", "Arrange: set up code we want to test \nAct: Do some form of an action that we want to verify correct\nAssert: Verify expected results");
            interviewFlashcards.Add("Whats the difference between Agile and Waterfall Development?", "Waterfall \n-Squential model\n-Limtied scope for change\n\nAgile\n-Flexible/Embraces change\n-Incremental approach");
            interviewFlashcards.Add("What is virtual and override?", "In the parent, the method must be marked as virtual. In the child, the method must be marked as override.");

            bool isStudying = true;

            while (isStudying)
            {
                // Get user input on what group of cards they want to use
                Console.WriteLine("What flashcard group do you want to study from? \n1. Generic Questions \n2. Interview Questions \n3. Quit");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                
                // Checks if they put in 1, 2, 3 or something else
                if (int.TryParse(userInput, out int n) && (n == 1 || n == 2))
                {
                    // Go into a switch case to determine what flashcard group to go into
                    // TODO: Refactor this so that it looks less cluttered. Make more methods?
                    switch (n)
                    {
                        case 1:
                            {
                                string[] keys = genericFlashcards.Keys.ToArray();
                                Random rand = new Random();
                                do
                                {
                                    int index = rand.Next(keys.Length);
                                    Console.WriteLine(keys[index] + "\n");
                                    Console.WriteLine("Press enter to flip!");
                                    Console.ReadLine();

                                    Console.WriteLine(genericFlashcards[keys[index]]);

                                    Console.WriteLine("Another one? (Y/N)");
                                    userInput = Console.ReadLine();
                                    Console.WriteLine();
                                    if (userInput.ToLower() == "n")
                                    {
                                        break;
                                    }

                                } while (true);
                            }                            
                            break;
                        case 2:
                            {
                                string[] keys = interviewFlashcards.Keys.ToArray();
                                Random rand = new Random();
                                do
                                {
                                    int index = rand.Next(keys.Length);
                                    Console.WriteLine(keys[index] + "\n");
                                    Console.WriteLine("Press enter to flip!\n");
                                    Console.ReadLine();

                                    Console.WriteLine(interviewFlashcards[keys[index]]);

                                    Console.WriteLine();
                                    Console.WriteLine("Another one? (Y/N)");
                                    userInput = Console.ReadLine();
                                    Console.WriteLine();
                                    if (userInput.ToLower() == "n")
                                    {
                                        break;
                                    }
                                } while (true);
                                break;
                            }
                    }                    
                }
                else if (int.TryParse(userInput, out n) && n == 3)
                {
                    isStudying = false;
                }
                else
                {
                    Console.WriteLine("Please type a valid input!\n");
                }                
            }
        }       
    }
}

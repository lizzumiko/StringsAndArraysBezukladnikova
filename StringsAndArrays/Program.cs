using System;

namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";

            // 1.1 Print the length of the string.
            int length = helloWorld.Length;

            Console.WriteLine("The length of the string is: " + length);

            // 1.2 Print the first and the last character of the string.
            char char1 = helloWorld[0];

            char lastch = helloWorld[helloWorld.Length - 1];

            Console.WriteLine("First character: " + char1);
            Console.WriteLine("Last character: " + lastch);
            // 2. String Manipulation

            Console.Write("Please enter your name: ");
            // 2.1 Get the input from and assing it into new string variable called name
            string name = Console.ReadLine();

            // 2.2 Print a personalized welcome message including the name.

            Console.WriteLine("Hello, " + name + "! Welcome to the program!");
            // 2.3 Convert name variable to uppercase and output the result
            string uppercaseName = name.ToUpper();
            Console.WriteLine("Uppercase name: " + uppercaseName);
            // 2.4 Convert name variable to lovercase and output the result
            string lowercaseName = name.ToLower();
            Console.WriteLine("Lowercase name: " + lowercaseName);
            // 3. String Searching
            // 3.1 Create new boolean variable called containsWorld
            bool containsWorld = helloWorld.Contains("World");
            // 3.2 Check that the helloWorld variable contains the word "World".
            if (containsWorld)
            {
                Console.WriteLine("The string 'helloWorld' contains the word 'World'.");

                int index = helloWorld.IndexOf("World");
                Console.WriteLine("Index of 'World' in 'helloWorld': " + index);
            }
            else
            Console.WriteLine("The string 'helloWorld' does not contain the word 'World'.");
                // PART 2: Arrays

                // 1. Basic Array Operations
                // 1.1 initialize array called numbers containing array of int values
                //     Add these values to the array -> 2 3 5 7 11 
                int[] numbers = { 2, 3, 5, 7, 11 };
                // 1.2 Output the numbers array -> hint use Join
                // Expected outcome: 2, 3, 5, 7, 11
                string numbersString = string.Join(", ", numbers);
                Console.WriteLine(numbersString);
                // 1.3 Output the value of the third (3th) item in the numbers array 
                // Expected outcome: 5
                Console.WriteLine(numbers[2]);

                // 2. Array Manipulation
                Console.WriteLine("Please enter five names:");
            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5
            string[] names = new string[5];
            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            string allNames = string.Join(", ", names);
            Console.WriteLine("Names entered by the user: " + allNames);

            // 2.4 Reverse the order of the items in the names array and outpu the result
            Array.Reverse(names);
            string jojo = string.Join(", ", names);
            Console.WriteLine("Names entered by the user in reverse order: " + jojo);

            // 3. Array Searching
            Console.Write("Please enter a name to search: ");
                string searchName = Console.ReadLine();
            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable
            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            Array.Reverse(names);
            int position = Array.IndexOf(names, searchName);
            if (position != -1)
            {
                Console.WriteLine($"The name '{searchName}' was found at position {position} in the array.");
            }
            else
            
                Console.WriteLine($"The name '{searchName}' was not found in the array.");

            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array
            string[] words;
            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array
            words = helloWorld.Split(new char[] { ' ', ',', '!' });
            // 1.3 Output the values of the words array
            Console.WriteLine("Words extracted from helloWorld: " + string.Join(", ", words));
        }
        }
    }



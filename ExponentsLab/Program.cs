using System;

namespace ExponentsLab
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1) Welcome and prompt user to enter their name
            //2) Get user input
            //3) Prompt the user
            //4) Read in their input within the statement

            Console.WriteLine("Learn Your Squared and Cubes App!\n");
            string userName = GetInput("What is your name?");
            Console.WriteLine($"\nHello {userName}! Welcome to the Learning Your Squared and Cubes App!");
            bool goOn = true;
            while (goOn)
            {
                //1) Determine input is equal to 0
                //2) Start a boolean loop
                //3) Determining if input number is valid
                //4) If number is valid, calculate the squared and cubes of the user's input

                string result;
                int intResult = 0;
                bool invalidAnswer = true;

                while (invalidAnswer)
                {
                    //1) Prompt user to enter input
                    //2) Convert input into an integer
                    //3) If the input number is greater than 1291 prompt the user to enter a correct number
                    //4) If input is less than 1 prompt the user to enter a correct number
                    //5) If input is a valid number prompt user to continue 

                    result = GetInput("\nPlease enter an integer:");
                    intResult = int.Parse(result);
                    if (intResult >= 1291)
                    {
                        Console.WriteLine("\nPlease choose an integer between 1 and 1291");
                    }
                    else if (intResult < 1)
                    {
                        Console.WriteLine("\nPlease choose an integer between 1 and 1291");
                    }
                    else
                    {
                        invalidAnswer = false;
                    }
                }
                //1) Formula to determine the integers squared and cubed answers
                //2) If the number is a valid input prompt user to Continue
                //3) The number is not valid prompt the user to enter a valid number

                Console.WriteLine("\n{0, -20} {1, -20} {2, -20}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0, -20} {1, -20} {2, -20}", "=======", "=======", "=======");
                for (int i = 1; i <= intResult; i++)
                {
                    Console.WriteLine("{0, -20} {1, -20} {2, -20}", i, i * i, i * i * i);
                }
            
              goOn = Continue();
            }
        }    
       
        public static string GetInput(string prompt)
        {
            //1) Get user input
            //2) Prompt the user
            //3) Read in user's input

            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public static bool Continue()
        {
            //1) continue loop
            //2) Ask the user would you like to continue y/n 
            //4) user says y to continue
            //5) n to stop the main loop
            //6) anything else -> try getting input again

            Console.WriteLine("\nWould you like to continue? y/n");
            string answer = Console.ReadLine().ToLower();

            if(answer == "y")
            {
                return true;
            }
            else if(answer == "n")
            {
                Console.WriteLine($"\nThanks for stopping by!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI am sorry I did not understand that.");
                Console.WriteLine("Let's try that again.");
                return Continue();
             }
        }
    }
}

using System.Runtime.InteropServices;

namespace Task2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1- Countdown Timer
            // Some Code To Solove The Task

            Console.WriteLine("Enter the countdown time: ");
            int countdownTime = int.Parse(Console.ReadLine());

            for (int i = countdownTime; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);


            }
            Console.WriteLine("Countdown finished!");

            ///////////////////////////////////////////////////

            //2- Sum Of Nambers 1 to N
            // Some Code To Solove The Task

            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                total += i;
            }
            Console.WriteLine("The final sum is:" + total);

            //////////////////////////////////////////////////////

            //3- Multiplication Table
            // Some Code To Solove The Task

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
            }

            //////////////////////////////////////////////////////////////

            //4- Password Retry 
            // Some Code To Solove The Task

            string password = "1234";

            Console.WriteLine("Enter the password: ");
            string inputpassword = Console.ReadLine();

            while (inputpassword != password)
            {
                Console.WriteLine("Incorrect password. Please try again: ");
                Console.WriteLine("Enter the password: ");
                inputpassword = Console.ReadLine();
            }

            Console.WriteLine("Access granted!");

            ////////////////////////////////////////////////////////////////

            //5- Number Guessing Game
            // Some Code To Solove The Task 

            int secretNum = 18;
            int attemptsCount = 0;
            int currentGuess = 0;

            do
            {
                Console.WriteLine("Guss the number: ");
                currentGuess = int.Parse(Console.ReadLine());
                attemptsCount++;

                if (currentGuess > secretNum)
                {
                    Console.WriteLine("Too High");
                }
                else if (currentGuess < secretNum)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Correct! It took you " + attemptsCount + " attempts.");
                }

            } while (currentGuess != secretNum);

            ////////////////////////////////////////////////////////////////////

            //6- Safe Division Calculator
            // Some Code To Solove The Task 

            try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int divisionResult = num1 / num2;
                Console.WriteLine("The result of the division is: " + divisionResult);

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input is not a valid number.");
            }

            //////////////////////////////////////////////////////////////////

            //7- Repating Menu with Exit Option
            // Some Code To Solove The Task 

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected Option 1.");
                        break;
                    case "2":
                        Console.WriteLine("You selected Option 2.");
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Exiting the menu.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }

            ///////////////////////////////////////////////////////////////////////


            //8- Sum of Even Numbers Only
            // Some Code To Solove The Task 

            Console.WriteLine("Enter Even Number Only: ");
            int evenNumber = int.Parse(Console.ReadLine());
            int evenSum = 0;

            for (int i = 1; i <= evenNumber; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
            }

            Console.WriteLine("The final sum of even numbers is: " + evenSum);

            /////////////////////////////////////////////////////////////////////////

            //9- Validated Positive Number Input
            // Some Code To Solove The Task 

            int validPositiveNum = 0;
            bool isValidInput = false;

            
            do
            {
                try
                {
                    Console.Write("Please enter a positive number: ");
                    validPositiveNum = int.Parse(Console.ReadLine());

                    
                    if (validPositiveNum <= 0)
                    {
                        Console.WriteLine("Error: Number must be greater than zero.");
                        isValidInput = false;
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Input is not a valid whole number.");
                    isValidInput = false;
                }
            } while (!isValidInput);

            
            int validatedLoopSum = 0;
            for (int i = 1; i <= validPositiveNum; i++)
            {
                validatedLoopSum += i;
            }
            Console.WriteLine("The sum of numbers from 1 to " + validPositiveNum + " is: " + validatedLoopSum);

            ////////////////////////////////////////////////


            //10- Simple ATM Simulation
            // Some Code To Solove The Task 

            /// I Don't Know how To Slove It I Tryed. 





        }
    }
}
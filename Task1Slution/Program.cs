using System.Drawing;

namespace Task1Slution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Personal Info Card

            String name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hight: " + height);
            Console.WriteLine("Student: " + isStudent);

            ////////////////////////////////////////////////

            //Task 2 - Rectangle Calculator

            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            ////////////////////////////////////////////////////

            //Task 3 - Even or Odd Checker

            Console.Write("Enter a whole number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }

            ///////////////////////////////////////////////////

            //Task 4 - Voting Eligibility

            Console.Write("Enter your age: ");
            int votingAge = int.Parse(Console.ReadLine());

            Console.Write("Do you hold a valid national ID? (yes/no): ");
            string idInput = Console.ReadLine().ToLower();

            bool hasValidId = (idInput == "yes");

            if (votingAge >= 18 && hasValidId)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            //////////////////////////////////////////////////////

            //Task 5 - Grade Letter Lookup

            Console.WriteLine("Enter Your Grage Letter (A, B, C, D, F): ");
            char grade = char.Parse(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good Job!");
                    break;
                case 'C':
                    Console.WriteLine("You can do better!");
                    break;
                case 'D':
                    Console.WriteLine("You need to work harder!");
                    break;
                case 'F':
                    Console.WriteLine("You failed!");
                    break;
                default:
                    Console.WriteLine("Invalid grade letter.");
                    break;
            }

            ////////////////////////////////////////////////////////

            //Task 6 - Temperature Converter

            Console.WriteLine("Enter Temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

            if (celsius < 10)
            {
                Console.WriteLine("Colde");
            }
            else if (celsius >= 10 && celsius <= 30)
            {
                Console.WriteLine("Mild");
            }
            else
            {
                Console.WriteLine("Hot");
            }

            ////////////////////////////////////////////

            //Task 7 - Movie Ticket Pricing

            Console.Write("Enter your age: ");
            int movieAge = int.Parse(Console.ReadLine());

            if (movieAge >= 0 && movieAge <= 12)
            {
                Console.WriteLine("Category: Children, Price: 2.000 OMR");
            }
            else if (movieAge >= 13 && movieAge <= 59)
            {
                Console.WriteLine("Category: Adults, Price: 5.000 OMR");
            }
            else if (movieAge >= 60)
            {
                Console.WriteLine("Category: Seniors, Price: 3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }

            ///////////////////////////////////////////////////////////

            //Task 8 - Restaurant Bill with Membership Discount

            Console.Write("Enter total bill amount (OMR): ");
            double totalBill = double.Parse(Console.ReadLine());

            Console.Write("Are you a loyalty member? (yes/no): ");
            string memberInput = Console.ReadLine().ToLower();

            bool isMember = (memberInput == "yes");
            double discountAmount = 0.0;

            if (totalBill > 20 && isMember)
            {
                discountAmount = totalBill * 0.15;
            }

            double finalBillAmount = totalBill - discountAmount;

            Console.WriteLine("Original Bill: " + totalBill + " OMR");
            Console.WriteLine("Discount Amount: " + discountAmount + " OMR");
            Console.WriteLine("Final Amount to Pay: " + finalBillAmount + " OMR");

            //////////////////////////////////////////////////////////////

            //Task 9 - Day Name Finder


            Console.Write("Enter a number (1-7): ");
            int dayNum = int.Parse(Console.ReadLine());

            switch (dayNum)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Invalid day number"); break;
            }
            /////////////////////////////////////////////////////////////

            //Task 10 - Mini Calculator

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /, %): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (num1 % num2));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            //////////////////////////////////////////////////////////////

            //from 11 to 15 i don't Know the slotion 
































        }
    }
}

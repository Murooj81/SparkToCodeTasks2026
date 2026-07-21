using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4Slution
{
    internal class Program
    {
        private static object name;
        private static object avg;
        private static object grade;
        private static object printReportCard;

        static void Main(string[] args)
        {

            //Task 1 - Personalized Welcome Function

            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();
            PrintWelcome(nameInput);

            static void PrintWelcome(string name)
            {
                Console.WriteLine("Welcome, " + name + "!");
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 2 - Square Number Function

            Console.Write("Enter an integer to square: ");
            int input = int.Parse(Console.ReadLine());

            int result = Square(input);
            Console.WriteLine("The squared result is: " + result);

            static int Square(int number)
            {
                return number * number;
            }

            /////////////////////////////////////////////////////////////////////////////////////

            // Task 3 - Celsius to Fahrenheit Function

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius); 
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);


            static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            //Task 4 - Fixed Menu Display Function

                 DisplayMenu();

         
                static void DisplayMenu()
                {
                    Console.WriteLine("--- System Menu ---");
                    Console.WriteLine("1) Start");
                    Console.WriteLine("2) Help");
                    Console.WriteLine("3) Exit");
                }

            //////////////////////////////////////////////////////////////////////////////////////////////

            //Task 5 - Even or Odd Function

            Console.Write("Enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());

            if (IsEven(inputNum))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 6 - Rectangle Area & Perimeter Functions

            Console.Write("Enter rectangle length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            static double CalculateArea(double length, double width)
            {
                return length * width;
            }
            static double CalculatePerimeter(double length, double width)
            {
                return 2 * (length + width);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 7 - Grade Letter Function

            Console.Write("Enter student score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string gradeLetter = GetGradeLetter(score);
            Console.WriteLine("Assigned Grade: " + gradeLetter);

            static string GetGradeLetter(int score)
            {
                if (score >= 90)
                {
                    return "A";
                }
                else if (score >= 80)
                {
                    return "B";
                }
                else if (score >= 70)
                {
                    return "C";
                }
                else if (score >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }

            //////////////////////////////////////////////////////////////////////////////

            //Task 8 - Countdown Function

            Console.Write("Enter starting counter value: ");
            int startVal = int.Parse(Console.ReadLine());
            Countdown(startVal);

            static void Countdown(int start)
            {
                for (int i = start; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }

            //////////////////////////////////////////////////////////////////////////////////

            //Task 9 - Overloaded Multiply Function

            //Console.WriteLine("[Overload 1 - Two Ints]: " + Multiply(4, 5));
            //Console.WriteLine("[Overload 2 - Two Doubles]: " + Multiply(4.5, 2.0));
            //Console.WriteLine("[Overload 3 - Three Ints]: " + Multiply(2, 3, 4));

            //static int Multiply(int a, int b)
            //{
            //return a * b;
            //}

            //static double Multiply(double a, double b)
            //{
            //return a * b;
            //}
            //static int Multiply(int a, int b, int c)
            //{
            //return a * b * c;
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Task 10 - Overloaded Area Calculator

            //////////////////////////////////////////////////////////////////////////////////

            //Task 11 - Function - Based Calculator

            //////////////////////////////////////////////////////////////////////////////////

            //Task 12 - Student Report Card Generator

            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter student score 1: ");
            double score1 = double.Parse(Console.ReadLine());

            Console.Write("Enter student score 2: ");
            double score2 = double.Parse(Console.ReadLine());

            Console.Write("Enter student score 3: ");
            double score3 = double.Parse(Console.ReadLine());

            double avg = (score1 + score2 + score3);
            string grade = GetGradeLetter((int)avg);

            printReportCard((string)name, avg, grade);

            static double calculateAverage(double s1, double s2, double s3)
            {
                return (s1 + s2 + s3) / 3;
            }
            //static string GetGradeLetter(double average)
            //{
                //if (average >= 90) return "A";
                //else if (average >= 80) return "B";
                //else if (average >= 70) return "C";
                //else if (average >= 60) return "D";
                //else return "F";
            //}

            static void printReportCard(string name, double avg, string grade)
            {
                Console.WriteLine("Student Name: " + name);
                Console.WriteLine("Average Score: " + avg);
                Console.WriteLine("Grade: " + grade);

            }

        }
    }
}

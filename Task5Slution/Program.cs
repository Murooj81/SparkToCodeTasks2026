namespace Task5Slution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Fixed Grades Array

            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nStudent Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 2 - Dynamic To-Do List

            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                tasks.Add(Console.ReadLine());
            }

            Console.WriteLine("\nTo-Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///

            //Task 3 - Browsing History Stack

            Stack<string> browserHistory = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL: ");
                browserHistory.Push(Console.ReadLine());
            }

            string lastPage = browserHistory.Pop();

            Console.WriteLine("\nBack button pressed.");
            Console.WriteLine("Removed page: " + lastPage);

            Console.WriteLine("Current page:");

            if (browserHistory.Count > 0)
            {
                Console.WriteLine(browserHistory.Peek());
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 4 – Customer Service Queue

            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name: ");
                customers.Enqueue(Console.ReadLine());
            }

            Console.WriteLine();

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Served Customer: " + servedCustomer);

            Console.WriteLine("\nRemaining Customers:");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 5 – Array Grade Range

            _ = new int[5];
            int sum = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            double average = (double)sum / grades.Length;

            Console.WriteLine("\nLowest Grade : " + grades[0]);
            Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            Console.WriteLine("Average      : " + average);

            ///////////////////////////////////////////////////////////////////////////////
            ///


            //Task 6 – Filtered Shopping List

            List<string> shoppingList = new List<string>();

            string shoppingItem = "";

            while (shoppingItem.ToLower() != "done")
            {
                Console.Write("Enter item (type done to finish): ");
                shoppingItem = Console.ReadLine();

                if (shoppingItem.ToLower() != "done")
                {
                    shoppingList.Add(shoppingItem);
                }
            }

            Console.WriteLine("\nShopping List:");

            foreach (string product in shoppingList)
            {
                Console.WriteLine(product);
            }

            Console.Write("\nEnter item to remove: ");
            string removeItem = Console.ReadLine();

            shoppingList.Remove(removeItem);

            Console.WriteLine("\nShopping List After Removal:");

            foreach (string product in shoppingList)
            {
                Console.WriteLine(product);
            }

            ///////////////////////////////////////////////////////////////////////////////
            ///

            //Task 7 – High Score Podium

            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score " + (i + 1) + ": ");
                scores.Add(int.Parse(Console.ReadLine()));
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("\nTop 3 Scores");

            Console.WriteLine("1st Place: " + scores[0]);
            Console.WriteLine("2nd Place: " + scores[1]);
            Console.WriteLine("3rd Place: " + scores[2]);

            ///////////////////////////////////////////////////////////////////////////////
            ///

            //Task 8 – Undo Last Action

            Stack<string> actions = new Stack<string>();

            string action = "";

            while (action.ToLower() != "stop")
            {
                Console.Write("Enter action (type stop to finish): ");
                action = Console.ReadLine();

                if (action.ToLower() != "stop")
                {
                    actions.Push(action);
                }
            }

            Console.WriteLine();

            if (actions.Count > 0)
                Console.WriteLine("Undo: " + actions.Pop());

            if (actions.Count > 0)
                Console.WriteLine("Undo: " + actions.Pop());

            Console.WriteLine("\nRemaining Actions:");



            //////////////////////////////////////////////////////////////////////////////
            ///

            //Task 9 – Grade Analyzer with Functions  



            //List<int> gradeList = new List<int>();

            //Console.Write("How many grades? ");
            // int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //  Console.Write("Enter grade " + (i + 1) + ": ");
            // gradeList.Add(int.Parse(Console.ReadLine()));
            //}

            //double avg = CalculateAverage(gradeList);

            // Console.WriteLine("\nAverage = " + avg);

            // int fail = FindFirstFailing(gradeList);
            //
            //if (fail == 0)
            // {
            //  Console.WriteLine("No failing grades.");
            //}
            // else
            //{
            // Console.WriteLine("First failing grade: " + fail);
            // }

            ////////////////////////////////////////////////////////////////////////////////////        

            //Task 10 – Print Queue Manager

            Queue<string> printJobs = new Queue<string>();

            string job = "";

            while (job.ToLower() != "done")
            {
                Console.Write("Enter print job (done to finish): ");
                job = Console.ReadLine();

                if (job.ToLower() != "done")
                {
                    printJobs.Enqueue(job);
                }
            }

            Console.WriteLine("\nPrint Queue:");

            foreach (string item in printJobs)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nEnter job to cancel: ");
            string remove = Console.ReadLine();

            printJobs = RemoveJob(printJobs, remove);

            Console.WriteLine("\nQueue After Cancellation:");

            foreach (string item in printJobs)
            {
                Console.WriteLine(item);
            }

        }

        static Queue<string> RemoveJob(Queue<string> jobs, string removeJob)
        {
            Queue<string> newQueue = new Queue<string>();

            while (jobs.Count > 0)
            {
                string job = jobs.Dequeue();

                if (job != removeJob)
                {
                    newQueue.Enqueue(job);
                }
            }

            return newQueue;

            //////////////////////////////////////////////////////////////////////////////  
            ///















































        }
    }
}

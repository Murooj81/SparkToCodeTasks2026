using System;
using System.Collections.Generic;

namespace mini_PrpjectSlution
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts (Custom)");
                Console.WriteLine("7. Find Richest Customer (Custom)");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        FindRichestCustomer();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }

        static void AddAccount()
        {
            Console.WriteLine("\n--- Add New Account ---");
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: Customer name cannot be empty.");
                return;
            }

            Console.Write("Enter New Account Number: ");
            string accNum = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(accNum))
            {
                Console.WriteLine("Error: Account number cannot be empty.");
                return;
            }

            // Check if account number already exists
            if (accountNumbers.Contains(accNum))
            {
                Console.WriteLine("Error: This account number is already in use. Account not added.");
                return;
            }

            Console.Write("Enter Initial Deposit Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double initialDeposit) || initialDeposit < 0)
            {
                Console.WriteLine("Error: Initial deposit must be a valid non-negative number.");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(accNum);
            balances.Add(initialDeposit);

            Console.WriteLine($"\nSuccess: Account successfully created for {name}!");
            Console.WriteLine($"Account Number: {accNum} | Balance: ${initialDeposit:F2}");
        }

        static void DepositMoney()
        {
            Console.WriteLine("\n--- Deposit Money ---");
            Console.Write("Enter Account Number: ");
            string accNum = Console.ReadLine().Trim();

            int index = accountNumbers.IndexOf(accNum);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found.");
                return;
            }

            Console.Write("Enter Deposit Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be a positive number.");
                return;
            }

            balances[index] += amount;
            Console.WriteLine($"Success: Deposited ${amount:F2} successfully.");
            Console.WriteLine($"Updated Balance for account {accNum}: ${balances[index]:F2}");
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("\n--- Withdraw Money ---");
            Console.Write("Enter Account Number: ");
            string accNum = Console.ReadLine().Trim();

            int index = accountNumbers.IndexOf(accNum);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found.");
                return;
            }

            Console.Write("Enter Withdrawal Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be a positive number.");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine($"Error: Insufficient funds. Current balance is ${balances[index]:F2}.");
                return;
            }

            balances[index] -= amount;
            Console.WriteLine($"Success: Withdrew ${amount:F2} successfully.");
            Console.WriteLine($"Updated Balance for account {accNum}: ${balances[index]:F2}");
        }

        static void ShowBalance()
        {
            Console.WriteLine("\n--- Show Balance ---");
            Console.Write("Enter Account Number: ");
            string accNum = Console.ReadLine().Trim();

            int index = accountNumbers.IndexOf(accNum);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found.");
                return;
            }

            Console.WriteLine("\n=== Account Details ===");
            Console.WriteLine($"Customer Name  : {customerNames[index]}");
            Console.WriteLine($"Account Number : {accountNumbers[index]}");
            Console.WriteLine($"Current Balance: ${balances[index]:F2}");
        }

        static void TransferAmount()
        {
            Console.WriteLine("\n--- Transfer Amount ---");
            Console.Write("Enter Sender Account Number: ");
            string senderAcc = Console.ReadLine().Trim();
            Console.Write("Enter Receiver Account Number: ");
            string receiverAcc = Console.ReadLine().Trim();

            int senderIndex = accountNumbers.IndexOf(senderAcc);
            int receiverIndex = accountNumbers.IndexOf(receiverAcc);

            if (senderIndex == -1 || receiverIndex == -1)
            {
                Console.WriteLine("Error: One or both account numbers do not exist.");
                return;
            }

            if (senderAcc == receiverAcc)
            {
                Console.WriteLine("Error: Cannot transfer money to the same account.");
                return;
            }

            Console.Write("Enter Transfer Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Error: Transfer amount must be a positive number.");
                return;
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine($"Error: Sender has insufficient funds. Balance: ${balances[senderIndex]:F2}");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine($"\nSuccess: Transferred ${amount:F2} from {senderAcc} to {receiverAcc}.");
            Console.WriteLine($"Sender ({senderAcc}) Updated Balance: ${balances[senderIndex]:F2}");
            Console.WriteLine($"Receiver ({receiverAcc}) Updated Balance: ${balances[receiverIndex]:F2}");
        }

        static void ListAllAccounts()
        {
            Console.WriteLine("\n--- List All System Accounts ---");

            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts found in the system database.");
                return;
            }

            Console.WriteLine(string.Format("{0,-15} | {1,-15} | {2,-12}", "Customer Name", "Account Number", "Balance"));
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < customerNames.Count; i++)
            {
                Console.WriteLine(string.Format("{0,-15} | {1,-15} | ${2,-11:F2}", customerNames[i], accountNumbers[i], balances[i]));
            }
        }

        static void FindRichestCustomer()
        {
            Console.WriteLine("\n--- Find Richest Customer ---");

            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts registered to evaluate.");
                return;
            }

            int richestIndex = 0;
            double maxBalance = balances[0];

            for (int i = 1; i < balances.Count; i++)
            {
                if (balances[i] > maxBalance)
                {
                    maxBalance = balances[i];
                    richestIndex = i;
                }
            }

            Console.WriteLine("=== Highest Balance Customer ===");
            Console.WriteLine($"Name:           {customerNames[richestIndex]}");
            Console.WriteLine($"Account Number: {accountNumbers[richestIndex]}");
            Console.WriteLine($"Balance:        ${balances[richestIndex]:F2}");
        }
    }
}
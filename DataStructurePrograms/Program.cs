using System;
using System.Collections.Generic;


namespace DataStructurePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Programs!");

            string inputFilePath = @"H:\All Asignment\Assignment16&17\DataStructures\DataStructurePrograms\DataStructurePrograms\InputFile.txt";
            string outputFilePath = @"H:\All Asignment\Assignment16&17\DataStructures\DataStructurePrograms\DataStructurePrograms\OutputFile.txt";
            string equationFilePath = @"H:\All Asignment\Assignment16&17\DataStructures\DataStructurePrograms\DataStructurePrograms\Equation.txt";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Select and enter program number:" +
                    "(1. Unordered List, 2. Ordered List, 3. Balanced Parentheses, 4. Bank Cash Counter");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        new UnOrderedList().UnorderListOperations(inputFilePath, outputFilePath);
                        break;
                    case 2:
                        new OrderedList().OrderedListOperations(inputFilePath, outputFilePath);
                        break;
                    case 3:
                        new BalancedParentheses().isBalancedParentheses(equationFilePath);
                        break;
                    case 4:

                        MyQueue<string> customerQueue = new MyQueue<string>();
                        BankCashCounter cashCounter = new BankCashCounter();
                        cashCounter.AddPeopleToQueue(customerQueue);
                        while (customerQueue.head != null)
                        {
                            string customer = customerQueue.head.data;
                            string customerName = customer.Split("-")[0];
                            int customerBalance = Convert.ToInt32(customer.Split("-")[1]);
                            bool isDoNextTransaction = true;
                            while (isDoNextTransaction)
                            {
                                Console.WriteLine($"{customerName},\nSelect an option of transaction(1. Withdraw, 2. Deposit, 3. Check balance, 4. Exit): ");
                                int transactionOption = Convert.ToInt32(Console.ReadLine());
                                switch (transactionOption)
                                {
                                    case 1:
                                        cashCounter.WithDraw(customerName, customerBalance);
                                        break;
                                    case 2:
                                        cashCounter.Deposit(customerName, customerBalance);
                                        break;
                                    case 3:
                                        cashCounter.BalanceCheck(customerName, customerBalance);
                                        break;
                                    default:
                                        customerQueue.Dequeue();
                                        isDoNextTransaction = !isDoNextTransaction;
                                        break;
                                }
                            }

                        }
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
        
    }
}

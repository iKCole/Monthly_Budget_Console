using System;

namespace monthly_budget
{
    /*
    *   NAME:           ISAAC COLEMAN
    *   DATE:           FEBRUARY 28TH, 2020
    *   DESCRIPTION:    COLLECT DATA FOR MONTHLY BUDGET AND DISPLAY THE TOTAL AMOUNT
    *
    */
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = { "Income", "Expenses" };
            double[] budget = { 0, 0 };
            double[] actual = { 0, 0 };


            for (int index = 0; index < month.Length; index++)
            {
                Console.Write($"Enter the amount of {month[index]} in budget: ");
                bool valid = double.TryParse(Console.ReadLine(), out budget[index]);
                if (index == 1)
                {
                    for (int j = 0; j < month.Length; j++)
                    {
                        Console.Write($"Enter the actual amount of {month[j]}: ");
                        valid = double.TryParse(Console.ReadLine(), out actual[j]);
                    }
                }
            }

            double[] difference = { Math.Abs(budget[0] - actual[0]), Math.Abs(budget[1] - actual[1]) };

            double[,] monthlyBudget = {
                { budget[0], actual[0], difference[0] },
                { budget[1], actual[1], difference[1] },
                { (budget[0]+budget[1]), (actual[0]+actual[1]), (difference[0] + difference[1]) } };

            // //check the element within the array below here
            // Console.WriteLine($"{month[0]}: {budget[0]}, {actual[0]}\n{month[1]}: {budget[1]}, {actual[1]}");
            // Console.WriteLine("{0}", Math.Abs(difference[0]).ToString("C"))

            string[] utilities = { "TV & Cable", "Electric", "Gas", "Mobile Phone", "Trash", "Water"};
            double[] budgetBill = new double[6];
            double[] actualBill = new double[6];
            Console.WriteLine("\nEnter the amount of your budget and actual spending: ");
            for (int index = 0; index < 6; index++)
            {
                Console.Write($"{index + 1}. {utilities[index]}");
                int j = index;
                do
                {
                    Console.Write($"  Budget: ");
                    budgetBill[index] = double.Parse(Console.ReadLine());
                    Console.Write($"  Actual: ");
                    actualBill[index] = double.Parse(Console.ReadLine());
                    if(j == index)
                        break;
                } while (true);
            }

            double totalBudget = 0;
            double totalActual = 0;

            for (int i = 0; i < budgetBill.Length; i++)
            {
                totalBudget += budgetBill[i];
                totalActual += actualBill[i];
            }

            string[,] utilityMonth = {
                { utilities[0], budgetBill[0].ToString("C"), actualBill[0].ToString("C") },
                { utilities[1], budgetBill[1].ToString("C"), actualBill[1].ToString("C") },
                { utilities[2], budgetBill[2].ToString("C"), actualBill[2].ToString("C") },
                { utilities[3], budgetBill[3].ToString("C"), actualBill[3].ToString("C") },
                { utilities[4], budgetBill[4].ToString("C"), actualBill[4].ToString("C") },
                { utilities[5], budgetBill[5].ToString("C"), actualBill[5].ToString("C") },
                { "Total:", totalBudget.ToString("C"), totalActual.ToString("C") }
            };

              //display the whole results in a format
            Console.WriteLine("\n   ******MONTHLY BUDGET******\n");
            Console.WriteLine("\tINCOME/EXPENSES");
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|", DateTime.Today.ToString("MMMM"), "BUDGET", "ACTUAL", "DIFFERENCE");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|", month[0], monthlyBudget[0, 0].ToString("C"), monthlyBudget[0, 1].ToString("C"), monthlyBudget[0, 2].ToString("C"));
            Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|", month[1], monthlyBudget[1, 0].ToString("C"), monthlyBudget[1, 1].ToString("C"), monthlyBudget[1, 2].ToString("C"));
            Console.WriteLine("{0}|{1, -10}|{2, -10}|{3, -10}|", "   TOTAL: ", monthlyBudget[2, 0].ToString("C"), monthlyBudget[2, 1].ToString("C"), monthlyBudget[2, 2].ToString("C"));

            for (int index = 0; index < monthlyBudget.Length; index++)
            {

            }

                // Console.WriteLine("{0, -10}|{1, -10}|{2, -10}|{3, -10}|", );
                Console.WriteLine("\tBILLS&UTILITIES\n", ("").PadRight(10, '^'));
            Console.WriteLine("{0, -15}|{1, -10}|{2, -10}|", "UTILITIES", "BUDGET", "ACTUAL");
            Console.WriteLine(("").PadRight(20, '-'));
            for (int a = 0; a < 7; a++)
            {
                Console.WriteLine("{0, -15}|{1, -10}|{2, -10}|", utilityMonth[a, 0], utilityMonth[a, 1], utilityMonth[a, 2]);
            }
        }
    }
}

using System;

namespace RecursiveOperations
{
    public class Program
    {
        const int ToStop = 2;

        public static string GetOperationCombinationsToGivenResult(int n, int x, int currentLevel = 2, int result = 1, string operationExpressionToPrint = "1")
        {
            string resultCollector = "";
            if (currentLevel == n + 1)
            {
                if (result == x)
                {
                    return operationExpressionToPrint + " = " + x + "\n";
                }

                return "";
            }

            resultCollector +=
            GetOperationCombinationsToGivenResult(n, x, currentLevel + 1, result + currentLevel, operationExpressionToPrint + " + " + currentLevel);
            resultCollector +=
            GetOperationCombinationsToGivenResult(n, x, currentLevel + 1, result - currentLevel, operationExpressionToPrint + " - " + currentLevel);

            if (resultCollector.Length == 0 && currentLevel == ToStop)
            {
                return "N/A";
            }

            return resultCollector;
        }

        static void Main()
        {
            Console.WriteLine(GetOperationCombinationsToGivenResult(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        }
    }
}

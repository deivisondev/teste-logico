using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Questions
{
    public static class ThirdQuestion
    {
        public static void Execute()
        {
            double[] dailyBillingList = [123.4, 213.2, 0, 12312.43, 45632.21, 0, 12321.2, 3021.2, 1231.6, 0];
            double maxValue = dailyBillingList[0];
            double minValue = dailyBillingList[0];
            double sum = 0;
            int daysWithoutBilling = 0;
            int daysAboveAverage = 0;

            for (int i = 0; i < dailyBillingList.Length; i++)
            {
                double value = dailyBillingList[i];

                if (value > maxValue) maxValue = value;
                if (value < minValue) minValue = value;

                if (value == 0)
                    daysWithoutBilling++;
                else
                    sum += value;
            }

            double average = sum / (dailyBillingList.Length - daysWithoutBilling);

            for (int i = 0; i < dailyBillingList.Length; i++)
            {
                double value = dailyBillingList[i];

                if (value > average) daysAboveAverage++;
            }

            Console.WriteLine($"Menor valor: {minValue}\nMaior valor:{maxValue}\nNúmero de dias superior à média anual: {daysAboveAverage}");
        }
    }
}

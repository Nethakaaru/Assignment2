using System;

namespace Assignment2
{
    /// <summary>
    /// A class used to request then convert currency into another currency using a do while loop.
    /// Author: Sebastian Aspegren
    /// </summary>
    public class CurrencyConverter
    {
        private double sum;
        private bool done = false;
        private double newCurrencySum;
        private string currencyName;
        private double rate;

        ///  <summary>
        /// The method that is called when 3 is selected. Calls all other methods regarding that selection.
        ///  </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();
        }
        /// <summary>
        /// Print information about this class / Menu selection.
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n +++++++ The Currency Converter +++++++\n");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to use correct decimal character.\n");
        }
        /// <summary>
        /// Loop and call the method ReadInput. Add the return value to the sum variable.
        /// When the loop is finished prompt the user for the currency name and exchange rate then calculate the sum of the new currency.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            do
            {
                sum += ReadInput();
            } while (!done);
            currencyName = RequestCurrencyName();
            rate = RequestExchangeRate();
            newCurrencySum = sum / rate;
        }
        /// <summary>
        /// Method used to request the user to input the exchange rate of the currency they want to convert theirs into.
        /// </summary>
        /// <returns>
        /// The input
        /// </returns>
        private double RequestExchangeRate()
        {
            Console.Write("Exchange rate: ");
            return double.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Method used to request the user to input the name of the currency they want to convert theirs into.
        /// </summary>
        /// <returns>
        /// the input
        /// </returns>
        private string RequestCurrencyName()
        {
            Console.Write("Name of the foreign currency: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// A method used to read the input of currency and check so it isn't 0.
        /// </summary>
        /// <returns>
        /// The value that was input.
        /// </returns>
        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish: ");
            double num = double.Parse(Console.ReadLine());
            if (num == 0)
            {
                done = true;
            }
            return num;
        }
        /// <summary>
        /// Print the sum, sum of new currency after exchange rate and the exchange rate.
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine();
            Console.WriteLine("{0:C} is converted to {1:f2} {2} at the rate of {3:C}/{2}.", sum, newCurrencySum, currencyName, rate);
        }
    }
}
using System;

namespace Assignment2
{
    /// <summary>
    /// A class used to sum up whole numbers that was input by the user. The user is first prompted to input the amount of numbers they plan on summarize.
    /// Author: Sebastian Aspegren
    /// </summary>
    public class WholeNumbersForAdd
    {
        private int numOfInput;
        private int sum;

        ///  <summary>
        /// The method that is called when 1 is selected. Calls all other methods regarding that selection.
        ///  </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
            ShowResults();
        }
        /// <summary>
        /// Print out basic information regarding this class.
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n +++++++ Summation of whole numbers +++++++");
            Console.WriteLine("\t Using a for-statement\n");
        }
        /// <summary>
        /// Request the user to enter the amount of numbers they plan on entering then read the answer.
        /// </summary>
        private void ReadInput()
        {
            Console.Write("Number of values to sum? ");
            numOfInput = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// A method used to read and summarize the numbers inputed by the user using a for loop.
        /// </summary>
        private void SumNumbers()
        {
            int num = 0;

            for (int i = 0; i < numOfInput; i++)
            {
                Console.Write("Please give the value no {0} <whole number>: ", i + 1);
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
        }
        /// <summary>
        /// Print out a separator and the sum of the numbers.
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
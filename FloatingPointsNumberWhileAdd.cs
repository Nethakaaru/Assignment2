using System;

namespace Assignment2
{
    /// <summary>
    /// A class used to summarize numbers that could be either decimal or whole numbers using a while loop.
    /// Author: Sebastian Aspegren
    /// </summary>
    public class FloatingPointsNumberWhileAdd
    {
        private double sum;
        private bool done = false;

        ///  <summary>
        /// The method that is called when 2 is selected. Calls all other methods regarding that selection.
        ///  </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();
        }
        /// <summary>
        /// Print information regarding this menu selection.
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n +++++++ Summation of real numbers +++++++");
            Console.WriteLine("\t Using While-statement\n");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to use correct decimal character.");
            Console.WriteLine("----------------------------------------------------");
        }
        /// <summary>
        /// While done is false we call ReadInput and add the return value to the sum.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            while (!done)
            {
                sum += ReadInput();
            }
        }
        /// <summary>
        /// Prompt the user to input a number or 0 to end the loop.
        /// Read the input and if it is a 0 then set done to true so the loop in ReadInputAndSumNumbers will end.
        /// </summary>
        /// <returns>
        /// the number input by the user.
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
        /// Print the result of the sum and a separator.
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
using System;

namespace Assignment2
{
    /// <summary>
    /// The Menu class representing a menu which presents a number of options to the user.
    /// Author: Sebastian Aspegren
    /// </summary>
    public class Menu
    {
        ///  <summary>
        /// The Start method in the menu. It loops and keeps requesting input from the user as long as it is not in line with any of the options.
        /// If the choice is 0 the program will end. If 1-4 is input another class will be initiated.
        ///  </summary>
        public void Start()
        {
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText();

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            WholeNumbersForAdd sumObj = new WholeNumbersForAdd();

                            sumObj.Start();
                            break;
                        }
                    case 2:
                        {
                            FloatingPointsNumberWhileAdd floatWhile = new FloatingPointsNumberWhileAdd();

                            floatWhile.Start();
                            break;
                        }
                    case 3:
                        {
                            CurrencyConverter currencyConverter = new CurrencyConverter();

                            currencyConverter.Start();
                            break;
                        }
                    case 4:
                        {
                            WorkingSchedule workingSchedule = new WorkingSchedule();

                            workingSchedule.Start();
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// A method used to print the options to the user and some additional informations and separators.
        /// </summary>
        private void WriteMenuText()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\t\t\t Main Menu");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\t Whole Numbers with For \t\t : 1");
            Console.WriteLine("\t Floating Point Numbers with While \t : 2");
            Console.WriteLine("\t Currency Converter with Do While loop \t : 3");
            Console.WriteLine("\t Work Schedule \t\t\t\t : 4");
            Console.WriteLine("\t Exit the program \t\t\t : 0");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Your choice: ");
        }
    }
}
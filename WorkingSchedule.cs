using System;

namespace Assignment2
{
    ///  <summary>
    /// This class presents 3 options to the user. It will then show a different type of schedule to the user depending on what they pick.
    /// The loop used to display the schedule is a for loop.
    /// This is because since the interval and amount of weeks is given it makes a finite loop like this perfect for this scenario.
    ///  </summary>
    public class WorkingSchedule
    {
        /// <summary>
        /// The method called from the menu class. Basically works as a constructor except it is not called.
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
        }
        /// <summary>
        /// Print out basic information regarding this choice.
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n \t\t YOUR SCHEDULE PROGRAM ");
            Console.WriteLine("Select from the menu which type of schedule you would like to see.");
        }
        /// <summary>
        /// As long as the user input isn't 0 continue looping. Depending on the users choice the parameters for BuildSchedule changes to affect the interval of the loop in that method.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {

            int choice = -1;
            while (choice != 0)
            {
                BuildOptions();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            BuildSchedule(1, 3);
                            break;
                        }
                    case 2:
                        {
                            BuildSchedule(6, 5);
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// Print the users options to them.
        /// </summary>
        private void BuildOptions()
        {
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("1 Show a list of weekends to work");
            Console.WriteLine("2 Show a list of the nights to work");
            Console.WriteLine("0 Return to Main Menu\n\n");
            Console.Write("Your choice: ");
        }
        /// <summary>
        /// A method used to for loop and print out a schedule to the user.
        /// </summary>
        /// <param name="startWeek"> The first week that will be printed out.</param>
        /// <param name="weekModifier"> How many weeks we want to skip in between each iteration </param>
        private void BuildSchedule(int startWeek, int weekModifier)
        {
            Console.WriteLine("\nYour schedule of the above option is as follows:\n\n");
            for (int i = startWeek; i < 53; i += weekModifier)
            {
                Console.Write("\tWeek {0}\t", i);
            }
            Console.WriteLine();
        }
    }
}
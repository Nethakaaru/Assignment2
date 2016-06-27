using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// The main class used to initiate the program. It names the console windows then creates an instance of the Menu class and calls its Start method.
    /// Author: Sebastian Aspegren
    /// </summary>
    class MainProgram
    {
        ///  <summary>
        /// The method that is called to get everything going.
        ///  </summary>
        static void Main(string[] args)
        {
            Console.Title = "Selection and iteration algorithms";
            Menu menu = new Menu();
            menu.Start();
        }
    }
}

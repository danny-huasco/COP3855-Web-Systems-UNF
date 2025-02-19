/* CarpetCalculatorApp.cs
* Author: Doyle
* This class instantiates an object
* of the CarpetCalculator class. It
* demonstrates how to access and use
* the members of the class.
*/
using System;
using static System.Console;
namespace CarpetCalculatorApp
{
    class CarpetCalculatorApp
    {
        static void Main()
        {
            CarpetCalculator berber = new CarpetCalculator(17.95);
            double roomWidth;
            double roomLength;
            DisplayInstructions();
            // Call getDimension( ) to get the length
            roomLength = GetDimension("Length");
            // Call getDimension( ) again to get the width
            roomWidth = GetDimension("Width");
            berber.PricePerSqYard = 25.99;
            berber.SetNoOfSqYards(roomLength, roomWidth);
            Clear();
            Write(berber);
            ReadKey();
        }
        static void DisplayInstructions()
        {
            WriteLine("This program will "
            + "determine how much "
            + "carpet to purchase.");
            WriteLine();
            WriteLine("You will be asked to enter "
            + "the size of the room ");
            WriteLine("and the price of the carpet, "
            + "in price per square yds.");
            WriteLine();
        }
        static double GetDimension(string side)
        {
            string inputValue; // local variables
            int feet, // needed only by this
            inches; // method
            Write("Enter the {0} in feet: ", side);
            inputValue = ReadLine();
            feet = int.Parse(inputValue);
            Write("Enter the {0} in inches: ", side);
            inputValue = ReadLine();
            inches = int.Parse(inputValue);
            // Note: cast required to avoid int division
            return (feet + (double)inches / 12);
        }
        // //With the ToString( ) method, there is no longer a need for
        // // the DisplayResults( ) method
        // // It is left in the solution to illustrate sending an
        // // entire class object to a method
        //static void DisplayResults(CarpetCalculator carpet )
        //{
        // WriteLine( );
        // Write("Square Yards needed: ");
        // WriteLine("{0:N2}", carpet.GetNoOfSquareYards());
        // Write("Total Cost at {0:C} ",
        // carpet.Price);
        // WriteLine(" per Square Yard: {0:C}",
        // carpet.DetermineTotalCost( ));
        //}
    }
}
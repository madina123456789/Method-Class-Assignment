using System;

namespace CalculatorApp
{
    // Class to handle arithmetic operations
    class ArithmeticHandler
    {
        // Method that modifies a number and displays another number
        public void UpdateAndDisplay(int baseValue, int displayValue)
        {
            // Adds 20 to the base value
            int modifiedValue = baseValue + 20;
            // Outputs the displayValue to the console
            Console.WriteLine("Output value: " + displayValue);
            // Displays the modified base value
            Console.WriteLine("Modified base value: " + modifiedValue);
        }
    }

    class Runner
    {
        static void Main(string[] args)
        {
            // Creates an instance of ArithmeticHandler
            ArithmeticHandler handler = new ArithmeticHandler();

            // Executes the method with direct input of parameters
            handler.UpdateAndDisplay(10, 40);

            // Executes the method specifying the parameters by name for clarity
            handler.UpdateAndDisplay(baseValue: 25, displayValue: 50);
        }
    }
}

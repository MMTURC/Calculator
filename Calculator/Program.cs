class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console Calculator App");
        Console.WriteLine("-----------------------");

        // While app is running do this
        while (!endApp)
        {
            string? numberInputOne = " "; // handles that there could be a string or null
            string? numberInputTwo = " ";
            double result = 0;

            Console.WriteLine("Type a  number, and then press enter!");

            numberInputOne = Console.ReadLine();

            double cleanNumberOne = 0;

            // Error Handling If the string cannot be parsed to a double 
            // Will prompt user to type another number in
            while(!double.TryParse(numberInputOne, out cleanNumberOne))
            {
                Console.WriteLine("This is not a valid input, Please enter a numeric value: ");
                numberInputOne = Console.ReadLine();
            }

            Console.WriteLine("Please type in a second number: ");

            double clearNumberTwo = 0;
            while(!double.TryParse(numberInputTwo, out clearNumberTwo)) {

                Console.WriteLine("This is not a valid input, Please enter a numeric value: ");
                numberInputTwo = Console.ReadLine();



        }
    }
}
class Calculator
{
    public static double DoOperation(double numberOne , double numberTwo, string operation)
    {
        double result = double.NaN;

        switch (operation)
        {
            case "add":
                result = numberOne + numberTwo;
                break;
            case "subtract":
                result = numberOne - numberTwo;
                break;
            case "multiply":
                result = numberOne * numberTwo;
                break;
            case "divide":
                // error handling if the user wants to divide by zero
                if (numberTwo != 0)
                {
                    result = numberOne / numberTwo;
                }
                break;

            default:
                break;
        }
        return result;
    }
}



// ToLower handles if the user does not match the case exactly just the word.

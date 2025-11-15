int numberOne = 0;

int numberTwo = 0;

string answer;

Console.WriteLine("This is a calculator\r");
Console.WriteLine("--------------------\n");

Console.WriteLine("Please type a number: ");

numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please type a second number: ");

numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose what operation you would like!");
Console.WriteLine("Would you like to add, subtract, multiply and divide?");


answer = Console.ReadLine();


// ToLower handles if the user does not match the case exactly just the word.
switch (answer.ToLower())
{
    case "add":
        Console.WriteLine($"Your result is {numberOne}  + {numberTwo} = " + (numberOne + numberTwo));
        break;
    case "subtract":
        Console.WriteLine($"Your result is {numberOne} - {numberTwo} = " + (numberOne - numberTwo));
        break;
    case "multiply":
        Console.WriteLine($"Your result is {numberOne} * {numberTwo} = " + (numberOne * numberTwo));
        break;
    case "divide":
        Console.WriteLine($"Your result is {numberOne} / {numberTwo} = " + (numberOne / numberTwo));
        break;
}



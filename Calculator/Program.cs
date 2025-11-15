
Console.WriteLine("This is a calculator\r");
Console.WriteLine("--------------------\n");

while (true)
{


    double numberOne = 0;

    double numberTwo = 0;

    string answer;

    Console.WriteLine("Please type a number: ");

    numberOne = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please type a second number: ");

    numberTwo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Choose what operation you would like!");
    Console.WriteLine("Would you like to add, subtract, multiply and divide?");


    answer = Console.ReadLine();

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
    Console.WriteLine("You can now perform another operation if you would like if not do Ctrl + c on your keyboard (I am too lazy to add something that quits the program)\n");

}



// ToLower handles if the user does not match the case exactly just the word.

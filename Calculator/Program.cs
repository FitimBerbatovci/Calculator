using System;

class Calculator
{
    public static void Main()
    {
        double num1, num2;
        string op;

        Console.Write("Enter first number: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter operator: ");
        op = Console.ReadLine();

        Console.Write("Enter second number: ");
        num2 = double.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case "-":
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case "*":
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case "/":
                Console.WriteLine("Result: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}

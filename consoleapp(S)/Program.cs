

using System.Diagnostics.SymbolStore;

Console.WriteLine("Enter Firs number");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Second number");
double number2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Simbol operation");
char symbol = char.Parse(Console.ReadLine());

if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/' || symbol == '%') 
{ 
}

else if (symbol == '+')
    Console.WriteLine($"{number1 + number2}={number1 + number2}");
else if (symbol == '-')
    Console.WriteLine($"{number1 - number2}={number1 + number2}");
else if (symbol == '*')
    Console.WriteLine($"{number1 * number2}={number1 * number2}");
else if (symbol == '/')
    Console.WriteLine($"{number1 / number2}={number1 / number2}");
else if (symbol == '%')
    Console.WriteLine($"{number1 % number2}={number1 % number2}");

else
{
    Console.WriteLine("text is not a number");
}
Console.ReadLine();

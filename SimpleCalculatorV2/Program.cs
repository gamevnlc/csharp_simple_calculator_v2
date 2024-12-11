// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello");
Console.WriteLine("Input the first number");
string firstInput = Console.ReadLine();
int firstNumber = int.Parse(firstInput);

Console.WriteLine("Input the second number:");
string secondInput = Console.ReadLine();
int secondNumber = int.Parse(secondInput);
int result = 0;
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userChoice = Console.ReadLine();
string userChoiceLower = userChoice.ToLower();
List<string> allowedOptions = new List<string> {"a", "s", "m"};
if (!allowedOptions.Contains(userChoiceLower))
{
    Console.WriteLine("Invalid option!");
    return;
}

string symbol = "";
if (userChoiceLower == "a")
{
    result = firstNumber + secondNumber;
    symbol = "+";
}

if (userChoiceLower == "s")
{
    result  = firstNumber - secondNumber;
    symbol = "-";
}

if (userChoiceLower == "m")
{
    result = firstNumber * secondNumber;
    symbol = "*";
}

Console.WriteLine("The result is: " + firstInput + symbol + secondInput + "=" + result);
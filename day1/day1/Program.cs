Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Addition:" + (num1 + num2));
Console.WriteLine("Subtraction:" + (num1 - num2));
Console.WriteLine("Multiplication:" + (num1 * num2));
if (num1 != 0)
{
    Console.WriteLine("Division: " + ( num1/num2));
}
else
{
    Console.WriteLine("Division: Cannot divide by zero");
}
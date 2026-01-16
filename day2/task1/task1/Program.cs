Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());
bool isPrime = true;
if (number <= 1)
{
    isPrime = false;
}
else
{
    for(int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}
if (isPrime)
{
    Console.WriteLine("the number is prime");
}
else
{
    Console.WriteLine("the number is not prime");
}

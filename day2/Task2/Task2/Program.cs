Console.WriteLine("Enter the number of row ");
int num = int.Parse(Console.ReadLine());
int mid = num / 2;
for(int i = 0; i <= mid; i++)
{
    for(int j = 0; j < mid - i; j++) 
    {
        Console.Write(" ");

    }
    for(int j = 0; j < 2 * i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for(int i = mid-1; i>=0; i--)
{
    for (int j = 0; j < mid - i; j++) 
    {
        Console.Write(" ");

    }
    for (int j = 0; j < 2 * i +1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

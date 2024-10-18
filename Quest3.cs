Console.Write("Enter length of the array:");
int length = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < length; i++)
{
    Console.Write("Enter num:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
        sum += num;
    }
}
Console.WriteLine($"Sum of even numbers:{sum}")
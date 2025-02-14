namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sumOfDigits = 0;
        while(number != 0)
        {
            sumOfDigits += number % 10;
            number /= 10;
        }
        Console.WriteLine($"Sum of digits: {sumOfDigits}");
    }
}
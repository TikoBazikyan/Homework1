namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int reverse = 0;
        while (number != 0)
        {
            reverse = reverse * 10 + number % 10;
            number /= 10;
        }
        Console.WriteLine(reverse);
    }
}
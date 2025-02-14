namespace task6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number != 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number = 3 * number + 1;
            }

            count++;
        }
        Console.WriteLine($"Steps count: {count} | number: {number}");
    }
}
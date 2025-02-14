namespace task4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} * {number} = {number * i}");
        }
    }
}
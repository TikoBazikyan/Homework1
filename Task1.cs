namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter N number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num1 = 0;
        int num2 = 1;
        int num3 = 1;
        Console.Write("The first N numbers of fibonacci: ");
        if (n <= 1)
        {
            Console.Write(num1);
        }
        else
        {
            Console.Write($"{num1}, {num2}, ");
        }
        for (int i = 2; i < n; i++)
        {
            num3 = num1 + num2;
            num1 = num2;
            num2 = num3;
            
            Console.Write("{0}, ", num3);
        }
    }
}
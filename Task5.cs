namespace task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (number == 1)
        {
            isPrime = false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Number is Prime.");
        }
        else
        {
            Console.WriteLine("Number is NOT Prime.");
        }
        
    }
}
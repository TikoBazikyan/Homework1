namespace task7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input pyramid length: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
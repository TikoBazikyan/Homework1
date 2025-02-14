namespace task10;

class Program
{
    static void Main(string[] args)
    {
        char[,] grid = new char[10, 10];
        int index1 = Random.Shared.Next(0, 10);
        int index2 = Random.Shared.Next(0, 10);
        grid[index1, index2] = 'X';
            
        // Stugelu hamar uncomment anel
        //Console.WriteLine($"index1: {index1}, index2: {index2}");
        
        char[,] display = new char[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                display[i, j] = '*';
            }
        }
        bool exit = true;
        while (exit)
        {
          
            Console.Write("Continue(+)  or  Quit(q) : ");
            char op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.Write("Enter first index where can be 'X' : ");
                    int firstIndex = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second index where can be 'X' : ");
                    int secondIndex = Convert.ToInt32(Console.ReadLine());
                    if (grid[firstIndex, secondIndex] == 'X')
                    {
                        Console.WriteLine("You find the 'X'.");
                        display[firstIndex, secondIndex] = 'X';
                        exit = false;
                    }
                    else
                    {
                        display[firstIndex, secondIndex] = 'p';
                        Console.WriteLine("'X' is NOT here , Try again.");
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write($" {display[i, j]}");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 'q':
                    exit = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
    }
}
using System;
namespace task8
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generation.");
            string lowcases = "abcdefgh";
            string uppercases = "ABCDEFGH";
            string symbols = "!@#$%*(^";
            string numbers = "123456789" ;
            string all=lowcases+uppercases+symbols+numbers+lowcases;
            char[] allArray = all.ToCharArray();
            int length = allArray.Length;
            char[] password = new char[8];
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Enter key: generate(+) | exit(-)");
                char op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        Random passGenerator = new Random();
                        for (int i = 0; i < 8; i++)
                        {
                            password[i] = allArray[passGenerator.Next(0, length)];
                        }
                        Console.Write("Password: ");
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(password[i]);
                        }
                        Console.WriteLine();
                        break;
                    case '-':
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
                
            }
            
        }
    }
}
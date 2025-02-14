namespace task9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a sentence: ");
        string sentence = Console.ReadLine();
        char[] deviders = new char[] { ' ', ',', '.', ':', ';', '!', '?' };
        string[] words = sentence.Split(deviders, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = words[0];
        for(int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }
        Console.WriteLine($"Longest word in sentence is : {longestWord}");
    }
}
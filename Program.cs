using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string result = ReplaceWords(input);

        Console.WriteLine("Результат: " + result);
    }

    static string ReplaceWords(string input)
    {
        return input.Replace("one", "1")
                    .Replace("two", "2")
                    .Replace("three", "3")
                    .Replace("four", "4")
                    .Replace("five", "5");
    }
}
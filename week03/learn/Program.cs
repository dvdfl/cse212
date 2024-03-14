using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n======================\nDuplicate Counter\n======================");
        DuplicateCounter.Run();

        Console.WriteLine("\n======================\nTranslator\n======================");
        Translator.Run();

        Console.WriteLine("\n======================\nFind Duplicated\n======================");
        DuplicateFinder.Run();
    }
}
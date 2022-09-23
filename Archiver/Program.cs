﻿namespace Archiver;

public static class Program
{
    private static readonly string directory = Path.GetFullPath(Directory.GetCurrentDirectory() + @"../../../../");

    public static void Main()
    {
        try
        {
            //RunArchiver();
            RunAnalyzer();
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }

    private static void RunArchiver()
    {
        Console.WriteLine("1 - Encode\n2 - Decode\n");
        Console.Write("Your choice: ");
        var choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Zipper.Encode(directory);
                break;
            case 2:
                Zipper.Decode(directory);
                break;
            default:
                throw new ArgumentException("Invalid argument!");
        }
    }

    private static void RunAnalyzer()
    {
        PrintHeading("Task 1 and 2");
        var fm = new FileManager(Path.Combine(directory, "file.txt"));
        fm.PrintAllStat();
            
        PrintHeading("Task 3");
        FileManager.Task3(Path.Combine(directory, "1.txt"));
    }

    private static void PrintHeading(string heading)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(heading);
        Console.ResetColor();
    }
}
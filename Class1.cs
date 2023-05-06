using System;
using static System.Console;

namespace LightCream
{
public class Class1
{
}

public class Log
{
    public static void LogInfo(object value)
    {
        ForegroundColor = ConsoleColor.White;
        Write("[");
        ForegroundColor = ConsoleColor.Green;
        Write("INFO");
        ForegroundColor = ConsoleColor.White;
        WriteLine($"]: {value}");
    }
    public static void LogError(object value)
    {
        ForegroundColor = ConsoleColor.White;
        Write("[");
        ForegroundColor = ConsoleColor.Red;
        Write("ERROR");
        ForegroundColor = ConsoleColor.White;
        WriteLine($"]: {value}");
    }
    public static void LogCommand(object value)
    {
        ForegroundColor = ConsoleColor.White;
        Write("[");
        ForegroundColor = ConsoleColor.Cyan;
        Write("/");
        ForegroundColor = ConsoleColor.White;
        WriteLine($"]: {value}");
    }
}
}
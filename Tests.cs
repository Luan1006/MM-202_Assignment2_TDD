using System.Xml.Serialization;

public class Tests
{
    public void Run(string[] args)
    {
        TestOneInchInMillimetreVariable();
        TestIfUserInputFromConsoleExists(args);
        TestIfUserInputFromConsoleStartsWithNumber(args);
    }

    void TestOneInchInMillimetreVariable()
    {
        if (Variables.oneInchInMillimetre != 25.4f)
        {
            PrintTestResult("TestOneInchInMillimetreVariable", false);
        }
        else
        {
            PrintTestResult("TestOneInchInMillimetreVariable", true);
        }
    }

    void TestIfUserInputFromConsoleExists(string[] args)
    {
        if (args.Length == 0)
        {
            PrintTestResult("TestUserInputFromConsole", false);
        }
        else
        {
            PrintTestResult("TestUserInputFromConsole", true);
        }
    }

    void TestIfUserInputFromConsoleStartsWithNumber(string[] args)
    {
        if (char.IsDigit(args[0][0]))
        {
            PrintTestResult("TestUserInputFromConsoleStartsWithNumber", true);
        }
        else
        {
            PrintTestResult("TestUserInputFromConsoleStartsWithNumber", false);
        }
    }

    void PrintTestResult(string message, bool isPass)
    {
        string result;
        if (isPass)
        {
            result = "PASS";
        }
        else
        {
            result = "FAIL";
        }

        string testName = message.Replace(" " + result, "");

        ConsoleColor backgroundColor;
        if (isPass)
        {
            backgroundColor = ConsoleColor.Green;
        }
        else
        {
            backgroundColor = ConsoleColor.Red;
        }

        Console.BackgroundColor = backgroundColor;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(result);
        Console.ResetColor();
        Console.WriteLine(" " + testName);
    }
}
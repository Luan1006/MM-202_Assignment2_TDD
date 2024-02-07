public class Tests
{
    public void Run()
    {
        TestOneInchInMillimetreVariable();
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
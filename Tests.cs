public class Tests
{
    private bool allTestsPass = true;
    public bool Run(string[] args)
    {
        TestUserInputFromConsoleExists(args);
        TestUserInputFromConsoleStartsWithNumber(args);
        TestUserInputFromConsoleHasUnit(args);
        TestOneInchInMillimetreVariable();
        TestConversionFromUserInputToMillimetres(args);
        TestConversionFromUserInputToMeter(args);
        return allTestsPass;
    }

    #region Unit Tests
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

    void TestConversionFromUserInputToMillimetres(string[] args)
    {
        int inchToConvert = args[0][0];
        float expectedMillimetres = inchToConvert * Variables.oneInchInMillimetre;

        if (expectedMillimetres != Conversion.ConvertToMillimetres(args))
        {
            PrintTestResult("TestConversionFromUserInputToMillimetres", false);
        }
        else
        {
            PrintTestResult("TestConversionFromUserInputToMillimetres", true);
        }
    }

    void TestConversionFromUserInputToCentimetres(string[] args)
    {
        int inchToConvert = args[0][0];
        float expectedCentimetres = inchToConvert * Variables.oneInchInMillimetre / 10;

        if (expectedCentimetres != Conversion.ConvertToCentimetres(args))
        {
            PrintTestResult("TestConversionFromUserInputToCentimetres", false);
        }
        else
        {
            PrintTestResult("TestConversionFromUserInputToCentimetres", true);
        }
    }

    void TestConversionFromUserInputToMeter(string[] args)
    {
        int inchToConvert = args[0][0];
        float expectedMeters = inchToConvert * Variables.oneInchInMillimetre / 1000;

        if (expectedMeters != Conversion.ConvertToMeters(args))
        {
            PrintTestResult("TestConverstionFromUserInputToMeter", false);
        }
        else
        {
            PrintTestResult("TestConverstionFromUserInputToMeter", true);
        }
    }

    #endregion

    #region User Input Tests
    void TestUserInputFromConsoleExists(string[] args)
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

    void TestUserInputFromConsoleStartsWithNumber(string[] args)
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

    void TestUserInputFromConsoleHasUnit(string[] args)
    {
        bool hasUnit = false;

        foreach (var arg in args)
        {
            if (arg.StartsWith("-") && (arg.Contains("mm") || arg.Contains("cm") || arg.Contains("m")))
            {
                hasUnit = true;
                break;
            }
        }

        PrintTestResult("TestUserInputFromConsoleHasUnit", hasUnit);
    }
    #endregion

    #region Test Helpers
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
            allTestsPass = false;
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
    #endregion
}
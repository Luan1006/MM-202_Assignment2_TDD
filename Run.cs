class Run
{
    static void Main(string[] args)
    {
        Tests tests = new Tests();

        if (!tests.Run(args))
        {
            Console.WriteLine(Variables.TEST_FAILED);
            return;
        }

        Console.WriteLine(Variables.ALL_TESTS_PASSED);

        string unit = "";

        foreach (var arg in args)
        {
            if (arg.StartsWith(Variables.PREFIX) && (arg.Contains(Variables.MILLIMETRES) || arg.Contains(Variables.CENTIMETRES) || arg.Contains(Variables.METERS)))
            {
                unit = arg;
                break;
            }
        }

        if (Equals(unit, $"{Variables.PREFIX}{Variables.MILLIMETRES}"))
        {
            Console.WriteLine($"{Conversion.ConvertToMillimetres(args)} {Variables.MILLIMETRES}");
        }
        else if (Equals(unit, $"{Variables.PREFIX}{Variables.CENTIMETRES}"))
        {
            Console.WriteLine($"{Conversion.ConvertToCentimetres(args)} {Variables.CENTIMETRES}");
        }
        else if (Equals(unit, $"{Variables.PREFIX}{Variables.METERS}"))
        {
            Console.WriteLine($"{Conversion.ConvertToMeters(args)} {Variables.METERS}");
        }
    }
}
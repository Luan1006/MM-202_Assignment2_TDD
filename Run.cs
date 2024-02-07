class Run
{
    static void Main(string[] args)
    {
        Tests tests = new Tests();

        if (tests.Run(args))
        {
            Console.WriteLine("All tests passed");
        }
        else
        {
            Console.WriteLine("Some tests failed");
        }
    }
}
public class Tests
{
    void TestOneInchInMillimetreVariable()
    {
        if (Variables.oneInchInMillimetre != 25.4f)
        {
            throw new Exception("The value of oneInchInMillimetre is not 25.4f");
        }
    }
}
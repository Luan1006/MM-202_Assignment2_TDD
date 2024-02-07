public class Conversion
{
    public static float ConvertToMillimetres(string[] args)
    {
        int inchToConvert = args[0][0];
        return inchToConvert * Variables.oneInchInMillimetre;
    }
}
public class Conversion
{
    public static float ConvertToMillimetres(float inchToConvert)
    {
        return inchToConvert * Variables.oneInchInMillimetre;
    }

    public static float ConvertToCentimetres(float inchToConvert)
    {
        return inchToConvert * Variables.oneInchInMillimetre / 10;
    }

    public static float ConvertToMeters(float inchToConvert)
    {
        return inchToConvert * Variables.oneInchInMillimetre / 1000;
    }
}
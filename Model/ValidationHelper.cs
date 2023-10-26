namespace MyWebApplication;

public static class ValidationHelper
{
    public static void ThrowsIfNotPositive(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(value), "value is negative or 0");
    }
}

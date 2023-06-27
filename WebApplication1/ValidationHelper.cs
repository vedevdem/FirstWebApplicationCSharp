namespace WebApplication1;

public static class ValidationHelper
{
    public static void ThrowsIfNotPositive(double val)
    {
        if (val <= 0)
            throw new ArgumentOutOfRangeException(nameof(val), "value is negative or 0")
    }
}

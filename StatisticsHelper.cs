namespace APBD_CW1_GIT_S27747;

public class StatisticsHelper
{
    public static int CalculateSum(int[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        if (values.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty.");
        }

        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return sum;
    }
}
namespace APBD_CW1_GIT_S27747;

public class StatisticsHelper
{
    public static int CalculateSum(int[] values)
    {
        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return sum;
    }
}
using APBD_CW1_GIT_S27747;

int[] values = { };

try
{
    int sum = StatisticsHelper.CalculateSum(values);
    Console.WriteLine($"Sum: {sum}");
}
catch (Exception exception)
{
    Console.WriteLine($"Error: {exception.Message}");
}

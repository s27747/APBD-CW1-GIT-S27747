using APBD_CW1_GIT_S27747;

int[] values = { 2, 4, 6, 8 };

try
{
    int sum = StatisticsHelper.CalculateSum(values);
    double average = StatisticsHelper.CalculateAverage(values);
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average}");
}
catch (Exception exception)
{
    Console.WriteLine($"Error: {exception.Message}");
}

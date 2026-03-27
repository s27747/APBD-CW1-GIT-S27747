using APBD_CW1_GIT_S27747;

int[] values = { 2, 4, 6, 8 };

try
{
    int sum = StatisticsHelper.CalculateSum(values);
    double average = StatisticsHelper.CalculateAverage(values);
    int max = StatisticsHelper.CalculateMax(values);
    
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Max: {max}");

}
catch (Exception exception)
{
    Console.WriteLine($"Error: {exception.Message}");
}

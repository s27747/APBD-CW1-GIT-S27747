using APBD_CW1_GIT_S27747;

int[] values = { 9, 4, 6, 1, 8 };

try
{
    int sum = StatisticsHelper.CalculateSum(values);
    double average = StatisticsHelper.CalculateAverage(values);
    int max = StatisticsHelper.CalculateMax(values);
    int min = StatisticsHelper.CalculateMin(values);

    
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Max: {max}");
    Console.WriteLine($"Min: {min}");


}
catch (Exception exception)
{
    Console.WriteLine($"Error: {exception.Message}");
}

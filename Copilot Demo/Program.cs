// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int CalculateDaysBetweenDates(DateTime startDate,DateTime endDate)
{
    var totalDays = 0;
    for (var currentDate = startDate;
        currentDate <= endDate;
        currentDate = currentDate.AddDays(1))
    {
        totalDays++;
    }
    return totalDays;
}

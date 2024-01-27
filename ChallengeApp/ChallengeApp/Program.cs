using ChallengeApp;

Console.WriteLine("Witaj w aplickacji do oceny pracowników.");
Console.WriteLine("By zakończyć działanie aplikacji wprowadź \"q\"");
Console.WriteLine("==========================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę do wprowadzenia:");
    var input = Console.ReadLine();
    if (input.Equals("q"))
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
printStatistics(statistics);

static void printStatistics(Statistics stats)
{
    Console.WriteLine("==========================");
    Console.WriteLine($"Najniższa ocena to: {stats.Min:N2}");
    Console.WriteLine($"Najwyższa ocena to: {stats.Max:N2}");
    Console.WriteLine($"Średnia ocen to: {stats.Average:N2}");
    Console.WriteLine($"Ocena pracownika to: {stats.AverageLetter:N2}");
}




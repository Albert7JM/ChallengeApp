using ChallengeApp;

var employee = new Employee("Adam", "Chmielowski");
employee.AddGrade(7);
employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(10);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");




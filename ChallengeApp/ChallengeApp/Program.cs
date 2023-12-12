using ChallengeApp;

Employee employee1 = new Employee("Adam", "Chmielowski", 71);
Employee employee2 = new Employee("Andrzej", "Bobola", 65);
Employee employee3 = new Employee("Jadwiga", "Andegaweńska", 25);

employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(8);
employee1.AddScore(2);

employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(7);
employee2.AddScore(7);
employee2.AddScore(6);

employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(3);
employee3.AddScore(7);
employee3.AddScore(2);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2 ,employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Najlepszy wynik zdobył:" + "  " + employeeWithMaxResult.Name + "  " + employeeWithMaxResult.Surname + "  " + "lat" + "  " + employeeWithMaxResult.Age);
Console.WriteLine("z sumą punktów" + "  " + employeeWithMaxResult.Result);



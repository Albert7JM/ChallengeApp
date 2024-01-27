namespace ChallengeApp.Test
{
    internal class EmployeeTests
    {
        [Test]
        public void CorrectPoints()
        {
            var employee = new Employee("Adam", "Chmielowski");
            employee.AddGrade(77);
            employee.AddGrade('b');
            employee.AddGrade(33);
            employee.AddGrade(59);
            employee.AddGrade('c');
            employee.AddGrade(49);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 33,00);
            Assert.AreEqual(statistics.Max, 80,00);
            Assert.AreEqual(statistics.Average, 59,67);
            Assert.AreEqual(statistics.AverageLetter, 'C');

        }

    }
}
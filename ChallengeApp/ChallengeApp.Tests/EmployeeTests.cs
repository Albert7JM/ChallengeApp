using ChallengeApp;

namespace ChallengeApp.Test
{
    internal class EmployeeTests

    {
        [Test]

        public void CorrectPoints()

        {
            var employee = new Employee("Adam", "Chmielowski");

            employee.AddGrade("B");

            employee.AddGrade('E');

            employee.AddGrade("90");

            employee.AddGrade(80);

            employee.AddGrade("C");



            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 20);

            Assert.AreEqual(statistics.Max, 90);

            Assert.AreEqual(statistics.Average, 61,25);

            Assert.AreEqual(statistics.AverageLetter,'B');
        }
    }
}


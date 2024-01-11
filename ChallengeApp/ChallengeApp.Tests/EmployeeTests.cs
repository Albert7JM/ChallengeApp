namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnMaxValue()
        {
            //arange
            var employee = new Employee("Adam", "Chmielowski");
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(10);
            //act
            var statistics = employee.GetStatistics();
           //assert
            Assert.AreEqual(10,statistics.Max);
        }
        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnMinValue()
        {
            //arange
            var employee = new Employee("Adam", "Chmielowski");
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(10);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(3, statistics.Min);
        }
        [Test]
        public void WhenEmployeeCollectAllPoints_ShouldReturnAverageValue()
        {
            //arange
            var employee = new Employee("Adam", "Chmielowski");
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(10);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(6.25, statistics.Average);
        }
    }
}
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckSumOperationWithOnlyPositivePoints()
        {
            var employee = new Employee("Adam", "Chmielowski", 71);
            employee.AddScore(7);
            employee.AddScore(10);
            employee.AddScore(4);
     
            var result = employee.Result;
           
            Assert.AreEqual(21, result);
        }
        [Test]
        public void CheckSumOperationWithOnlyNegativePoints()
        {
            var employee = new Employee("Andrzej", "Bobola", 65);
            employee.AddScore(-3);
            employee.AddScore(-1);
            employee.AddScore(-5);

            var result = employee.Result;

            Assert.AreEqual(-9, result);
        }
        [Test]
        public void CheckSumOperationWithPositiveAndNegativePoints()
        {
            var employee = new Employee("Jadwiga", "Andegaweñska", 25);
            employee.AddScore(-5);
            employee.AddScore(-3);
            employee.AddScore(8);

            var result = employee.Result;

            Assert.AreEqual(0, result);
        }
    }
}
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestWithFloat()
        {
            float mynumber1 = 27935400481;
            float mynumber2 = 40000085238002831;

            Assert.AreNotEqual(mynumber1, mynumber2);
        }
        [Test]
        public void AreNumbersNotEguall()
        {
            int number1 = 7;
            int number2 = 77;

            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void CheckTypeForStringVariable()
        {
            string number1 = "77";
            string number2 = "77";

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void SurnameOfTwoEmployeesEqual()
        {
            var employee2 = GetEmployee("Jadwiga", "Andegaweńska", 65);
            var employee3 = GetEmployee("Jadwiga", "Andegaweńska", 25);

            Assert.AreEqual(employee2.Surname, employee3.Surname);
        }
        [Test]
        public void AreAgeOfEmployeesIsTheSame()
        {
            var employee2 = GetEmployee("Jadwiga", "Andegaweńska", 25);
            var employee3 = GetEmployee("Jadwiga", "Andegaweńska", 25);

            Assert.AreEqual(employee2.Age, employee3.Age);
        }
        [Test]
        public void AreTwoEmployeesNotEqual()
        {
            var employee1 = GetEmployee("Jadwiga", "Andegaweńska", 25);
            var employee2 = GetEmployee("Jadwiga", "Andegaweńska", 25);

            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}

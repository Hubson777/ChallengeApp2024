namespace ChallengeApp2024.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnStatistics()
        {
            //arrenge
            var employee = new Employee("Janusz", "kowalski", 35);
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average,2));
        }

    }
}

using PracaDomowa6;
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        //Typy wartościowe
        [Test]
        public void AreTheNumbersEqual()
        {
            int number1 = 16;
            int number2 = 16;
            
            Assert.AreEqual(number1, number2);
        }
        public void IsFirstNumberGreater()
        {
            float number3 = 8.9f;
            float number4 = -6.8f;
            
            Assert.Greater(number3, number4);
        }
        
        //Typy referencyjne
        [Test]
        public void AreEmployeeNamesDifferent()
        {
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Tomasz");
            
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
        public void AreTheCityNamesTheSame()
        {
            string city1 = "Lublin";
            string city2 = "Lublin";
            
            Assert.AreEqual(city1, city2);
        }
    }
}
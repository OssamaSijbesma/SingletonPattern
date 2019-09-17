using NUnit.Framework;
using LifeOfSybren;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void LogInstanceExists()
        {
            // Arrange

            // Act
            Log log = Log.Instance;

            // Assert
            Assert.AreNotEqual(null, log);
        }

        [Test]
        public void LogIsSingleton()
        {
            // Arrange

            // Act
            Log log1 = Log.Instance;
            log1.Write("test");
            Log log2 = Log.Instance;

            // Assert
            Assert.AreEqual(log1, log2);
        }
        
        [Test]
        public void ScenarioIsNotSingleton()
        {
            // Arrange

            // Act
            Scenario s1;
            s1 = new Scenario(1, "???", "Test");

            Scenario s2;
            s2 = new Scenario(1, "???", "Test");

            // Assert
            Assert.AreNotEqual(s1, s2);
        }
    }
}
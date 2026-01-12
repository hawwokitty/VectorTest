using System.Numerics;
using VectorTest;

namespace VectorUnitTest
{
    public class Tests
    {
        [Test]
        public void CreateVector_HasExpectedLength()
        {
            // Arrange
            const double expectedLength = 0.7;
            const double tolerance = 0.05;

            // Act
            Vector2 v = VectorMaking.CreateVector(expectedLength, 356.2);

            // Assert
            Assert.That(v.Length(), Is.EqualTo(expectedLength).Within(tolerance));
        }
    }
}
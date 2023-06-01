using NUnit.Framework;
using vericlaim;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Reverse_Word()
        {
            string line = "Hello World";

            // Act
            string reversedLine = line.ReverseWords();

            // Assert
            Assert.AreEqual("World Hello", reversedLine);
        }
    }
}
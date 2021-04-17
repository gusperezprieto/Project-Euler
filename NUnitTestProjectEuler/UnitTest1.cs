using NUnit.Framework;
using Project_Euler.Problems; 

namespace NUnitTestProjectEuler
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_E0001()
        {
            Assert.AreEqual("233168", new E0001().Solution());
        }
    }
}
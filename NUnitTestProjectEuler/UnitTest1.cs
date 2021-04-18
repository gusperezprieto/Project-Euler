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

        [Test] public void Test_E0001() { Assert.AreEqual("233168", new E0001().Solution()); }
        [Test] public void Test_E0002() { Assert.AreEqual("4613732", new E0002().Solution()); }
        [Test] public void Test_E0003() { Assert.AreEqual("6857", new E0003().Solution()); }
    }
}
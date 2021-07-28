using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Math
{
    public class CalculateTest
    {
        [Test]
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(2, 2, ExpectedResult = 6)]
        [TestCase(3, 4, ExpectedResult = 7)]
        [TestCase(50, 74, ExpectedResult = 124)]
        public int TestAdd(int a, int b)
        {
            Calculate calculate = new Calculate();
            int result = calculate.Add(a, b);
            return result;
        }
    }
}

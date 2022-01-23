using System.Collections;
using System.Collections.Generic;
using GameCITest;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace GameCITest.Tests.EditMode
{
    public class CalculatorTest
    {
        private Calculator _calculator = new Calculator();

        [Test]
        public void SumTest()
        {
            Assert.That(_calculator.Sum(1, 2), Is.EqualTo(3));
        }
    }
}

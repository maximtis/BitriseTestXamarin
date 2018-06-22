using System;
using BitriseTestXamarin.Classes;
using BitriseTestXamarin.ViewModels;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class MainUnitTests
    {
        [Test]
        public void TestLogicCalcHash()
        {
            //Arrange
            GenericLogicClass logic = new GenericLogicClass();
            int controlNamberA = 10;
            int controlNumberB = 20;

            int controlResult = 4000;

            //Act
            var calculatedHash = logic.CalculateHash(controlNamberA, controlNumberB);

            //Assert
            Assert.AreEqual(controlResult, calculatedHash);
        }

        [Test]
        public void TestLogicCalcHashTwo()
        {
            //Arrange
            GenericLogicClass logic = new GenericLogicClass();
            int controlNamberA = 100;
            int controlNumberB = 20;

            int controlResult = 40000;

            //Act
            var calculatedHash = logic.CalculateHash(controlNamberA, controlNumberB);

            //Assert
            Assert.AreEqual(controlResult, calculatedHash);
        }
    }
}

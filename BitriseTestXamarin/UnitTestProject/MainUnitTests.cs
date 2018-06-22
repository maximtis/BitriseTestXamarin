using System;
using BitriseTestXamarin.Classes;
using BitriseTestXamarin.ViewModels;
using Xunit;

namespace UnitTestProject1
{
    
    public class MainUnitTests
    {
        [Fact]
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
            Assert.Equal(controlResult, calculatedHash);
        }

        [Fact]
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
            Assert.Equal(controlResult, calculatedHash);
        }
    }
}

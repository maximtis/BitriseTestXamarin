using System;
using BitriseTestXamarin.Classes;
using BitriseTestXamarin.ViewModels;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class MainViewModelTests
    {
        [Test]
        public void TestViewModel_SetApplicationName()
        {
            //Arrange
            string controlAppName = $"ApplicationName is testAndroidApp";
            string appName = "testAndroidApp";
            MainViewModel viewModel = new MainViewModel();
           
            //Act
            viewModel.SetApplicationName(appName);
            var resultName = viewModel.GetApplicationName();

            //Assert
            Assert.AreEqual(controlAppName, resultName);
        }

        [Test]
        public void TestViewModel_SetReleaseNumber()
        {
            //Arrange
            string controlReleaseNumber = "ReleaseNumber is 15";
            int releaseNumber = 15;
            MainViewModel viewModel = new MainViewModel();

            //Act
            viewModel.SetReleaseNumber(releaseNumber);
            var resultReleaseNumber = viewModel.GetReleaseNumber();

            //Assert
            Assert.AreEqual(controlReleaseNumber, resultReleaseNumber);
        }
    }
}

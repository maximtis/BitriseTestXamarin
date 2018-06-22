using System;
using BitriseTestXamarin.Classes;
using BitriseTestXamarin.ViewModels;
using Xunit;

namespace UnitTestProject1
{
    public class MainViewModelTests
    {
        [Fact]
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
            Assert.Equal(controlAppName, resultName);
        }

        [Fact]
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
            Assert.Equal(controlReleaseNumber, resultReleaseNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BitriseTestXamarin.ViewModels
{
    public class MainViewModel
    {
        private string appName;
        private int releaseNumber;
        public void SetApplicationName(string name)
        {
            appName = name;
        }

        public void SetReleaseNumber(int number)
        {
            releaseNumber = number;
        }

        public string GetApplicationName()
        {
            return $"ApplicationName is {appName}";
        }

        public string GetReleaseNumber()
        {
            return $"ReleaseNumber is {releaseNumber}";
        }
    }
}

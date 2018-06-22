using System;
using System.Collections.Generic;
using System.Text;

namespace BitriseTestXamarin.Classes
{
    public class GenericLogicClass
    {
        private int baseNumber = 20;
        public int CalculateHash(int number1,int number2)
        {
            return number1 * number2 * baseNumber;
        }
    }
}

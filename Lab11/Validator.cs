using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Validator
    {
        public static bool ValidateUserInput(string userInput, out int category)
        {
            return int.TryParse(userInput, out category);
        }
    }
}

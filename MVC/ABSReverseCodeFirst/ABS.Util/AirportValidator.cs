using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Interfaces;

namespace ABS.Util
{
    public class AirportValidator : IAirportValidator
    {
        public string Message { get; private set; }
        public bool Success { get; private set; }

        public bool ValidateAirportName(string name)
        {
            this.Success = false;

            bool areLetters = name.All(x => char.IsLetter(x));

            if (areLetters == false)
            {
                this.Message = "Airport name should consist of characters only";
                return this.Success;
            }
            else if (string.IsNullOrEmpty(name))
            {
                this.Message = "Airport name can not be null or empty";
                return this.Success;
            }
            else if (name.Length < 3 || name.Length > 3)
            {
                this.Message = "The name of the airport should be Exactly 3 characters";
                return this.Success;
            }
            else
            {
                this.Success = true;
                return this.Success;
            }
        }
      
    }
}

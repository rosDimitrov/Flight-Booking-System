using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Interfaces;

namespace ABS.Util
{
    public class AirlineValidator : IAirlineValidator
    {
        public string Message { get; private set; }
        public bool Success { get; private set; }

        public bool ValidateAirlineName(string name)
        {
            this.Success = false;

            if (string.IsNullOrEmpty(name))
            {
                this.Message = "Airline name can not be null";
                return this.Success;
            }
            else if (name.Length >= 6)
            {
                this.Message = "The Name of the airline should be less than 6 symbols.";
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

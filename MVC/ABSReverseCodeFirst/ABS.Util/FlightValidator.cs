using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ABS.Interfaces;

namespace ABS.Util
{
    public class FlightValidator : IFlightValidator
    {
        public string Message { get; private set; }
        public bool Success { get; private set; }

        public bool ValidateFlightRoute(string origin, string destination)
        {
            this.Success = false;
            if (!origin.Equals(destination, StringComparison.InvariantCultureIgnoreCase))
            {
                this.Success = true;
                return this.Success;
            }
            else
            {
                this.Message = "Origin and Destination can not be the same";
                return this.Success;
            }
        }

        public bool ValidateFlightSectionRowsCols(int rows, int cols)
        {
            this.Success = false;

            if (rows < 1 || rows > 100)
            {
                this.Message = "Flight section rows should be between 1 & 100";
                return this.Success;

            }
            else if (cols < 1 || cols > 10)
            {
                this.Message = "Flight Section cols should be between 1(A) & 10(J)";
                return this.Success;
            }
            else
            {
                this.Success = true;
                return this.Success;
            }
        }

        public bool ValidateFlightDate(int year, int month, int day)
        {

            this.Success = false;
            string date = string.Format($"{month}/{day}/{year}");
            string format = "m/d/yyyy";
            DateTime dateTime;
            this.Success = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);

            if (!this.Success)
            {
                this.Success = false;
                this.Message = "You have entered a wrong date";
                return this.Success;
            }
            this.Success = true;
            return this.Success;
        }
    }
}

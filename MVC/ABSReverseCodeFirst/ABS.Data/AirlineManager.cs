using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Util;
using ABS.Interfaces;

namespace ABS.Data
{
    public class AirlineManager : IAirlineManager
    {
        private IAirlineRepository airlineRepository;
        private IAirlineValidator airlineValidator;
        public string Message { get; private set; }

        public AirlineManager(IAirlineRepository airlineRepository,IAirlineValidator airlineValidator)
        {
            this.airlineRepository = airlineRepository;
            this.airlineValidator = airlineValidator;
        } 

        public void AddAirline(string airlineName)
        {
            if (airlineValidator.ValidateAirlineName(airlineName))
            {
                if (!airlineRepository.AirlineExists(airlineName))
                {
                    this.airlineRepository.AddAirline(airlineName);
                    this.Message = $"Airline {airlineName} successfully added";
                }
                else
                {
                    this.Message = $"Oops, airline {airlineName} already exists!";
                }
            }
            else
            {
                this.Message = this.airlineValidator.Message;
            }
        }





    }
}

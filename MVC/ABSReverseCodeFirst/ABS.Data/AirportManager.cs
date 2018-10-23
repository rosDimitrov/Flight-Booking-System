using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Util;
using ABS.Interfaces;

namespace ABS.Data
{
    public class AirportManager : IAirportManager
    {
        private IAirportRepository airportRepository;
        private IAirportValidator airportValidator;

        public string Message { get; private set; }
        public AirportManager(IAirportRepository airportRepository,IAirportValidator airportValidator)
        {
            this.airportRepository = airportRepository;
            this.airportValidator = airportValidator;
        }


        public void AddAirport(string airportName)
        {
            if (this.airportValidator.ValidateAirportName(airportName))
            {
                if (!this.airportRepository.AirportExists(airportName))
                {
                    this.airportRepository.AddAirport(airportName);
                    this.Message = $"Airport {airportName} successfully added";
                }
                else
                {
                    this.Message = $"Oops, airport {airportName} already exists";
                }
            }
            else
            {
                this.Message = this.airportValidator.Message;
            }
        }
    }
}

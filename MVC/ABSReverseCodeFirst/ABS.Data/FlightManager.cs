using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Util;
using ABS.Model;
using ABS.Interfaces;

namespace ABS.Data
{
    public class FlightManager : IFlightManager
    {
        private IFlightRepository flightRepository;
        private IFlightValidator flightValidator;
        public string Message { get; set; }

        public FlightManager(IFlightRepository flightRepository,IFlightValidator flightValidator)
        {
            this.flightRepository = flightRepository;
            this.flightValidator = flightValidator;
        }

        public void AddFlight(string airlineName, string origin, string destination, int year, int month, int day, string flightId)
        {
            if (flightValidator.ValidateFlightRoute(origin, destination))
            {
                if (flightValidator.ValidateFlightDate(year, month, day))
                {
                    if (this.flightRepository.AirlineExists(airlineName))
                    {
                        if (this.flightRepository.AirportExists(origin))
                        {
                            if (this.flightRepository.AirportExists(destination))
                            {
                                if (!this.flightRepository.FlightExists(airlineName,flightId))
                                {
                                    this.flightRepository.AddFlight(airlineName, origin, destination, year, month, day, flightId);
                                }
                                else
                                {
                                    this.Message = $"Flight with id {flightId} already exists and cannot be added again!";
                                }
                            }
                            else
                            {
                                this.Message = $"Destination airport {destination} does not exist!";
                            }
                        }
                        else
                        {
                            this.Message = $"Origin airport {origin} does not exist!";
                        }
                    }
                    else
                    {
                        this.Message = $"Airline {airlineName} does not exist!";
                    }

                }
                else
                {
                    this.Message = this.flightValidator.Message;
                }
            }
            else
            {
                this.Message = this.flightValidator.Message;
            }
        }

        public IEnumerable<SpFindAvailableFlightsBetweenReturnModel> FindAvailableFlights(string origin, string destination)
        {
            return this.flightRepository.FindAvailableFlights(origin, destination);
        }
        public IEnumerable<VFlightsInformation> DisplaySystemDetails()
        {
            return this.flightRepository.DisplaySystemDetails();
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Model;

namespace ABS.Interfaces
{
    public interface IFlightRepository
    {

        void AddFlight(string airlineName, string origin, string destination, int year, int month, int day, string flightId);

        IEnumerable<SpFindAvailableFlightsBetweenReturnModel> FindAvailableFlights(string origin, string destination);

        IEnumerable<VFlightsInformation> DisplaySystemDetails();
        bool AirlineExists(string airlineName);
        bool AirportExists(string airport);
        bool FlightExists(string airlineName, string flightId);

    }
}

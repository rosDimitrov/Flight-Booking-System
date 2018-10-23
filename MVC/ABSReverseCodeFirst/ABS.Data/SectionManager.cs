using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Util;
using ABS.Interfaces;

namespace ABS.Data
{
    public class SectionManager : ISectionManager
    {
        private ISectionRepository sectionRepository;
        private IFlightValidator flightValidator;
        public string Message { get; set; }

        public SectionManager(ISectionRepository sectionRepository,IFlightValidator flightValidator)
        {
            this.sectionRepository = sectionRepository;
            this.flightValidator = flightValidator;
        }

        public void AddSection(string airlineName, string flightId, int rows, int cols, string sectionType)
        {
            if (flightValidator.ValidateFlightSectionRowsCols(rows, cols))
            {
                if (this.sectionRepository.AirlineExists(airlineName))
                {
                    if (this.sectionRepository.FlightExists(airlineName, flightId))
                    {
                        if (!this.sectionRepository.FlightSectionTypeExists(airlineName, flightId, sectionType))
                        {
                            this.sectionRepository.AddSection(airlineName, flightId, rows, cols, sectionType);
                        }
                        else
                        {
                            this.Message = "Flight Section Already Exists";
                        }
                    }
                    else
                    {
                        this.Message = "Flight does not exist!";
                    }
                }
                else
                {
                    this.Message = "Airline does not exist";
                }
            }
            else
            {
                this.Message = "You have entered wrong rows/cols.";
            }
        }


    }
}

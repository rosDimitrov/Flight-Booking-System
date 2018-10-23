using ABS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Data
{
    public class UnitOfWork
    {
        private BookingSystemDbContext context = new BookingSystemDbContext();
        private AirlineRepository airlineRepository;
        private AirportRepository airportRepository;
        private FlightRepository flightRepository;
        private SeatRepository seatRepository;
        private SectionRepository sectionRepository;

        public string Message { get; set; }

        public AirlineRepository AirlineRepository
        {
            get
            {
                if (this.airlineRepository == null)
                {
                    this.airlineRepository = new AirlineRepository(context);
                }
                return this.airlineRepository;
            }
            set { this.AirlineRepository = value; }
        }
        public AirportRepository AirportRepository
        {
            get
            {
                if (this.airportRepository == null)
                {
                    this.airportRepository = new AirportRepository(context);
                }
                return this.airportRepository;
            }
            set { this.AirportRepository = value; }
        }
        public FlightRepository FlightRepository
        {
            get
            {
                if (this.flightRepository == null)
                {
                    this.flightRepository = new FlightRepository(context);
                }
                return this.flightRepository;
            }
            set { this.FlightRepository = value; }
        }
        public SeatRepository SeatRepository
        {
            get
            {
                if (this.flightRepository == null)
                {
                    this.seatRepository = new SeatRepository(context);
                }
                return this.seatRepository;
            }
            set { this.seatRepository = value; }
        }
        public SectionRepository SectionRepository
        {
            get
            {
                if (this.sectionRepository == null)
                {
                    this.sectionRepository = new SectionRepository(context);
                }
                return this.sectionRepository;
            }
            set { this.sectionRepository = value; }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}

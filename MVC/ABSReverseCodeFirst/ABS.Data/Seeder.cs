using ABS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Data
{
    public class Seeder
    {
        public void AddSectionTypes()
        {
            using (BookingSystemDbContext context = new BookingSystemDbContext())
            {

                if (!context.FlightSectionTypes.Where(x => x.FlightSectionName == "First").Any())
                {
                    FlightSectionType first = new FlightSectionType() { FlightSectionName = "First" };
                    context.FlightSectionTypes.Add(first);

                }
                if (!context.FlightSectionTypes.Where(x => x.FlightSectionName == "Economy").Any())
                {
                    FlightSectionType economy = new FlightSectionType() { FlightSectionName = "Economy" };
                    context.FlightSectionTypes.Add(economy);

                }
                if (!context.FlightSectionTypes.Where(x => x.FlightSectionName == "Business").Any())
                {
                    FlightSectionType business = new FlightSectionType() { FlightSectionName = "Business" };
                    context.FlightSectionTypes.Add(business);
                }

                context.SaveChanges();
            }
        }
    }
}

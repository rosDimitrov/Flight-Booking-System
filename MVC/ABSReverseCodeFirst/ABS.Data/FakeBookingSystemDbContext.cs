// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ABS.Data
{
    using ABS.Configuration;
    using ABS.Model;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FakeBookingSystemDbContext : IBookingSystemDbContext
    {
        public System.Data.Entity.DbSet<Airline> Airlines { get; set; }
        public System.Data.Entity.DbSet<AirlineHistory> AirlineHistories { get; set; }
        public System.Data.Entity.DbSet<Airport> Airports { get; set; }
        public System.Data.Entity.DbSet<Flight> Flights { get; set; }
        public System.Data.Entity.DbSet<FlightSection> FlightSections { get; set; }
        public System.Data.Entity.DbSet<FlightSectionType> FlightSectionTypes { get; set; }
        public System.Data.Entity.DbSet<Seat> Seats { get; set; }
        public System.Data.Entity.DbSet<VFlightsInformation> VFlightsInformations { get; set; }

        public FakeBookingSystemDbContext()
        {
            Airlines = new FakeDbSet<Airline>("Id");
            AirlineHistories = new FakeDbSet<AirlineHistory>("Id");
            Airports = new FakeDbSet<Airport>("Id");
            Flights = new FakeDbSet<Flight>("Id");
            FlightSections = new FakeDbSet<FlightSection>("Id");
            FlightSectionTypes = new FakeDbSet<FlightSectionType>("Id");
            Seats = new FakeDbSet<Seat>("Id");
            VFlightsInformations = new FakeDbSet<VFlightsInformation>("AirlineName", "Origin", "Destination", "FlightSectionName", "FlightId", "Row", "Column", "IsTaken");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<SpFindAvailableFlightsBetweenReturnModel> SpFindAvailableFlightsBetween(string origin, string destination)
        {
            int procResult;
            return SpFindAvailableFlightsBetween(origin, destination, out procResult);
        }

        public System.Collections.Generic.List<SpFindAvailableFlightsBetweenReturnModel> SpFindAvailableFlightsBetween(string origin, string destination, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<SpFindAvailableFlightsBetweenReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<SpFindAvailableFlightsBetweenReturnModel>> SpFindAvailableFlightsBetweenAsync(string origin, string destination)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(SpFindAvailableFlightsBetween(origin, destination, out procResult));
        }

    }
}
// </auto-generated>

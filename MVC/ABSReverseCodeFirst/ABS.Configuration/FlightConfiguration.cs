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


namespace ABS.Configuration
{
    using ABS.Model;

    // Flight
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FlightConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Flight>
    {
        public FlightConfiguration()
            : this("dbo")
        {
        }

        public FlightConfiguration(string schema)
        {
            ToTable("Flight", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FlightId).HasColumnName(@"FlightId").HasColumnType("nvarchar").IsRequired().HasMaxLength(3);
            Property(x => x.DepartureDate).HasColumnName(@"DepartureDate").HasColumnType("datetime").IsRequired();
            Property(x => x.AirlineId).HasColumnName(@"AirlineId").HasColumnType("int").IsRequired();
            Property(x => x.OriginId).HasColumnName(@"OriginId").HasColumnType("int").IsRequired();
            Property(x => x.DestinationId).HasColumnName(@"DestinationId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Airline).WithMany(b => b.Flights).HasForeignKey(c => c.AirlineId).WillCascadeOnDelete(false); // FK__Flight__AirlineI__164452B1
            HasRequired(a => a.Destination).WithMany(b => b.Destination).HasForeignKey(c => c.DestinationId).WillCascadeOnDelete(false); // FK__Flight__Destinat__182C9B23
            HasRequired(a => a.Origin).WithMany(b => b.Origin).HasForeignKey(c => c.OriginId).WillCascadeOnDelete(false); // FK__Flight__OriginId__173876EA
        }
    }

}
// </auto-generated>
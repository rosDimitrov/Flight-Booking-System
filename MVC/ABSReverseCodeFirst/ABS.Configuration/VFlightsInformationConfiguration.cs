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

    // vFlightsInformation
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class VFlightsInformationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VFlightsInformation>
    {
        public VFlightsInformationConfiguration()
            : this("dbo")
        {
        }

        public VFlightsInformationConfiguration(string schema)
        {
            ToTable("vFlightsInformation", schema);
            HasKey(x => new { x.AirlineName, x.Origin, x.Destination, x.FlightSectionName, x.FlightId, x.Row, x.Column, x.IsTaken });

            Property(x => x.AirlineName).HasColumnName(@"AirlineName").HasColumnType("nvarchar").IsRequired().HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Origin).HasColumnName(@"Origin").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Destination).HasColumnName(@"Destination").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FlightSectionName).HasColumnName(@"FlightSectionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FlightId).HasColumnName(@"FlightId").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Row).HasColumnName(@"Row").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Column).HasColumnName(@"Column").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsTaken).HasColumnName(@"IsTaken").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>

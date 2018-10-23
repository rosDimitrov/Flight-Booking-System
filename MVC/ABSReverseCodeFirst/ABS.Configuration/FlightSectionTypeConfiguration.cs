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

    // FlightSectionType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FlightSectionTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FlightSectionType>
    {
        public FlightSectionTypeConfiguration()
            : this("dbo")
        {
        }

        public FlightSectionTypeConfiguration(string schema)
        {
            ToTable("FlightSectionType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FlightSectionName).HasColumnName(@"FlightSectionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(30);
        }
    }

}
// </auto-generated>

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


using System.ComponentModel;

namespace ABS.Model
{

    // Airline
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class Airline
    {
        public int Id { get; set; } // Id (Primary key)
        [DisplayName("")]
        public string AirlineName { get; set; } // AirlineName (length: 6)

        // Reverse navigation

        /// <summary>
        /// Child Flights where [Flight].[AirlineId] point to this entity (FK__Flight__AirlineI__164452B1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Flight> Flights { get; set; } // Flight.FK__Flight__AirlineI__164452B1

        public Airline()
        {
            Flights = new System.Collections.Generic.List<Flight>();
        }
    }

}
// </auto-generated>
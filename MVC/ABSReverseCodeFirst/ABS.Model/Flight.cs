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


namespace ABS.Model
{

    // Flight
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class Flight
    {
        public int Id { get; set; } // Id (Primary key)
        public string FlightId { get; set; } // FlightId (length: 3)
        public System.DateTime DepartureDate { get; set; } // DepartureDate
        public int AirlineId { get; set; } // AirlineId
        public int OriginId { get; set; } // OriginId
        public int DestinationId { get; set; } // DestinationId

        // Reverse navigation

        /// <summary>
        /// Child FlightSections where [FlightSection].[FlightId] point to this entity (FK__FlightSec__Fligh__1B0907CE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FlightSection> FlightSections { get; set; } // FlightSection.FK__FlightSec__Fligh__1B0907CE

        // Foreign keys

        /// <summary>
        /// Parent Airline pointed by [Flight].([AirlineId]) (FK__Flight__AirlineI__164452B1)
        /// </summary>
        public virtual Airline Airline { get; set; } // FK__Flight__AirlineI__164452B1
        /// <summary>
        /// Parent Airport pointed by [Flight].([DestinationId]) (FK__Flight__Destinat__182C9B23)
        /// </summary>
        public virtual Airport Destination { get; set; } // FK__Flight__Destinat__182C9B23
        /// <summary>
        /// Parent Airport pointed by [Flight].([OriginId]) (FK__Flight__OriginId__173876EA)
        /// </summary>
        public virtual Airport Origin { get; set; } // FK__Flight__OriginId__173876EA

        public Flight()
        {
            FlightSections = new System.Collections.Generic.List<FlightSection>();
        }
    }

}
// </auto-generated>

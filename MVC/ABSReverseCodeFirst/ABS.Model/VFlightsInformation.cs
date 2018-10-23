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

    // vFlightsInformation
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class VFlightsInformation
    {
        public string AirlineName { get; set; } // AirlineName (Primary key) (length: 6)
        public string Origin { get; set; } // Origin (Primary key) (length: 3)
        public string Destination { get; set; } // Destination (Primary key) (length: 3)
        public string FlightSectionName { get; set; } // FlightSectionName (Primary key) (length: 30)
        public string FlightId { get; set; } // FlightId (Primary key) (length: 3)
        public int Row { get; set; } // Row (Primary key)
        public int Column { get; set; } // Column (Primary key)
        public bool IsTaken { get; set; } // IsTaken (Primary key)
    }

}
// </auto-generated>
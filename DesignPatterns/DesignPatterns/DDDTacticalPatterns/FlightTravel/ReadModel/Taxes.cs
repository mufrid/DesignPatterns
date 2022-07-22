namespace DDDTacticalPatterns.FlightTravel.ReadModel
{
    public class Taxes
    {
        public Taxes(decimal environmentalTaxes, decimal airportTaxes) 
        {
            EnvironmentalTaxes = environmentalTaxes;
            AirportTaxes = airportTaxes;
        }

        public decimal EnvironmentalTaxes { get; }
        public decimal AirportTaxes { get; }
    }
}
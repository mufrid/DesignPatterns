using DesignPatterns;

namespace DDDTacticalPatterns.FlightTravel.WriteModel
{
    public class Price
    {
        public Price(decimal amount, Currency currency, IRegulationsService regulationsService) 
        {
            Amount = amount + regulationsService.GetTaxesAmount();
            Currency = currency;
        }

        public decimal Amount { get; }
        public Currency Currency { get; }
    }
}
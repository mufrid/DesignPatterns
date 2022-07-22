using DesignPatterns;

namespace DDDTacticalPatterns.FlightTravel.ReadModel
{
    public class Price
    {
        public Price(decimal amount, Currency currency, Taxes taxes) 
        {
            Amount = amount;
            Currency = currency;
            Taxes = taxes;
        }

        public decimal Amount { get; }
        public Currency Currency { get; }
        public Taxes Taxes { get; }
    }
}
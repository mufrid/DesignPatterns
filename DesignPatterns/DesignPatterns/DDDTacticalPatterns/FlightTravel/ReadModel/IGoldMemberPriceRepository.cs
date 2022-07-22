using DDDTacticalPatterns.FlightTravel.ReadModel;

namespace DDDTacticalPatterns
{
    public interface IGoldMemberPriceRepository
    {
        bool IsGoldMemberPrice(Price price);
    }
}
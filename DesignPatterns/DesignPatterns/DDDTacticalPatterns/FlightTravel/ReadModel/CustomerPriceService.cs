using DDDTacticalPatterns.FlightTravel.ReadModel;

namespace DDDTacticalPatterns
{
    public class CustomerPriceService
    {
        private readonly IGoldMemberPriceRepository _goldMemberPriceRepository;

        public CustomerPriceService(IGoldMemberPriceRepository goldMemberPriceRepository)
        {
            _goldMemberPriceRepository = goldMemberPriceRepository;
        }
        public bool AcceptPrice(Customer customer, Price priceOffered)
        {   
            if (customer.MembershipType == MembershipType.Gold && 
                _goldMemberPriceRepository.IsGoldMemberPrice(priceOffered) == false)
            {
                return false;
            }
            return true;
        }

    }
}
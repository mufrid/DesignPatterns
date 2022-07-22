namespace DDDTacticalPatterns {
    public class Customer {

        public Customer(MembershipType membershipType, int age) 
        {   
            if (age < 18) 
            {
                membershipType = MembershipType.Regular;
            } 
            else
            {   
                MembershipType = membershipType;
            }

            Age = age;

        }

        public MembershipType MembershipType { get; private set; }
        public int Age { get; private set; }
    }
}
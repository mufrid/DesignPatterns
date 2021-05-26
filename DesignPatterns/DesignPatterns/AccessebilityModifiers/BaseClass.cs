namespace DesignPatterns
{
    public class BaseClass
    {
        public string PublicMemberA => "memberA";

        protected string ProtectedMemberB => "memberB";

        internal string InternalMemberC => "memberC";

        protected internal string ProtectedInternalMemberD = "memberD";
    }
}
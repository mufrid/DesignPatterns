namespace DesignPatterns
{
    public class SameAssemblySubClass : BaseClass
    {
        public object ExposedInternalMemberFromBaseClass => InternalMemberC;
    }
}
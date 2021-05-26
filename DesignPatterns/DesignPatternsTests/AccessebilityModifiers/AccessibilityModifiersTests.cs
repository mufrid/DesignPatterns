using DesignPatterns;
using Xunit;

namespace DesignPatternsTests.AccessebilityModifiers
{
    public class AccessibilityModifiersTests
    {
        [Fact]
        public void AccessibilityModifierFromAnotherAssembly()
        {
            var subclass = new Subclass();

            Assert.NotNull(subclass.PublicMemberA);
            Assert.NotNull(subclass.ExposedProtectedMember);
        }

        [Fact]
        public void AccessibilityModifierFromSameAssembly()
        {
            var subclassFromSameAssembly = new SameAssemblySubClass();

            Assert.NotNull(subclassFromSameAssembly.ExposedInternalMemberFromBaseClass);
        }

        private class Subclass : BaseClass
        {
            public object ExposedProtectedMember => ProtectedMemberB;
        }
    }
}

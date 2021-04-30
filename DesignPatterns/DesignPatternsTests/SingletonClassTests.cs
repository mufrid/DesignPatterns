using DesignPatterns;
using System.Reflection;
using Xunit;

namespace DesignPatternsTests
{
    public class SingletonClassTests
    {
        [Fact]
        public void CreateInstance()
        {
            SingletonClass instance = SingletonClass.GetInstance();

            Assert.NotNull(instance);
        }

        [Fact]
        public void CreateTwoInstances_SameInstanceReturnedInBothCalls()
        {
            var firstInstance = SingletonClass.GetInstance();
            var secondInstance = SingletonClass.GetInstance();

            Assert.Same(firstInstance, secondInstance);
        }

        [Fact]
        public void InstanceClass_IsNotPossibleToInstantiateFromOutside()
        {
            ConstructorInfo[] constructors = typeof(SingletonClass).GetConstructors();

            Assert.DoesNotContain(constructors, constructor => constructor.IsPublic);
        }
    }
}

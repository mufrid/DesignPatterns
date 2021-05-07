using DesignPatterns;
using DesignPatterns.Factory;
using Xunit;

namespace DesignPatternsTests.Factory
{
    public class CurrencyConverterFactoryTests
    {
        [Fact]
        public void CreateDefaultJPYConverter()
        {
            var factory = new CurrencyNOKConverterFactory();

            var actual = factory.Create();

            Assert.IsType<NOKtoJPYConverter>(actual);
        }

        [Fact]
        public void CreateNOKtoEURConverter()
        {
            var currencyToConvertTo = Currency.EUR;

            var actual = new CurrencyNOKConverterFactory(currencyToConvertTo).Create();

            Assert.IsType<NOKtoEURConverter>(actual);
        }

        [Fact]
        public void CreateNOKtoLKRConverter()
        {
            var currencyToConvertTo = Currency.LKR;

            var actual = new CurrencyNOKConverterFactory(currencyToConvertTo).Create();

            Assert.IsType<NOKtoLKRConverter>(actual);
        }

        [Fact]
        public void Convert_FromNOKToOtherCurrencies_ReturnsCorrectResultsForEachCurrency()
        {
            ICurrencyConverter nokToEur = new CurrencyNOKConverterFactory(Currency.EUR).Create();
            ICurrencyConverter nokToLKR = new CurrencyNOKConverterFactory(Currency.LKR).Create();
            ICurrencyConverter nokToJPY = new CurrencyNOKConverterFactory().Create();

            float actualInEUR = nokToEur.Convert(kroner: 10);
            float actualInLKR = nokToLKR.Convert(kroner: 10);
            float actualInJPY = nokToJPY.Convert(kroner: 10);

            Assert.Equal(1, actualInEUR);
            Assert.Equal(238.3f, actualInLKR);
            Assert.Equal(131.3f, actualInJPY);
        }
    }
}

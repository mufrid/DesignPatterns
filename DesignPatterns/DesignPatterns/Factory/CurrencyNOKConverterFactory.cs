namespace DesignPatterns.Factory
{
    public class CurrencyNOKConverterFactory
    {
        public CurrencyNOKConverterFactory()
        {
            m_currencyToConvertTo = Currency.JPY;
            m_defaultToJPYConverter = new NOKtoJPYConverter();
        }

        public CurrencyNOKConverterFactory(Currency currencyToConvertTo)
        {
            m_currencyToConvertTo = currencyToConvertTo;
        }

        public ICurrencyConverter Create()
        {
            switch (m_currencyToConvertTo)
            {
                case Currency.EUR:
                    return new NOKtoEURConverter();
                case Currency.LKR:
                    return new NOKtoLKRConverter();
                default:
                    return m_defaultToJPYConverter;
            }
        }

        private readonly Currency m_currencyToConvertTo;
        private readonly NOKtoJPYConverter m_defaultToJPYConverter;
    }
}

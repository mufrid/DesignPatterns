using DesignPatterns.Factory;

namespace DesignPatterns
{
    public class NOKtoLKRConverter : ICurrencyConverter
    {
        public float Convert(int kroner)
        {
            return kroner * 23.83f;
        }
    }
}
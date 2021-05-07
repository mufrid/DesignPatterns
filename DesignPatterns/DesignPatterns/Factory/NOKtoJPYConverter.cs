using DesignPatterns.Factory;

namespace DesignPatterns
{
    public class NOKtoJPYConverter : ICurrencyConverter
    {
        public float Convert(int kroner)
        {
            return kroner * 13.13f;
        }
    }
}
using DesignPatterns.Factory;

namespace DesignPatterns
{
    public class NOKtoEURConverter : ICurrencyConverter
    {
        public float Convert(int kroner)
        {
            return kroner * 0.1f;
        }
    }
}
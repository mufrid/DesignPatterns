namespace DesignPatterns
{
    public class SingletonClass
    {
        private static readonly SingletonClass m_instance = new();

        private SingletonClass() { }

        public static SingletonClass GetInstance()
        {
            return m_instance;
        }
    }
}
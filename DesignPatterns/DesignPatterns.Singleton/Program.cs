using System;

namespace DesignPatterns.Singleton
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern");

            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    public class Singleton
    {
        private static Singleton _instance;
        protected Singleton()
        {
        }
        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}

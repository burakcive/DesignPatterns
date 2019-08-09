using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryMethod");

            RecruiterFactory.ScoutFootballer(FootballerZone.Africa);
            RecruiterFactory.ScoutFootballer(FootballerZone.Asia);
            RecruiterFactory.ScoutFootballer(FootballerZone.Europe);
            RecruiterFactory.ScoutFootballer(FootballerZone.SouthAmerica);

            Console.Read();
        }
    }
}

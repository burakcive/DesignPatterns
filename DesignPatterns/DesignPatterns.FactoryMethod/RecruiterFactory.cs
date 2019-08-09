namespace DesignPatterns.FactoryMethod
{
    public class RecruiterFactory
    {
        public static void ScoutFootballer(FootballerZone zone)
        {
            switch (zone)
            {
                case FootballerZone.SouthAmerica:
                    new ForwardRecruiter(zone).SearchForFootballers();
                    break;
                case FootballerZone.Africa:
                    new DefenceRecruiter(zone).SearchForFootballers();
                    break;
                case FootballerZone.Europe:
                    new MidfielderRecruiter(zone).SearchForFootballers();
                    break;
                case FootballerZone.Asia:
                    new MidfielderRecruiter(zone).SearchForFootballers();
                    break;
                default:
                    break;
            }
        }
    }
}

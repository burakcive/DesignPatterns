namespace DesignPatterns.FluentBuilder
{
    public class TeamBuilder : ITeamBuilder
    {
        private string name;
        private string nickName;
        private Color shirtColor;
        private string homeTown;
        private string ground;

        public TeamBuilder CreateTeam(string name)
        {
            this.name = name;
            return this;
        }

        public TeamBuilder WithNickName(string nickName)
        {
            this.nickName = nickName;
            return this;
        }

        public TeamBuilder WithShirtColor(Color shirtColor)
        {
            this.shirtColor = shirtColor;
            return this;
        }

        public TeamBuilder FromTown(string homeTown)
        {
            this.homeTown = homeTown;
            return this;
        }

        public TeamBuilder PlayingAt(string ground)
        {
            this.ground = ground;
            return this;
        }

        // CONVERSION OPERATOR
        public static implicit operator Team(TeamBuilder tb)
        {
            return new Team(
                tb.name,
                tb.nickName,
                tb.shirtColor,
                tb.homeTown,
                tb.ground);
        }
    }
}

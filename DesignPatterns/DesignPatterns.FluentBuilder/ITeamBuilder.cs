namespace DesignPatterns.FluentBuilder
{
    public interface ITeamBuilder
    {
        TeamBuilder CreateTeam(string name);
        TeamBuilder FromTown(string homeTown);
        TeamBuilder PlayingAt(string ground);
        TeamBuilder WithNickName(string nickName);
        TeamBuilder WithShirtColor(Color shirtColor);
    }
}
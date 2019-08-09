using System;

namespace DesignPatterns.FluentBuilder
{
    public class Team
    {
        private string Name { get; set; }
        private string NickName { get; set; }
        private Color ShirtColor { get; set; }
        private string HomeTown { get; set; }
        private string Ground { get; set; }

        public Team(
            string name,
            string nickName,
            Color shirtColor,
            string homeTown,
            string ground)
        {
            Name = name;
            NickName = nickName;
            ShirtColor = shirtColor;
            HomeTown = homeTown;
            Ground = ground;
        }

        public override string ToString()
        {
            return $"{nameof(Name)} => {Name}{Environment.NewLine}" +
                   $"{nameof(NickName)} => {NickName}{Environment.NewLine}" +
                   $"{nameof(ShirtColor)} => {ShirtColor}{Environment.NewLine}" +
                   $"{nameof(HomeTown)} => {HomeTown}{Environment.NewLine}" +
                   $"{nameof(Ground)} => {Name}";
        }
    }
}

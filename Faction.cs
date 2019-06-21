using System;
using System.Linq;

namespace KTNameGenerator.Core
{
    public class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenerationType GenerationType { get; set; }
        public SubFaction[] SubFactions { get; set; }
        public string[] Forenames { get; set; }
        public string[] Surnames { get; set; }
        public bool HasSubfactions => !(SubFactions is null) || !SubFactions.Any();

        public string GenerateName(int? subFactionId)
        {
            switch (GenerationType)
            {
                case GenerationType.D10:
                    return generateD10Name(subFactionId);
                case GenerationType.D66:
                    return generateD66Name(subFactionId);
                default:
                    throw new ArgumentOutOfRangeException($"Invalid {nameof(GenerationType)} was specified!");
            }
        }

        private string generateD10Name(int? subFactionId)
        {
            if (subFactionId is null)
                return $"{Forenames[Dice.D10]} {Surnames[Dice.D10]}";
            
            var subFaction = SubFactions[subFactionId.Value];

            return $"{subFaction.Forenames[Dice.D10]} {subFaction.Surnames[Dice.D10]}";
        }

        private string generateD66Name(int? subFaction)
            => $"{SubFactions[subFaction.Value].Forenames[Dice.D6 * Dice.D6]}";
    }
}
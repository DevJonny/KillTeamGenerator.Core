using System;
using System.Linq;
using KTNameGenerator.Core.Data;

namespace KTNameGenerator.Core.Model
{
    public class Faction
    {
        public FactionType Type { get; internal set; }
        public string Name { get; internal set; }
        public GenerationType GenerationType { get; internal set; }
        public ConcatenationType ConcatenationType { get; internal set; }
        public SubFaction[] SubFactions { get; internal set; }
        public string[] Forenames { get; internal set; }
        public string[] Surnames { get; internal set; }
        public bool HasSubFactions => !(SubFactions is null) && SubFactions.Any();

        public SubFaction SubFactionByType(SubFactionType type) => SubFactions?.SingleOrDefault(f => f.Type == type);

        public string GenerateName(SubFactionType type)
        {
            return GenerateName((int) type);
        }

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
            return generateName(subFactionId, Dice.D10, Dice.D10);
        }

        private string generateD66Name(int? subFactionId)
        {
            return generateName(subFactionId, Dice.D6 * Dice.D6, Dice.D6 * Dice.D6);
        }

        private string generateName(int? subFactionId, int forenameValue, int surnameValue)
        {
            var concatenation = ConcatenationType is ConcatenationType.Combine ? string.Empty : " ";

            if (subFactionId is null)
                return $"{Forenames[forenameValue]}{concatenation}{Surnames[surnameValue]}";

            var subFaction = SubFactions[subFactionId.Value];
            var forename = subFaction.Forenames[forenameValue];
            var surname = subFaction.Surnames[surnameValue];

            return $"{forename}{concatenation}{surname}";
        }
    }
}
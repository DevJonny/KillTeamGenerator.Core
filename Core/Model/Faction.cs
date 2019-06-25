using System;
using System.Collections.Generic;
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

        public IEnumerable<string> GenerateNames(int numberOfNames, SubFactionType? subFactionType = null)
        {
            var names = new string[numberOfNames];
            
            for (int i = 0; i < numberOfNames; i++)
            {
                names[i] = GenerateName(subFactionType);
            }

            return names;
        }
        
        public string GenerateName(SubFactionType? subFactionType = null)
        {
            switch (GenerationType)
            {
                case GenerationType.D10:
                    return generateD10Name(subFactionType);
                case GenerationType.D66:
                    return generateD66Name(subFactionType);
                default:
                    throw new ArgumentOutOfRangeException($"Invalid {nameof(GenerationType)} was specified!");
            }
        }

        private string generateD10Name(SubFactionType? subFactionType)
        {
            return generateName(subFactionType, Dice.D10, Dice.D10);
        }

        private string generateD66Name(SubFactionType? subFactionType)
        {
            return generateName(subFactionType, Dice.D66, Dice.D66);
        }

        private string generateName(SubFactionType? subFactionType, int forenameValue, int surnameValue)
        {
            var concatenation = ConcatenationType is ConcatenationType.Combine ? string.Empty : " ";

            if (subFactionType is null)
                return $"{Forenames[forenameValue]}{concatenation}{Surnames[surnameValue]}";

            var subFaction = SubFactions.Single(sf => sf.Type == subFactionType);
            var forename = subFaction.Forenames[forenameValue];
            var surname = subFaction.Surnames[surnameValue];

            return $"{forename}{concatenation}{surname}";
        }
    }
}
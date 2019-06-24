using KTNameGenerator.Core.Data;

namespace KTNameGenerator.Core.Model
{
    public class SubFaction
    {
        public SubFactionType Type { get; set; }
        public string Name { get; set; }
        public string[] Forenames { get; set; }
        public string[] Surnames { get; set; }
    }
}
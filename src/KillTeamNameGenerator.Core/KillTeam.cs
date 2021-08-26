using System.Linq;
using KillTeamNameGenerator.Core.Data;
using KillTeamNameGenerator.Core.Model;

namespace KillTeamNameGenerator.Core
{
    public static class KillTeam
    {
        public static Faction FactionById(int id)
        {
            return FactionData.Factions.Single(f => (int)f.Type == id);
        }

        public static Faction FactionByType(FactionType type)
        {
            return FactionById((int)type);
        }
    }
}
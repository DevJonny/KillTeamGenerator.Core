using System.Linq;
using KTNameGenerator.Core.Data;
using KTNameGenerator.Core.Model;

namespace KTNameGenerator.Core
{
    public static class KillTeam
    {
        public static Faction FactionById(int id)
        {
            return FactionData.Factions.Single(f => f.Id == id);
        }
    }
}
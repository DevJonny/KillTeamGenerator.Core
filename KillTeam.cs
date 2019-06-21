using System.Collections.Generic;
using System.IO;
using System.Linq;
using KTNameGenerator.Core.Model;
using Newtonsoft.Json;

namespace KTNameGenerator.Core
{
    public class KillTeam
    {
        private static readonly string _dataPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "data.json");
        private static IEnumerable<Faction> _factions;

        public static IEnumerable<Faction> Factions()
        {
            if (!(_factions is null)) 
                return _factions;
            
            var data = File.ReadAllText(_dataPath);
            _factions = JsonConvert.DeserializeObject<IEnumerable<Faction>>(data);

            return _factions;
        }

        public static Faction FactioById(int id)
        {
            return Factions().Single(f => f.Id == id);
        }
    }
}
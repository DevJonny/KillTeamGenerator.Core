using System.Linq;
using KillTeamNameGenerator.Core.Data;
using Spectre.Console;

namespace KillTeamNameGenerator.Cli
{
    class Program
    {
        private const string Generate = "Generate";
        private const string Quit = "Quit";
        
        static void Main(string[] args)
        {
            var generate = true;

            while (generate)
            {
                GenerateNames();

                var generateOrQuit = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Generate or Quit?")
                        .AddChoices(Generate, Quit));

                generate = generateOrQuit == Generate;
            }
        }

        private static void GenerateNames()
        {
            var factions = FactionData.Factions.ToList();

            var faction = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select your faction:")
                    .AddChoices(factions.Select(f => f.Name)));

            var numberOfNames = AnsiConsole.Prompt(
                new SelectionPrompt<int>()
                    .Title("How many names to generate?")
                    .AddChoices(Enumerable.Range(1, 20)));

            var selectedFaction = factions.First(f => f.Name == faction);

            var results = new Table
            {
                Title = new TableTitle($"Names for {selectedFaction.Name}")
            };
            results.AddColumn("Name");

            foreach (var name in selectedFaction.GenerateNames(numberOfNames))
            {
                results.AddRow(name);
            }

            AnsiConsole.Render(results);
        }
    }
}
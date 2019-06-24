# Random name generator for Warhammer 40,000 Kill Team

## Installation

You can install the name generator using your favourite NuGet client. For example using the dotnet cli:

`dotnet add package KTNameGenerator.Core`

## Usage

Ther are two public methods you can use get the data for a particular faction.

`KillTeam.FactionById(int factionId)` or `KillTeam.FactionByType(FactionType type)`

For example to generate names for the Grey Knights you use the following:

`var name = KillTeam.FactionByType(FactionType.GreyKnights).GenerateName();`

If the faction you want has sub factions, like the Adeptus Astartes you can pass an optional param to `GenerateName`.

`var name = KillTeam.FactionByType(FactionType.AdeptusAstartes).GenerateName(SubFactionType.ImperialFists);`

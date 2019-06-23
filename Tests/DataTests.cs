using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using KTNameGenerator.Core.Model;
using Xunit;

namespace KTNameGenerator.Core.Tests
{
    public class DataTests
    {
        [Theory]
        [InlineData("Ultramarines")]
        [InlineData("Imperial Fists")]
        [InlineData("Blood Angels")]
        [InlineData("Raven Guard")]
        [InlineData("White Scars")]
        [InlineData("Iron Hands")]
        [InlineData("Space Wolves")]
        [InlineData("Salamanders")]
        [InlineData("Dark Angels")]
        public void Adeptus_Astartes_Has_Full_Data(string subFactionName)
        {
            var adeptusAstartes = KillTeam.FactionById(1);
            adeptusAstartes.HasSubFactions.Should().BeTrue();

            AssertD10SubFaction(adeptusAstartes.SubFactions, subFactionName);
        }

        [Fact]
        public void Grey_Knights_Has_Full_Data()
        {
            var greyKnights = KillTeam.FactionById(2);
            greyKnights.HasSubFactions.Should().BeFalse();

            AssertD10Faction(greyKnights);
        }

        [Theory]
        [InlineData("Cadian")]
        [InlineData("Catachan")]
        [InlineData("Valhallan")]
        [InlineData("Tallarn")]
        public void Astra_Militarum_Has_Full_Data(string subFactionName)
        {
            var astraMil = KillTeam.FactionById(3);
            astraMil.HasSubFactions.Should().BeTrue();

            AssertD66SubFaction(astraMil.SubFactions, subFactionName);

            astraMil.SubFactions.SelectMany(sf => sf.Surnames).All(s => s == string.Empty).Should().BeTrue();
        }

        [Fact]
        public void Adeptus_Mechanicus_Has_Full_Data()
        {
            var adeptusMechanicus = KillTeam.FactionById(4);

            AssertD66Faction(adeptusMechanicus);
        }

        [Theory]
        [InlineData("Black Legion")]
        [InlineData("Alpha Legion")]
        [InlineData("Emperor's Children")]
        [InlineData("World Eaters")]
        public void Heretic_Astartes_Has_Full_Data(string subFactionName)
        {
            var hereticAstartes = KillTeam.FactionById(5);
            hereticAstartes.HasSubFactions.Should().BeTrue();
            
            AssertD10SubFaction(hereticAstartes.SubFactions, subFactionName);
        }

        [Fact]
        public void Death_Guard_Has_Full_Data()
        {
            var deathGuard = KillTeam.FactionById(6);
            deathGuard.HasSubFactions.Should().BeFalse();
            
            AssertD10Faction(deathGuard);
        }

        [Fact]
        public void Thousand_Sons_Has_Full_Data()
        {
            var thousandSons = KillTeam.FactionById(7);
            thousandSons.HasSubFactions.Should().BeFalse();
            
            AssertD10Faction(thousandSons);
        }

        [Theory]
        [InlineData("Female")]
        [InlineData("Male")]
        public void Asuryani_Has_Full_Data(string subFactionName)
        {
            var asuryani = KillTeam.FactionById(8);
            asuryani.HasSubFactions.Should().BeTrue();
            
            AssertD66SubFaction(asuryani.SubFactions, subFactionName);
        }

        [Theory]
        [InlineData("Kabalite")]
        [InlineData("Wych Cult")]
        public void Drukhari_Has_Full_Data(string subFactionName)
        {
            var drukhari = KillTeam.FactionById(9);
            drukhari.HasSubFactions.Should().BeTrue();
            
            AssertD66SubFaction(drukhari.SubFactions, subFactionName);
        }

        [Fact]
        public void Harlequins_Has_Full_Data()
        {
            var harlequins = KillTeam.FactionById(10);
            harlequins.HasSubFactions.Should().BeFalse();
            
            AssertD10Faction(harlequins);
        }

        [Fact]
        public void Necrons_Has_Full_Data()
        {
            var necrons = KillTeam.FactionById(11);
            necrons.HasSubFactions.Should().BeFalse();
            
            AssertD66Faction(necrons);
        }

        [Fact]
        public void Orks_Has_Full_Data()
        {
            var orks = KillTeam.FactionById(12);
            orks.HasSubFactions.Should().BeFalse();
            
            AssertD66Faction(orks);
        }

        [Fact]
        public void Tau_Has_Full_Data()
        {
            var tau = KillTeam.FactionById(13);
            tau.HasSubFactions.Should().BeFalse();
            
            AssertD66Faction(tau);
        }

        [Fact]
        public void Tyranid_Has_Full_Data()
        {
            var nid = KillTeam.FactionById(14);
            nid.HasSubFactions.Should().BeFalse();
            
            AssertD66Faction(nid);
        }

        [Fact]
        public void Genestealer_Cult_Has_Full_Data()
        {
            var genestealerCult = KillTeam.FactionById(15);
            genestealerCult.HasSubFactions.Should().BeFalse();
            
            AssertD66Faction(genestealerCult);
        }
        
        private static void AssertD66Faction(Faction faction)
        {
            faction.Forenames.Length.Should().Be(36);
            faction.Surnames.Length.Should().Be(36);
        }

        private static void AssertD66SubFaction(IEnumerable<SubFaction> subFactions, string subFactionName)
        {
            var subFaction = subFactions.SingleOrDefault(f => f.Name.Equals(subFactionName, StringComparison.InvariantCultureIgnoreCase));            
            subFaction.Should().NotBeNull();
            subFaction.Forenames.Length.Should().Be(36);
            subFaction.Surnames.Length.Should().Be(36);
        }

        private static void AssertD10Faction(Faction faction)
        {
            faction.Forenames.Length.Should().Be(10);
            faction.Surnames.Length.Should().Be(10);
        }

        private static void AssertD10SubFaction(IEnumerable<SubFaction> subFactions, string subFactionName)
        {
            var subFaction = subFactions.SingleOrDefault(f => f.Name.Equals(subFactionName, StringComparison.InvariantCultureIgnoreCase));
            
            subFaction.Should().NotBeNull();

            subFaction.Forenames.Length.Should().Be(10);
            subFaction.Surnames.Length.Should().Be(10);
        }
    }
}
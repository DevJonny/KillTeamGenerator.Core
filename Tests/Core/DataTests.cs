using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using KTNameGenerator.Core;
using KTNameGenerator.Data;
using KTNameGenerator.Model;
using Xunit;

namespace KTNameGenerator.Tests.Core
{
    public class DataTests
    {
        [Theory]
        [InlineData(SubFactionType.Ultramarines)]
        [InlineData(SubFactionType.ImperialFists)]
        [InlineData(SubFactionType.BloodAngels)]
        [InlineData(SubFactionType.RavenGuard)]
        [InlineData(SubFactionType.WhiteScars)]
        [InlineData(SubFactionType.IronHands)]
        [InlineData(SubFactionType.SpaceWolves)]
        [InlineData(SubFactionType.Salamanders)]
        [InlineData(SubFactionType.DarkAngels)]
        public void Adeptus_Astartes_Has_Full_Data(SubFactionType subFactionName)
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
        [InlineData(SubFactionType.Cadian)]
        [InlineData(SubFactionType.Catachan)]
        [InlineData(SubFactionType.Valhallan)]
        [InlineData(SubFactionType.Tallarn)]
        public void Astra_Militarum_Has_Full_Data(SubFactionType subFactionName)
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
        [InlineData(SubFactionType.BlackLegion)]
        [InlineData(SubFactionType.AlphaLegion)]
        [InlineData(SubFactionType.EmperorsChildren)]
        [InlineData(SubFactionType.WorldEaters)]
        public void Heretic_Astartes_Has_Full_Data(SubFactionType subFactionName)
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
        [InlineData(SubFactionType.AsuryaniFemale)]
        [InlineData(SubFactionType.AsuryaniMale)]
        public void Asuryani_Has_Full_Data(SubFactionType subFactionType)
        {
            var asuryani = KillTeam.FactionById(8);
            asuryani.HasSubFactions.Should().BeTrue();
            
            AssertD66SubFaction(asuryani.SubFactions, subFactionType);
        }

        [Theory]
        [InlineData(SubFactionType.Kabalite)]
        [InlineData(SubFactionType.WychCult)]
        public void Drukhari_Has_Full_Data(SubFactionType subFactionName)
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

        [Theory]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.Ultramarines)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.ImperialFists)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.BloodAngels)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.RavenGuard)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.WhiteScars)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.IronHands)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.SpaceWolves)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.Salamanders)]
        [InlineData(FactionType.AdeptusAstartes, SubFactionType.DarkAngels)]
        [InlineData(FactionType.AstraMilitarum, SubFactionType.Cadian)]
        [InlineData(FactionType.AstraMilitarum, SubFactionType.Catachan)]
        [InlineData(FactionType.AstraMilitarum, SubFactionType.Valhallan)]
        [InlineData(FactionType.AstraMilitarum, SubFactionType.Tallarn)]
        [InlineData(FactionType.HereticAstartes, SubFactionType.BlackLegion)]
        [InlineData(FactionType.HereticAstartes, SubFactionType.AlphaLegion)]
        [InlineData(FactionType.HereticAstartes, SubFactionType.EmperorsChildren)]
        [InlineData(FactionType.HereticAstartes, SubFactionType.WorldEaters)]
        [InlineData(FactionType.Asuryani, SubFactionType.AsuryaniFemale)]
        [InlineData(FactionType.Asuryani, SubFactionType.AsuryaniMale)]
        [InlineData(FactionType.Drukhari, SubFactionType.Kabalite)]
        [InlineData(FactionType.Drukhari, SubFactionType.WychCult)]
        public void Thousand_Name_Generate_Correctly_For_Sub_Factions(FactionType type, SubFactionType subFactionType)
        {
            for (var i = 0; i < 1000; i++)
            {
                Action generate = () => KillTeam.FactionByType(type).GenerateName(subFactionType);
                
                generate.Should().NotThrow();
            }
        }
        
        [Theory]
        [InlineData(FactionType.GreyKnights)]
        [InlineData(FactionType.AdeptusMechanicus)]
        [InlineData(FactionType.DeathGuard)]
        [InlineData(FactionType.ThousandSons)]
        [InlineData(FactionType.Harlequins)]
        [InlineData(FactionType.Necrons)]
        [InlineData(FactionType.Orks)]
        [InlineData(FactionType.Tau)]
        [InlineData(FactionType.Tyranid)]
        [InlineData(FactionType.GenestealerCult)]
        public void Thousand_Name_Generate_Correctly_For_Factions(FactionType type)
        {
            for (var i = 0; i < 1000; i++)
            {
                Action generate = () => KillTeam.FactionByType(type).GenerateName(null);
                
                generate.Should().NotThrow();
            }
        }
        
        private static void AssertD66Faction(Faction faction)
        {
            faction.Forenames.Length.Should().Be(36);
            faction.Surnames.Length.Should().Be(36);
        }

        private static void AssertD66SubFaction(IEnumerable<SubFaction> subFactions, SubFactionType subFactionType)
        {
            var subFaction = subFactions.SingleOrDefault(s => s.Type == subFactionType);            
            subFaction.Should().NotBeNull();
            subFaction.Forenames.Length.Should().Be(36);
            subFaction.Surnames.Length.Should().Be(36);
        }

        private static void AssertD10Faction(Faction faction)
        {
            faction.Forenames.Length.Should().Be(10);
            faction.Surnames.Length.Should().Be(10);
        }

        private static void AssertD10SubFaction(IEnumerable<SubFaction> subFactions, SubFactionType subFactionType)
        {
            var subFaction = subFactions.SingleOrDefault(s => s.Type == subFactionType);
            
            subFaction.Should().NotBeNull();

            subFaction.Forenames.Length.Should().Be(10);
            subFaction.Surnames.Length.Should().Be(10);
        }
    }
}
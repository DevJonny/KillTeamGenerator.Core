using System.Collections.Generic;
using KTNameGenerator.Core.Model;

namespace KTNameGenerator.Core.Data
{
    public static class FactionData
    {
        public static IEnumerable<Faction> Factions => new List<Faction>
        {
            new Faction
            {
                Type = FactionType.AdeptusAstartes,
                Name = "Adeptus Astartes",
                GenerationType = GenerationType.D10,
                ConcatenationType = ConcatenationType.Space,
                SubFactions = new[]
                {
                    new SubFaction
                    {
                        Type = SubFactionType.Ultramarines,
                        Name = "Ultramarines",
                        Forenames = new[]
                        {
                            "Marius", "Agnathio", "Ollonius", "Cato", "Titus", "Agies", "Gaius", "Andrus", "Marcus", "Cassius"
                        },
                        Surnames = new[]
                        {
                            "Chronus", "Tarentus", "Dysorius", "Cassus", "Acastian", "Varenus", "Apollon", "Aggennor", "Castus", "Poladrus"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.ImperialFists,
                        Name = "Imperial Fists",
                        Forenames = new[]
                        {
                            "Lydus", "Darnath", "Lexandro", "Nereus", "Tylaeus", "Vorn", "Tor", "Boreas", "Jago", "Oreas"
                        },
                        Surnames = new[]
                        {
                            "Hagen", "Mirhen", "Garadon", "Lytanus", "Danithor", "Markov", "Mordelai", "Julan", "Darsway", "Lordann"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.BloodAngels,
                        Name = "Blood Angels",
                        Forenames = new[]
                        {
                            "Amareus", "Erasmus", "Rafael", "Morlaco", "Leonid", "Faustian", "Donatelus", "Raelyn", "Nicodemus", "Furian"
                        },
                        Surnames = new[]
                        {
                            "Belarius", "Seraphan", "Moriar", "Raneil", "Castivar", "Arteros", "Redolpho", "Lorenso", "Amuto", "Rephas"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.RavenGuard,
                        Name = "Raven Guard",
                        Forenames = new[]
                        {
                            "Aajx", "Kyrin", "Vykus", "Tryis", "Ordias", "Navaer", "Syras", "Aevar", "Reszan", "Vorkyl"
                        },
                        Surnames = new[]
                        {
                            "Kaed", "Solari", "Solaq", "Qeld", "Korvaedyn", "Vaanes", "Torvaec", "Klayde", "Moradus", "Ordaris"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.WhiteScars,
                        Name = "White Scars",
                        Forenames = new[]
                        {
                            "Anagar", "Khajog", "Suberei", "Khoros", "Jaygor", "Seglei", "Jurgah", "Kaljyk", "Kulghu", "Saghari"
                        },
                        Surnames = new[]
                        {
                            "Gatughan", "Yesuberei", "Ghol", "Jaghol", "Kandakh", "Mologhai", "Ujumm", "Bhangleo", "J'ungah", "Aghulo"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.IronHands,
                        Name = "Iron Hands",
                        Forenames = new[]
                        {
                            "Arrven", "Gorrloch", "Shorrgol", "Galorr", "Dorrghun", "Kaagos", "Barrgus", "Ghorrean", "Orros", "Gdolkin"
                        },
                        Surnames = new[]
                        {
                            "Feirros", "Graevarr", "Bannus", "Lydriik", "Terrek", "Korvaan", "Urloch", "Rauth", "Varrox", "Xeriis"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.SpaceWolves,
                        Name = "Space Wolves",
                        Forenames = new[]
                        {
                            "Gunnar", "Ulfrich", "Laars", "Sven", "Wulfgar", "Erik", "Dolf", "Leif", "Olaf", "Torrvald"
                        },
                        Surnames = new[]
                        {
                            "Ironaxe", "Icefang", "Orksbane", "the Red", "Wrymslayer", "Thunderhowl", "Stormstrider", "Stoneshield", "Trollbane", "Greymane"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.Salamanders,
                        Name = "Salamanders",
                        Forenames = new[]
                        {
                            "Dak'Lyr", "Sho'Tan", "Tsu'Gar", "Fugean", "Xavus", "Nubari", "Vorr'n", "Sholta", "Xa'Vor", "Leotrak"
                        },
                        Surnames = new[]
                        {
                            "K'Gosi", "Dallor", "Jurr", "Mir'Shan", "Shenn", "Ta'Phor", "Rhoshan", "Antanar", "Shal'Dar", "Gar'Dos"
                        }
                    },

                    new SubFaction
                    {
                        Type = SubFactionType.DarkAngels,
                        Name = "Dark Angels",
                        Forenames = new[]
                        {
                            "Azkarael", "Zakeal", "Rhellion", "Zoreal", "Azathor", "Shoriel", "Nemator", "Ezekial", "Bethor", "Zadakial"
                        },
                        Surnames = new[]
                        {
                            "Zaborial", "Azdallon", "Zacahrus", "Astathor", "Seraphus", "Zanthor", "Kaelon", "Namaat", "Soriel", "Belian"
                        }
                    }
                }
            },
            new Faction
            {
                Type = FactionType.GreyKnights,
                Name = "Grey Knights",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "Alaric","Anval","Ahakim","Dokelus","Blaris","Icanus","Martesias","Galan","Retius","Jarrius",
                    "Cyntanus","Pellastis","Axatinos","Garran","Vitennias","Xeridon","Jakaton","Jaric","Caddon",
                    "Aldrios","Beliaros","Kardoch","Astokar","Galarr","Xerikim","Archaddeus","Medemeion","Cortane",
                    "Janutrius","Furoza","Drystan","Ortus","Lushian","Elrin","Arion","Valdar"
                },
                Surnames = new[]
                {
                    "Geronitan","Vortimer","Ignatius","Issad","Edeon","Neodan","Phoros","Zaebus","Thawn","Nedth",
                    "Gruila","Tekios","Thamare","Alegssus","Esdrios","Thule","Simedes","Arelis","Ortyrian","Akantar",
                    "Cordacus","Massius","Vibova","Tydes","Elgon","Cybaddas","Adantor","Sorak","Invio","Kai","Solor",
                    "Varn","Trevan","Morretus","Cybasi","Santon"
                }
            },
            new Faction
            {
                Type = FactionType.AstraMilitarum,
                Name = "Astra Militarum",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                SubFactions = new[]
                {
                    new SubFaction
                    {
                        Type = SubFactionType.Cadian,
                        Name = "Cadian",
                        Forenames = new[]
                        {
                            "Jens", "Karsk", "Hekler", "Reeve", "Pavlo", "Hektor", "Nils", "Thenmann", "Kyser", "Erlen", "Raphe", "Creed", "Lasko", "Ackerman", "Mattias",
                            "Mortens", "Dansk", "Feodor", "Tomas", "Kolson", "Vance", "Pask", "Niems", "Gryf", "Willem", "Sonnen", "Ekhter", "Farestein", "Dekker", "Graf",
                            "Arvans", "Viers", "Kolm", "Bask", "Vesker", "Pavlo"
                        },
                        Surnames = _empty36
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.Catachan,
                        Name = "Catachan",
                        Forenames = new[]
                        {
                            "Gunnarsen", "Harker", "Grytt", "'Snake' Vandien", "Greiss", "Stryker", "Storm", "Lance", "'Crazy' Winters", "Cage", "Hammer", "Cobra",
                            "'Hardhead' Jackson", "'Stonefist' Kage", "'Boos' Stranksky", "'Bomber' Johnson", "Jacksen", "Marshall", "'Fangs' Lorson", "'Cold-eye' McKay",
                            "Wolf", "'Shiv' Frost", "Brent", "'Ironheart' McKillen", "'Killer' Crowe", "'Wildman' Weiss", "'Ice' Creek", "Dane", "Steeljaw", "Dranksky",
                            "'Slim' Hasker", "Mason", "Hawks", "Axel", "Carver", "Payne"
                        },
                        Surnames = _empty36
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.Valhallan,
                        Name = "Valhallan",
                        Forenames = new[]
                        {
                            "Vensk", "Skarrsen", "Chernov", "Dushenko", "Rynsk", "Gorska", "Varence", "Nyska", "Putran", "Dorff", "Tyvosk", "Polanski", "Drekoff", "Vorn",
                            "Hapscheldt", "Olof", "Trevinska", "Schonnen", "Kleiss", "Borys", "Ivanek", "Smirnek", "Kuzentsev", "Vasilesnev", "Petravitch", "Skolov",
                            "Fedorev", "Morazev", "Volko", "Lebesnev", "Egoryn", "Pavlek", "Kozlev", "Stepanovicz", "Nikoli", "Orlakev"
                        },
                        Surnames = _empty36
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.Tallarn,
                        Name = "Tallarn",
                        Forenames = new[]
                        {
                            "Alem", "Hallain", "Laskair", "Nathal", "Altarem", "Mohal", "Dharem", "Hasman", "Sonnam", "Ushmet", "Shadnan", "Asphret", "Ushad", "Tal'hasen",
                            "Ashmyr", "Shashlem", "Haseed", "Ushar", "Raheim", "Dassed", "Sahleim", "Alhret", "Khaleeth", "Eshmet", "Ul'shalem", "Talannar", "Al'phareim",
                            "El'shan", "Khabir", "Khalym", "'Swiftrider'", "'Dunestrider'", "'Hawkseye'", "'Sand Devil'", "'the Mirage'", "'the Hunter"
                        },
                        Surnames = _empty36
                    }
                }
            },
            new Faction
            {
                Type = FactionType.AdeptusMechanicus,
                Name = "Adeptus Mechanicus",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Combine,
                Forenames = new[]
                {
                    "Sy-gex", "Tyr", "Dak", "Ar", "Kappie-Schoelendt", "Tyba", "Dorox", "Alb", "Zyto-Neumann", "Xios", "Kau", "Rho", "Delpha", "Chu", "Ix", "Neng-Pho",
                    "Bheta", "Zhu", "Lho", "Teppa-Nyxos", "Kor", "Dox", "Sek", "Gryphonne-Reductus", "Tov", "Eq", "Mu", "Rhy", "Dos", "Exitor-Dho", "Fel", "Actus", "Xor",
                    "Decima", "Rax", "Kas"
                },
                Surnames = new[]
                {
                    "-511", "-1111", "-XXVII", "-802", "-323/mk12", "-089", "-744", "-VII", "-18.1", "-656", "-IV", "-110", "-0.43.43", "-97/mk24", "-XIX", "-7", "-110100",
                    "-3.16", "-961.34254", "-MXV", "-99", "-2918", "-888.88", "-404", "-1010", "-0.44//K", "-745", "-66.75/mk98", "-1/1/2", "-99941", "-83.2", "-575",
                    "-79.09/5", "-668.2", "-1/5", "-666/2"
                }
            },
            new Faction
            {
                Type = FactionType.HereticAstartes,
                Name = "Heretic Astartes",
                GenerationType = GenerationType.D10,
                ConcatenationType = ConcatenationType.Space,
                SubFactions = new[]
                {
                    new SubFaction
                    {
                        Type = SubFactionType.BlackLegion,
                        Name = "Black Legion",
                        Forenames = new[]
                        {
                            "Zekyr", "Dreccor", "Sovram", "Thallos", "Zagator", "Korthranus", "Drekva", "Thygmor", "Ashrok", "Azmodial"
                        },
                        Surnames = new[]
                        {
                            "Aximand", "the Vengeful", "Thrice-Cursed", "Korda", "the Black", "Daemonsblade", "Oraka", "Naxos", "the Mad", "Faithslayer"
                        }
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.AlphaLegion,
                        Name = "Alpha Legion",
                        Forenames = new[]
                        {
                            "Kyphax", "Inigo", "Thkeln", "Sylas", "Armilus", "Sheed", "Eskyrx", "Jaego", "Askelitar", "Alpharius"
                        },
                        Surnames = new[]
                        {
                            "Sheyr", "Dynas", "Hertzor", "Ranko", "", "23-7", "Legion", "Phors", "Nul", ""
                        }
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.EmperorsChildren,
                        Name = "Emperor's Children",
                        Forenames = new[]
                        {
                            "Antinius", "Eidelitor", "Ilitoias", "Teloss", "Abdemis", "Fabian", "Julianis", "Abdelis", "Lycon", "Xiander"
                        },
                        Surnames = new[]
                        {
                            "Sellion", "Thest", "Atonian", "Vessatar", "Bericosian", "Xandassus", "Tresell", "Vastorius", "Kanasiar", "the Perfect"
                        }
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.WorldEaters,
                        Name = "World Eaters",
                        Forenames = new[]
                        {
                            "Khargos", "Drakh", "Ashkal", "Gharrax", "Khorgor", "Sorkhos", "Aggravax", "Ashkorh", "Laraskh", "Khaen"
                        },
                        Surnames = new[]
                        {
                            "Skullfiend", "the Reaper", "Khorr", "the Butcher", "the Furious", "Slaughterborn", "Foe Ripper", "the Destroyer", "the Hound", "Thaxxos"
                        }
                    }
                }
            },
            new Faction
            {
                Type = FactionType.DeathGuard,
                Name = "Death Guard",
                GenerationType = GenerationType.D10,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "Gurloch", "Suppurax", "Golchor", "Festamus", "Rancidius", "Mulgh", "Shurgholgh", "Bubox", "Pestus", "Malignus"
                },
                Surnames = new[]
                {
                    "Urghe", "Volghor", "Grulgus", "the Pestilent", "the Reeking", "the Curdled", "Glouch", "Muttermould", "Thrax", "Trudge"
                }
            },
            new Faction
            {
                Type = FactionType.ThousandSons,
                Name = "Thousand Sons",
                GenerationType = GenerationType.D10,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "Phosis", "Amonhep", "Basteq", "Apophitar", "Thotek", "Kalophis", "Phael", "Thotmas", "Imhoden", "Ankhu"
                },
                Surnames = new[]
                {
                    "T'Kor", "Basth", "Takar", "Kallisar", "Rhan", "P'Tra", "Manahkmor", "Shen", "Apophontar", "H'Kett"
                }
            },
            new Faction
            {
                Type = FactionType.Asuryani,
                Name = "Asuryani",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                SubFactions = new[]
                {
                    new SubFaction
                    {
                        Type = SubFactionType.AsuryaniFemale,
                        Name = "Female",
                        Forenames = new[]
                        {
                            "Tenrith", "Justune", "Aleerith", "Yrlla", "Aileer", "Caslith", "Tai'shar", "Jair", "Luirth", "Aleera", "Phyllistra", "Myrnoth",
                            "Fyrram", "Ishylla", "Tishriel", "Aydona", "Galanta", "Ylleth", "Giladrea", "Osinell", "Glenoighi", "Ishta", "Yvraine", "Intrisiel",
                            "Torc", "Anesh", "Kalistri", "Alee", "Altanish", "Gwyth", "Tyrelli", "Kaithe", "Galrethi", "Noithi", "Braesil", "Meari"
                        },
                        Surnames = new[]
                        {
                            "the Fireheart", "Kyldroth", "Tridehla", "Who Walks Alone", "of the Flowing Spirits", "Iydoth", "Brylliel", "Biel-rith", "", "Iyadolath",
                            "Last of the House of the Ayandi", "the Melancholy", "Llacharni", "the Huntress", "Aryimelli", "Bringer of Azure Death", "Umachuli",
                            "Shelwe-hann", "Serenti", "Ullamar", "Dystari", "Ciaradh", "Iyadari", "Flethal", "the  Whisper of Death", "Hanndroth", "Sheersom", "Cegodari",
                            "Ullathani", "Corsikanni", "Yn Farwolloch", "Indomi", "Saim-Ingrelli", "Ysbwrieli", "Morai-fen", "Undomniel"
                        }
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.AsuryaniMale,
                        Name = "Male",
                        Forenames = new[]
                        {
                            "Fachean", "Tarvaril", "Fanani", "Yrmnoch", "Barahir", "Eldrion", "Dis'ar", "Eldos", "Kinshar", "Rhidhal", "Athairnos", "Earandil", "Siriolas",
                            "Bahtaam", "Fian", "Eldroch", "Lorinth", "Illisar", "Ealion", "Elronhir", "Tamishar", "Arenal", "Iradil", "Maur", "Requiel", "Lann", "Yrule",
                            "Ra'thar", "Las'har", "Arision", "Ingfhar", "Senn", "Hal'thar", "Yrion", "Silgar", "Konrith"
                        },
                        Surnames = new[]
                        {
                            "Son of Choheria", "Finarfin", "Eldrion", "the Unyielding Fire", "Glaermril", "Arronas", "Glowach", "the Uncompromising", "of the Noble House of Picarothi",
                            "Enbrondil", "Lladronoth", "Bechareth", "Ceifulgaithann", "Undroll", "Caman", "Toir", "Scion of Rhidmar", "the Wanderer", "of the Clan Randras", "Llmaea-fen",
                            "Rillietar", "Elarique of Alaitoc", "Sydarus Starstrider", "the Implacable", "Ulthos", "Sharnal", "the Deathly Eloquent", "Born of Twilight", "of the Tower of Stars",
                            "Shelwe-nin", "the Undaunted", "Rhianthari", "Eldroneth", "Trithjain", "the Rising Star", "Bhanlhar"
                        }
                    }
                }
            },
            new Faction
            {
                Type = FactionType.Drukhari,
                Name = "Drukhari",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                SubFactions = new[]
                {
                    new SubFaction
                    {
                        Type = SubFactionType.Kabalite,
                        Name = "Kabalite",
                        Forenames = new[]
                        {
                            "Anarkyss", "Veth'va", "Mayator", "Quaez", "Daisan", "Bekliel", "Orvak", "Narlek", "Monsatos", "Vivithrax", "Drevakh", "Kyzarkh",
                            "Thresyn", "Shylas", "Lythric", "Kylos", "Theskril", "Skythe", "Akkhar", "Kharsac", "Nyktos", "Grevyth", "Thraed", "Sykil", "Khaeyl",
                            "Madrax", "Akhirion", "Vypus", "Ethrilliac", "Kheraes", "Iyshak", "Khepres", "Eldoriac", "Vrekkus", "Thayd", "Xurul"
                        },
                        Surnames = new[]
                        {
                            "Sar'sel", "Vorpex", "Kreen", "the Bloodbreather", "Maestros", "Gaarsus", "Ehthrek", "Ghorghast", "Ignyss", "Mohrkhar", "Thresk", "Scaur",
                            "The Pale", "Khadylus", "Phrel", "Vulkriax", "Nul", "the Flenser", "Poisonblade", "Barbtongue", "Xesh", "the Ravening", "Draeven",
                            "of the Obsidian Needle", "Vhrex", "Kaghmyr", "Thrail", "Flickerblade", "Xosh", "the Bleak", "Neverbreath", "Skahyl", "Verkosian",
                            "Ulthurian", "Menesh", "the Cruel"
                        }
                    },
                    new SubFaction
                    {
                        Type = SubFactionType.WychCult,
                        Name = "Wych Cult",
                        Forenames = new[]
                        {
                            "Ariex", "Melikka", "Grenden", "Vaivel", "Bithandrel", "Ingenue", "Demadyme", "Laelanyel", "Excrucia", "Nathra", "Vrexith",
                            "Thyndrella", "Selithrian", "Xela", "Peiythia", "Ulesa", "Skyshrin", "Anielyn", "Vryenik", "Khatryx", "Nyssa", "Phyrix", "Mellyx",
                            "Kherissa", "Tryxin", "Aniellah", "Veshtari", "Morghynn", "Thrixxesh", "Thessa", "Xindrell", "Kladys", "Shemriel", "Lyxanna", "Nimhre", "Vylekh"
                        },
                        Surnames = new[]
                        {
                            "La'flenz", "Wysp", "Soriel", "Oblique", "Nervose", "Mourn", "Vivicon", "Viserhyx", "Berrebaal", "Vulptuse", "Ehlyanna", "Khaur",
                            "Hexehss", "the Crimson", "Thrix", "Khoryssa", "Vexx", "of the Screaming Blade", "Khrygg", "Nichtren", "Veluxis", "the Huntress",
                            "Beastbane", "the Magnificent", "Trehll", "Xyriphraxis", "Masdruvael", "Khrone", "the Untouched", "Bloodslyk", "the Cruel",
                            "Kharavyxis", "Ynthrekh", "Dyvahur", "Krael", "the Bloodsister"
                        }
                    }
                }
            },
            new Faction
            {
                Type = FactionType.Harlequins,
                Name = "Harlequins",
                GenerationType = GenerationType.D10,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "The Sun", "The Star", "The Shadow", "The Void", "The Sky", "The Redtide", "The Moon", "The Highborn", "The Leering", "The Bladed"
                },
                Surnames = new[]
                {
                    "King", "Queen", "Prince", "Knave", "Witch", "Judge", "Executioner", "Seer", "Ghoul", "Crone"
                }
            },
            new Faction
            {
                Type = FactionType.Necrons,
                Name = "Necrons",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "Ankhep", "Tamonhak", "Eknotath", "Khotek", "Thanatar", "Amhut", "Karok", "Zan-Tep", "Unakh", "Khophec", "Tzantath", "Tahar", "Imonekh", "Trazat", "Xeoptar",
                    "Hamanet", "Oberek", "Banatur", "Ahmnok", "Kophesh", "Teznet", "Odahkar", "Kythok", "Eknothet", "Anubitar", "Anokh", "Thotep", "Anhutek", "Ikhatar", "Thotmek",
                    "Ramatek", "Homanat", "Taknophet", "Makhret", "", "Zanatek"
                },
                Surnames = new[]
                {
                    "the Unliving", "the Gilded", "the Great", "the Exalted", "the Loyal", "the Cruel", "the Storm's Eye", "the Bloodied", "the Mighty", "the Relentless",
                    "the Unforgiving", "the Merciless", "the Glorious", "the Devoted", "the Victorious", "the Destroyer", "the Shrouded", "the Flenser", "the Unstoppable",
                    "the Beheader", "the Impaler", "the Magnificent", "the Illuminated", "the Executioner", "the Phaeron's Hand", "the Guardian", "the Gatekeeper",
                    "the All-seeing", "the All-knowing", "the Starwalker", "the Starkiller", "the Lifetaker", "the Godbreaker", "the Torchbearer", "the Stormbringer", "the Colossus"
                }
            },
            new Faction
            {
                Type = FactionType.Orks,
                Name = "Orks",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "Urzog", "Snikrat", "Krogskull", "Gorgrok", "Droknog", "Grodd", "Zogwarp", "Gitzog", "Ruggat", "Zargruk", "Stugbrog", "Snarkrat", "Zagblag", "Bokgrobber", "Zarknutz",
                    "Dhakadak", "Nargrunt", "Farksnot", "Gharagh", "Urlakk", "Zogger", "Slazbag", "Squigface", "Ugul", "Tuska", "Nakboz", "Skarzot", "Kroggler", "Grukk", "Fragbad",
                    "Traknug", "Grizgutz", "Shrokbog", "Kraznag", "Gragnatz", "Blokrotz"
                },
                Surnames = new[]
                {
                    "Drakka", "Grog", "Gitstompa", "Skullcrusha", "Facekrumpa", "the 'Ard", "Grot Kicker", "da Shiv", "", "Blaktoof", "da Hammer", "Ghazbhag", "Steelfang",
                    "Daggafist", "Squigbiter", "da Stompy", "da Facegrinda", "Loudgob", "Facebiter", "da Maniak", "Steelbootz", "Ripblade", "'Umiechewa", "Ironboot",
                    "Flame Spitta", "Wurldkilla", "Stompkrumpa", "Spleenrippa", "Bigfangz", "Badfang", "Snotkicka", "Brewguzzla", "Bonesplitta", "'Eadkrakka", "Madeye", "Trakeye"
                }
            },
            new Faction
            {
                Type = FactionType.Tau,
                Name = "T'au",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Combine,
                Forenames = new[]
                {
                    "Sul'an", "Ho'sen", "Atsumo", "N'ea", "Els'im", "K'yen", "Or'os", "Pashera", "Rais", "Sel'tas", "Be'tol", "E'yaal", "Murakan", "To'jo", "Kurami", "U'so",
                    "Lorresa", "Paluto", "Ren'sa", "Lor'ma", "Tash'lor", "Watana", "Nomura", "Nishuno", "D'tano", "Xo'yima", "T'suka", "Kais", "Shamasa", "Pu'jato", "Ju'yem",
                    "Ga'mo", "Kasashi", "Lamano", "Mi'daro", "Uvash'a"
                },
                Surnames = new[] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
            },
            new Faction
            {
                Type = FactionType.Tyranid,
                Name = "Tyranid",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "The Omega", "The Creeping", "The Crimson", "The Kraken's", "The Leviathan's", "The Behemoth's", "Jormungandr's", "The Serpent's", "The Hydra's",
                    "The Rising", "The Devouring", "The Looming", "The Gorgon's", "The Ravening", "The Kolorian", "The Icharian", "The Writhing", "The Inescapable",
                    "The Dark", "Kronos'", "The Nightmare", "Tiamet's", "The Ominous", "Ouroboris'", "The Ancient", "The Slithering", "The Bladed", "The Monstrous",
                    "The Elder", "The Nameless", "The Hunter's", "The Formless", "The Sudden", "The Void", "The Lurking", "The Hungry"
                },
                Surnames = new[]
                {
                    "Infestation", "Talon", "Fang", "Claw", "Tendril", "Coil", "Eye", "Brood", "Shadow", "Dread", "Swarm", "Barb", "Jaws", "Assassins", "Slayers",
                    "Executioners", "Ghosts", "Echo", "Terrors", "Horrors", "Lurkers", "Heralds", "Sting", "Bite", "Doom", "Buthchers", "Devils", "Wraiths",
                    "Menance", "Shroud", "Annihilators", "Scream", "Pall", "Devourers", "Stalkers", "Maw"
                }
            },
            new Faction
            {
                Type = FactionType.GenestealerCult,
                Name = "Genestealer Cult",
                GenerationType = GenerationType.D66,
                ConcatenationType = ConcatenationType.Space,
                Forenames = new[]
                {
                    "Gannar", "Dhraz", "Yohrick", "Kol", "Hastun", "Sayben", "Hollan", "Narek", "Rauss", "Basc", "Davon", "Zask", "Nasser", "Seimon",
                    "Jacobiah", "Skir", "Ghaskin", "Foyle", "Kreen", "Judh", "Mordecai", "Isaak", "Michon", "Jerec", "Aldren", "Madrax", "Vyrion",
                    "Hollun", "Steen", "Pike", "Mallick", "Groust", "Eldric", "Yorl", "Xandus", "Crasker"
                },
                Surnames = new[]
                {
                    "Druchmann", "Kreel", "Desh", "Cavoria", "Krauss", "Gardlinger", "Zorbech", "Stennvar", "Varnway", "Starn", "Baumgart", "Drisso",
                    "Sammer", "Helm", "Tarnright", "Valka", "Kelbrech", "Kheiser", "Madrach", "Venner", "Novek", "Svodnor", "Black", "Barchus", "Matterzhek",
                    "Onderghast", "Thrace", "Lhaska", "Rezzekh", "Carleon", "Drevender", "Seifer", "Vreel", "Xyben", "Gorl", "Arnalt"
                }
            }
        };

        private static readonly string[] _empty36 =
        {
            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""
        };
    }
}
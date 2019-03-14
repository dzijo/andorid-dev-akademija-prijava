using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkmn
{
    public class Lists
    {
        //public static List<string> megas = new List<string>()
        //{
        //    "Alakazam", "Charizard X", "Garchomp", "Gyarados", "Latias", "Latios", "Lopunny", "Mawile", "Medicham", "Pinsir", "Sableye", "Scizor", "Swampert",
        //    "Tyranitar", "Venusaur", "Charizard Y", "Gallade", "Gardevoir", "Heracross", "Diancie", "Aerodactyl", "Aggron", "Altaria", "Beedrill", "Manectric",
        //    "Pidgeot", "Sceptile", "Sharpedo", "Slowbro", "Absol", "Houndoom", "Ampharos", "Banette", "Blastoise", "Glalie", "Steelix", "Abomasnow", "Audino",
        //    "Camerupt"
        //};
        //public static List<string> OUs = new List<string>()
        //{
        //    "Amoonguss", "Bisharp", "Blacephalon", "Celesteela", "Chansey", "Clefable", "Excadrill", "Ferrothorn", "Garchomp", "Greninja", "Hawlucha", "Heatran",
        //    "Hoopa -U", "Jirachi", "Kartana", "Keldeo", "Kyurem-B", "Landorus-T", "Latios", "Magearna", "Magnezone", "Mamoswine", "Mew", "Mimikyu", "Pelipper", "Rotom-W",
        //    "Skarmory", "Tangrowth", "Tapu Bulu", "Tapu Fini", "Tapu Koko", "Tapu Lele", "Tornadus-T", "Toxapex", "Tyranitar", "Victini", "Volcarona", "Zapdos", "Zygarde",
        //    "Alakazam", "Buzzwole", "Conkeldurr", "Diggersby", "Dragonite", "Gyarados", "Manaphy", "Alolan Ninetales", "Porygon-Z", "Salamence", "Scolipede", "Staraptor", "Thundurus",
        //    "Thundurus-T", "Weavile", "Xurkitree"
        //};
        //public static List<string> UUs = new List<string>()
        //{
        //    "Alomomola", "Arcanine", "Azelf", "Azumarill", "Blissey", "Breloom", "Celebi", "Chandelure", "Cobalion", "Crawdaunt", "Crobat", "Darmanitan", "Empoleon", "Gengar", "Gliscor",
        //    "Haxorus", "Heracross", "Hippowdon", "Hydreigon", "Infernape", "Klefki", "Kommo-o", "Krookodile", "Latias", "Magneton", "Mantine", "Alolan Marowak", "Metagross", "Alolan Muk",
        //    "Nidoking", "Nihilego", "Primarina", "Raikou", "Scizor", "Seismitoad", "Serperior", "Stakataka", "Starmie", "Suicune", "Swampert", "Sylveon", "Tentacruel", "Terrakion",
        //    "Togekiss", "Volcanion", "Entei", "Durant", "Kyurem", "Lucario", "Mienshao", "Reuniclus", "Sharpedo", "Talonflame", "Tornadus", "Venomoth", "Zoroark"
        //};
        //public static List<string> RUs = new List<string>()
        //{
        //    "Aerodactyl", "Araquanid", "Bewear", "Bronzong", "Chesnaught", "Cloyster", "Cresselia", "Decidueye", "Dhelmise", "Donphan", "Doublade", "Dragalge", "Drapion", "Emboar",
        //    "Escavalier", "Espeon", "Feraligatr", "Florges", "Flygon", "Forretress", "Galvantula", "Gardevoir", "Gligar", "Golisopod", "Goodra", "Honchkrow", "Hoopa", "Jolteon",
        //    "Linoone", "Lycanroc-D", "Machamp", "Mandibuzz", "Meloetta", "Milotic", "Moltres", "Necrozma", "Nidoqueen", "Pangoro", "Porygon2", "Quagsire", "Registeel", "Ribombee",
        //    "Roserade", "Rotom-C", "Rhyperior", "Rotom-H", "Salazzle", "Shaymin", "Snorlax", "Swellow", "Umbreon", "Tsareena", "Tyrantrum", "Virizion", "Yanmega", "Zygarde-10%",
        //    "Barbaracle", "Cofagrigus", "Exploud", "Kingdra", "Noivern", "Slurpuff"
        //};
        //public static List<string> NUs = new List<string>()
        //{
        //    "Accelgor", "Altaria", "Ambipom", "Aromatisse", "Blastoise", "Braviary", "Bruxish", "Cinccino", "Clawitzer", "Comfey", "Cryogonal", "Delphox", "Diancie", "Dodrio",
        //    "Druddigon", "Froslass", "Garbodor", "Gigalith", "Golbat", "Guzzlord", "Heliolisk", "Hitmonlee", "Hitmontop", "Houndoom", "Incineroar", "Jellicent", "Klinklang",
        //    "Malamar", "Medicham", "Miltank", "Minior", "Mismagius", "Omastar", "Palossand", "Passimian", "Piloswine", "Qwilfish", "Rhydon", "Rotom (Normal form)", "Sceptile",
        //    "Scrafty", "Scyther", "Sigilyph", "Silvally-Steel", "Slowbro", "Slowking", "Sneasel", "Steelix", "Toxicroak", "Uxie", "Vanilluxe", "Vaporeon", "Venusaur", "Vikavolt",
        //    "Vileplume", "Vivillon", "Whimsicott", "Xatu", "Charizard", "Gallade", "Hariyama", "Sawk", "Tauros", "Typhlosion"
        //};
        //public static List<string> PUs = new List<string>()
        //{
        //    "Abomasnow", "Absol", "Aggron", "Ampharos", "Arbok", "Archeops", "Ariados", "Armaldo", "Articuno", "Audino", "Aurorus", "Avalugg", "Banette", "Basculin", "Bastiodon",
        //    "Beartic", "Beautifly", "Beedrill", "Beheeyem", "Bellossom", "Bibarel", "Bouffalant", "Butterfree", "Cacturne", "Camerupt", "Carbink", "Carnivine", "Carracosta",
        //    "Castform", "Chatot", "Cherrim", "Chimecho", "Claydol", "Clefairy", "Combusken", "Corsola", "Crabominable", "Cradily", "Crustle", "Delcatty", "Delibird", "Dedenne",
        //    "Dewgong", "Ditto", "Drampa", "Drifblim", "Dugtrio", "Alolan Dugtrio", "Dunsparce", "Duosion", "Dusclops", "Dusknoir", "Dustox", "Eelektross", "Electivire", "Electrode",
        //    "Emolga", "Exeggutor", "Alolan Exeggutor", "Farfetch'd", "Fearow", "Ferroseed", "Flareon", "Floatzel", "Furfrou", "Furret", "Gabite", "Gastrodon", "Girafarig", "Glaceon",
        //    "Glalie", "Gogoat", "Golduck", "Golem", "Alolan Golem", "Golurk", "Gorebyss", "Gothitelle", "Gourgeist (all forms)", "Granbull", "Grumpig", "Gumshoos", "Gurdurr",
        //    "Haunter", "Heatmor", "Hitmonchan", "Huntail", "Hypno", "Illumise", "Jumpluff", "Jynx", "Kabutops", "Kadabra", "Kangaskhan", "Kecleon", "Kingler", "Komala", "Kricketune",
        //    "Lanturn", "Lapras", "Leafeon", "Leavanny", "Ledian", "Lickilicky", "Liepard", "Lilligant", "Lopunny", "Ludicolo", "Lumineon", "Lurantis", "Lunatone", "Luvdisc", "Luxray",
        //    "Lycanroc", "Lycanroc-N", "Magcargo", "Magmortar", "Manectric", "Maractus", "Marowak", "Masquerain", "Mawile", "Meganium", "Meowstic (Both Male and Female)", "Mesprit",
        //    "Metang", "Mightyena", "Minun", "Mothim", "Mudsdale", "Mr. Mime", "Muk", "Murkrow", "Musharna", "Ninetales", "Ninjask", "Noctowl", "Octillery", "Oranguru", "Oricorio",
        //    "Oricorio-Pa'u", "Oricorio-Pom-Pom", "Oricorio-Sensu", "Pachirisu", "Parasect", "Persian", "Alolan Persian", "Phione", "Pidgeot", "Pinsir", "Plusle", "Politoed",
        //    "Poliwrath", "Primeape", "Prinplup", "Probopass", "Purugly", "Pyroar", "Pyukumuku", "Qwilfish", "Raichu", "Alolan Raichu", "Rampardos", "Rapidash", "Raticate",
        //    "Alolan Raticate", "Regice", "Regirock", "Regigigas", "Relicanth", "Roselia", "Rotom-F (Freezer form)", "Rotom-S (Fan form)", "Sableye", "Samurott", "Sandslash",
        //    "Alolan Sandslash", "Sawsbuck", "Seaking", "Seviper", "Shedinja", "Shiftry", "Shiinotic", "Shuckle", "Silvally", "Simipour", "Simisage", "Simisear", "Skuntank",
        //    "Slaking", "Smeargle", "Solrock", "Spinda", "Spiritomb", "Stantler", "Stoutland", "Stunfisk", "Sudowoodo", "Sunflora", "Swalot", "Swanna", "Swoobat", "Tangela",
        //    "Throh", "Togedemaru", "Togetic", "Torkoal", "Torterra", "Toucannon", "Trevenant", "Tropius", "Turtonator", "Type: Null", "Unfezant", "Unown", "Ursaring", "Vespiquen",
        //    "Victreebel", "Vigoroth", "Volbeat", "Wailord", "Walrein", "Watchog", "Weezing", "Whiscash", "Wigglytuff", "Wishiwashi", "Wobbuffet", "Wormadam (All Forms)", "Zangoose",
        //    "Zebstrika", "Zweilous"
        //};
        //public static List<string> all = OUs.Concat(UUs).Concat(RUs).Concat(NUs).Concat(PUs).ToList();
        public static List<string> all = new List<string>()
        {
            "Alakazam", "Blissey", "Breloom", "Celebi", "Cloyster", "Conkeldurr",
            "Donphan", "Dragonite", "Dugtrio", "Espeon", "Ferrothorn", "Forretress", "Garchomp", "Gastrodon",
            "Gengar", "Gliscor", "Gyarados", "Haxorus", "Heatran", "Hippowdon", "Hydreigon", "Infernape",
            "Jellicent", "Jirachi", "Jolteon", "Keldeo", "Kyurem-Black", "Landorus-Therian", "Latias",
            "Latios", "Lucario", "Magnezone", "Mamoswine", "Metagross", "Ninetales", "Politoed", "Reuniclus",
            "Rotom-Wash", "Salamence", "Scizor", "Skarmory", "Starmie", "Tentacruel", "Terrakion",
            "Thundurus-Therian", "Toxicroak", "Tyranitar", "Vaporeon", "Venusaur", "Volcarona", "Chandelure",
            "Chansey", "Froslass", "Gothitelle", "Kyurem", "Staraptor", "Victini", "Wobbuffet", "Abomasnow",
            "Ambipom", "Arcanine", "Azelf", "Azumarill", "Bisharp", "Blastoise", "Bronzong", "Claydol",
            "Cobalion", "Cofagrigus", "Crobat", "Darmanitan", "Dusclops", "Empoleon", "Flygon", "Gligar",
            "Heracross", "Hitmontop", "Honchkrow", "Houndoom", "Kingdra", "Krookodile", "Machamp", "Meloetta",
            "Meloetta-Pirouette", "Mew", "Mienshao", "Milotic", "Mismagius", "Nidoking", "Nidoqueen",
            "Porygon-Z", "Porygon2", "Raikou", "Registeel", "Rhyperior", "Roserade", "Rotom-Heat", "Sableye",
            "Scrafty", "Sharpedo", "Shaymin", "Slowbro", "Snorlax", "Suicune", "Swampert", "Togekiss",
            "Tornadus", "Umbreon", "Virizion", "Weavile", "Xatu", "Yanmega", "Zapdos", "Zoroark", "Cresselia",
            "Venomoth", "Absol", "Accelgor", "Aerodactyl", "Aggron", "Amoonguss", "Archeops", "Bouffalant",
            "Cinccino", "Clefable", "Crawdaunt", "Crustle", "Cryogonal", "Drapion", "Druddigon", "Durant",
            "Dusknoir", "Electivire", "Emboar", "Entei", "Escavalier", "Feraligatr", "Ferroseed", "Gallade",
            "Galvantula", "Hariyama", "Hitmonchan", "Hitmonlee", "Kabutops", "Klinklang", "Lanturn", "Lilligant",
            "Magmortar", "Magneton", "Manectric", "Medicham", "Mesprit", "Moltres", "Omastar", "Poliwrath",
            "Quagsire", "Qwilfish", "Rhydon", "Rotom", "Rotom-Mow", "Sandslash", "Sceptile", "Scyther",
            "Sigilyph", "Slowking", "Smeargle", "Spiritomb", "Steelix", "Tangrowth", "Typhlosion", "Uxie",
            "Whimsicott", "Jynx", "Scolipede", "Alomomola", "Altaria", "Ampharos", "Arbok", "Ariados",
            "Armaldo", "Articuno", "Audino", "Banette", "Basculin", "Bastiodon", "Beartic", "Beautifly",
            "Beedrill", "Beheeyem", "Bellossom", "Bibarel", "Braviary", "Bronzor", "Butterfree", "Cacturne",
            "Camerupt", "Carnivine", "Carracosta", "Castform", "Charizard", "Chatot", "Cherrim", "Chimecho",
            "Combusken", "Corsola", "Cradily", "Delcatty", "Delibird", "Dewgong", "Ditto", "Dodrio", "Dragonair",
            "Drifblim", "Dunsparce", "Duosion", "Dustox", "Furret", "Gabite", "Garbodor", "Gardevoir",
            "Gigalith", "Girafarig", "Glaceon", "Glalie", "Golbat", "Golduck", "Golem", "Golurk", "Gorebyss",
            "Gothorita", "Granbull", "Grumpig", "Gurdurr", "Haunter", "Heatmor", "Huntail", "Hypno", "Illumise",
            "Jumpluff", "Kadabra", "Kangaskhan", "Kecleon", "Kingler", "Klang", "Kricketune", "Lairon",
            "Lampent", "Lapras", "Leafeon", "Leavanny", "Ledian", "Dwebble", "Eelektross", "Electabuzz",
            "Electrode", "Emolga", "Exeggutor", "Exploud", "Farfetch'd", "Fearow", "Flareon", "Floatzel",
            "Fraxure", "Frillish", "Lickilicky", "Liepard", "Linoone", "Lopunny", "Ludicolo", "Lumineon",
            "Lunatone", "Luvdisc", "Luxray", "Machoke", "Magcargo", "Magmar", "Mandibuzz", "Mantine", "Maractus",
            "Marowak", "Masquerain", "Mawile", "Meganium", "Metang", "Mightyena", "Miltank", "Minun",
            "Misdreavus", "Mothim", "Mr.Mime", "Muk", "Munchlax", "Murkrow", "Musharna", "Natu", "Ninjask",
            "Noctowl", "Octillery", "Pachirisu", "Parasect", "Pelipper", "Persian", "Phione", "Pidgeot",
            "Pikachu", "Piloswine", "Pineco", "Pinsir", "Plusle", "Primeape", "Probopass", "Purugly", "Raichu",
            "Rampardos", "Rapidash", "Raticate", "Regice", "Regigigas", "Regirock", "Relicanth", "Riolu",
            "Roselia", "Rotom-Fan", "Rotom-Frost", "Samurott", "Sawk", "Sawsbuck", "Scraggy", "Seadra",
            "Seaking", "Seismitoad", "Serperior", "Seviper", "Shedinja", "Shelgon", "Shiftry", "Shuckle",
            "Simipour", "Simisage", "Simisear", "Skuntank", "Slaking", "Sneasel", "Solrock", "Spinda",
            "Stantler", "Stoutland", "Stunfisk", "Sudowoodo", "Sunflora", "Swalot", "Swanna", "Swellow",
            "Swoobat", "Tangela", "Tauros", "Throh", "Togetic", "Torkoal", "Torterra", "Tropius", "Unfezant",
            "Unown", "Ursaring", "Vanilluxe", "Vespiquen", "Victreebel", "Vigoroth", "Vileplume", "Volbeat",
            "Wailord", "Walrein", "Wartortle", "Watchog", "Weezing", "Whiscash", "Wigglytuff", "Wormadam",
            "Wormadam-Sandy", "Wormadam-Trash", "Wynaut", "Zangoose", "Zebstrika"
        };
    }
}

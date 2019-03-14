using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_Fight_Assist.Enums;

namespace DnD_Fight_Assist
{
    class Monsters
    {
        public class SavingThrows
        {
            public int Str { get; set; }
            public int Dex { get; set; }
            public int Con { get; set; }
            public int Int { get; set; }
            public int Wis { get; set; }
            public int Cha { get; set; }
        }
        public class Monster
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int AC { get; set; }
            public int HP { get; set; }
            public SavingThrows SavingThrows { get; set; }
            public List<types> Resistances { get; set; } = new List<types>();
            public List<types> Vulnerabilities { get; set; } = new List<types>();
            public List<types> Immunities { get; set; } = new List<types>();
        }

        public static Monster brassDragonWyrmling = new Monster()
        {
            Name = "Brass Dragon Wyrmling",
            Type = "Medium dragon",
            AC = 16,
            HP = 16,
            SavingThrows = new SavingThrows()
            {
                Str = 2,
                Dex = 2,
                Con = 3,
                Int = 0,
                Wis = 2,
                Cha = 3
            },
            Immunities = new List<types>() { Enums.types.Fire }
        };
        public static Monster brownBear = new Monster()
        {
            Name = "Brown Bear",
            Type = "Large beast",
            AC = 11,
            HP = 34,
            SavingThrows = new SavingThrows()
            {
                Str = 4,
                Dex = 0,
                Con = 3,
                Int = 0,
                Wis = 1,
                Cha = -2
            }
        };
        public static Monster bugbear = new Monster()
        {
            Name = "Bugbear",
            Type = "Medium humanoid (goblinoid)",
            AC = 16,
            HP = 27,
            SavingThrows = new SavingThrows()
            {
                Str = 2,
                Dex = 2,
                Con = 1,
                Int = -1,
                Wis = 0,
                Cha = -1
            }
        };
        public static Monster deathDog = new Monster()
        {
            Name = "Death Dog",
            Type = "Medium monstrosity",
            AC = 12,
            HP = 39,
            SavingThrows = new SavingThrows()
            {
                Str = 2,
                Dex = 2,
                Con = 2,
                Int = -4,
                Wis = 1,
                Cha = -2
            }
        };
        public static Monster direWolf = new Monster()
        {
            Name = "Dire Wolf",
            Type = "Large beast",
            AC = 14,
            HP = 37,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = 2,
                Con = 2,
                Int = -4,
                Wis = 1,
                Cha = -2
            }
        };
        public static Monster gargoyle = new Monster()
        {
            Name = "Gargoyle",
            Type = "Medium elemental",
            AC = 15,
            HP = 52,
            SavingThrows = new SavingThrows()
            {
                Str = 2,
                Dex = 0,
                Con = 3,
                Int = -2,
                Wis = 0,
                Cha = -2
            },
            Immunities = new List<types>() { Enums.types.Poison },
            Resistances = new List<types>() { Enums.types.Bludgeoning, Enums.types.Piercing, Enums.types.Slashing }
        };
        public static Monster ghast = new Monster()
        {
            Name = "Ghast",
            Type = "Medium undead",
            AC = 13,
            HP = 36,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = 3,
                Con = 0,
                Int = 0,
                Wis = 0,
                Cha = -1
            },
            Immunities = new List<types>() { Enums.types.Poison },
            Resistances = new List<types>() { Enums.types.Necrotic }
        };
        public static Monster giantBoar = new Monster()
        {
            Name = "Giant Boar",
            Type = "Large beast",
            AC = 12,
            HP = 42,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = 0,
                Con = 3,
                Int = -4,
                Wis = -2,
                Cha = -3
            }
        };
        public static Monster giantOctopus = new Monster()
        {
            Name = "Giant Octopus",
            Type = "Large beast",
            AC = 11,
            HP = 52,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = 1,
                Con = 1,
                Int = -3,
                Wis = 0,
                Cha = -3
            }
        };
        public static Monster gibberingMouther = new Monster()
        {
            Name = "Gibbering Mouther",
            Type = "Medium aberration",
            AC = 9,
            HP = 67,
            SavingThrows = new SavingThrows()
            {
                Str = 0,
                Dex = -1,
                Con = 3,
                Int = -4,
                Wis = 0,
                Cha = -2
            }
        };
        public static Monster greenDragonWyrmling = new Monster()
        {
            Name = "Green Dragon Wyrmling",
            Type = "Medium dragon",
            AC = 17,
            HP = 38,
            SavingThrows = new SavingThrows()
            {
                Str = 2,
                Dex = 1,
                Con = 1,
                Int = 2,
                Wis = 0,
                Cha = 1
            },
            Immunities = new List<types>() { Enums.types.Poison }
        };
        public static Monster griffon = new Monster()
        {
            Name = "Griffon",
            Type = "Large monstrosity",
            AC = 12,
            HP = 59,
            SavingThrows = new SavingThrows()
            {
                Str = 4,
                Dex = 2,
                Con = 3,
                Int = -4,
                Wis = 1,
                Cha = -1
            }
        };
        public static Monster hunterShark = new Monster()
        {
            Name = "Hunter Shark",
            Type = "Large beast",
            AC = 12,
            HP = 45,
            SavingThrows = new SavingThrows()
            {
                Str = 4,
                Dex = 1,
                Con = 2,
                Int = -5,
                Wis = 0,
                Cha = -3
            }
        };
        public static Monster merrow = new Monster()
        {
            Name = "Merrow",
            Type = "Large monstrosity",
            AC = 13,
            HP = 45,
            SavingThrows = new SavingThrows()
            {
                Str = 4,
                Dex = 0,
                Con = 2,
                Int = -1,
                Wis = 0,
                Cha = -1
            }
        };
        public static Monster minotaurSkeleton = new Monster()
        {
            Name = "Minotaur Skeleton",
            Type = "Large undead",
            AC = 12,
            HP = 67,
            SavingThrows = new SavingThrows()
            {
                Str = 4,
                Dex = 0,
                Con = 2,
                Int = -2,
                Wis = -1,
                Cha = -3
            },
            Immunities = new List<types>() { Enums.types.Poison },
            Vulnerabilities = new List<types>() { Enums.types.Bludgeoning }
        };
        public static Monster ankylosaurus = new Monster()
        {
            Name = "Ankylosaurus",
            Type = "Huge beast",
            AC = 15,
            HP = 68,
            SavingThrows = new SavingThrows()
            {
                Str = 4,
                Dex = 0,
                Con = 2,
                Int = -4,
                Wis = 1,
                Cha = -3
            }
        };
        public static Monster blackPudding = new Monster()
        {
            Name = "Black Pudding",
            Type = "Large ooze",
            AC = 7,
            HP = 85,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = -3,
                Con = 3,
                Int = -5,
                Wis = -2,
                Cha = -5
            },
            Immunities = new List<types>() { Enums.types.Acid, Enums.types.Cold, Enums.types.Lightning, Enums.types.MSlashing }
        };
        public static Monster elephant = new Monster()
        {
            Name = "Elephant",
            Type = "Huge beast",
            AC = 32,
            HP = 76,
            SavingThrows = new SavingThrows()
            {
                Str = 6,
                Dex = -1,
                Con = 3,
                Int = -4,
                Wis = 0,
                Cha = -2
            }
        };
        public static Monster mummy = new Monster()
        {
            Name = "Mummy",
            Type = "Medium undead",
            AC = 11,
            HP = 58,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = -1,
                Con = 2,
                Int = -2,
                Wis = 2,
                Cha = 1
            },
            Immunities = new List<types>() { Enums.types.Necrotic, Enums.types.Poison },
            Vulnerabilities = new List<types>() { Enums.types.Fire },
            Resistances = new List<types>() { Enums.types.Bludgeoning, Enums.types.Piercing, Enums.types.Slashing }
        };
        public static Monster banshee = new Monster()
        {
            Name = "Banshee",
            Type = "Medium undead",
            AC = 12,
            HP = 58,
            SavingThrows = new SavingThrows()
            {
                Str = -5,
                Dex = 2,
                Con = 0,
                Int = 1,
                Wis = 2,
                Cha = 5
            },
            Immunities = new List<types>() { Enums.types.Cold, Enums.types.Necrotic, Enums.types.Poison },
            Resistances = new List<types>() { Enums.types.Acid, Enums.types.Lightning, Enums.types.Thunder, Enums.types.Bludgeoning, Enums.types.Slashing, Enums.types.Piercing }
        };
        public static Monster hellHound = new Monster()
        {
            Name = "Hell Hound",
            Type = "Medium fiend",
            AC = 15,
            HP = 45,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = 1,
                Con = 2,
                Int = -2,
                Wis = 1,
                Cha = -2
            },
            Immunities = new List<types>() { Enums.types.Fire }
        };
        public static Monster wereboar = new Monster()
        {
            Name = "Wereboar",
            Type = "Medium humanoid (human, shapechanger)",
            AC = 10,
            HP = 78,
            SavingThrows = new SavingThrows()
            {
                Str = 3,
                Dex = 0,
                Con = 2,
                Int = 0,
                Wis = 0,
                Cha = -1
            },
            Immunities = new List<types>() { Enums.types.Bludgeoning, Enums.types.Piercing, Enums.types.Slashing }
        };

        public static List<Monster> monsters = new List<Monster>()
        {
            brassDragonWyrmling, brownBear, bugbear, deathDog, direWolf, gargoyle, ghast, giantBoar, giantOctopus, gibberingMouther, greenDragonWyrmling,
            griffon, hunterShark, merrow, minotaurSkeleton, ankylosaurus, blackPudding, elephant, mummy, banshee, hellHound, wereboar
        };
    }
}




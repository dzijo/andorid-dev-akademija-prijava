using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_Fight_Assist.Enums;

namespace DnD_Fight_Assist
{
    class Player
    {
        public class Attack
        {
            public string Name { get; set; }
            public int Range { get; set; }
            public int AttackModifier { get; set; }
            public int DamageModifier { get; set; }
            public types DamageType { get; set; }
            public int DiceType { get; set; }
            public int DiceNumber { get; set; }
            public int CritRange { get; set; } = 20;
        }
        public class Spell
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int AttackSave { get; set; } //0 for attack, numbers in Enums.types for saves
            public int Range { get; set; }
            public types DamageType { get; set; }
            public int DiceType { get; set; }
            public int DiceNumber { get; set; }
            public int DamageModifier { get; set; } = 0;
            public int CritRange { get; set; }
            public double SavedMod { get; set; } = 0.5;
            public bool AlwaysHits { get; set; } = false;
        }
        public class Character
        {
            public string Name { get; set; }
            public List<Attack> Attacks { get; set; } = new List<Attack>();
            public List<Spell> Spells { get; set; } = new List<Spell>();
            public int SpellAttackModifier { get; set; }
            public int SpellSaveDC { get; set; }
        }


        public static Attack shortsword = new Attack()
        {
            Name = "Shortsword",
            Range = 5,
            AttackModifier = 5,
            DamageModifier = 3,
            DamageType = types.Slashing,
            DiceType = 6,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Attack offhandShortsword = new Attack()
        {
            Name = "Offhand Shortsword",
            Range = 5,
            AttackModifier = 5,
            DamageModifier = 0,
            DamageType = types.Slashing,
            DiceType = 6,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Attack boomingBladeRapier = new Attack()
        {
            Name = "Booming Blade Rapier",
            Range = 5,
            AttackModifier = 5,
            DamageModifier = 3,
            DamageType = types.MPiercing,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Attack rapier = new Attack()
        {
            Name = "Rapier",
            Range = 5,
            AttackModifier = 5,
            DamageModifier = 3,
            DamageType = types.Piercing,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Attack quarterstaff = new Attack()
        {
            Name = "Quarterstaff",
            Range = 5,
            AttackModifier = 2,
            DamageModifier = 0,
            DamageType = types.Bludgeoning,
            DiceType = 6,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Attack mace = new Attack()
        {
            Name = "Mace",
            Range = 5,
            AttackModifier = 4,
            DamageModifier = 2,
            DamageType = types.Bludgeoning,
            DiceType = 6,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Attack lightCrossbow = new Attack()
        {
            Name = "Light Crossbow",
            Range = 80,
            AttackModifier = 4,
            DamageModifier = 2,
            DamageType = types.Piercing,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Spell eldrichBlast = new Spell()
        {
            Name = "Eldrich Blast",
            Description = "A beam of crackling energy streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 force damage. The spell creates more than one beam when you reach higher levels: two beams at 5th level, three beams at 11th level, and four beams at 17th level.You can direct the beams at the same target or at different ones.Make a separate attack roll for each beam.",
            AttackSave = 0,
            Range = 120,
            DamageType = Enums.types.Force,
            DiceType = 10,
            DiceNumber = 1,
            DamageModifier = 0,
            CritRange = 20
        };

        public static Spell chilltouch = new Spell()
        {
            Name = "Chill Touch",
            Description = "You create a ghostly, skeletal hand in the space of a creature within range. Make a ranged spell attack against the creature to assail it with the chill of the grave. On a hit, the target takes 1d8 necrotic damage, and it can't regain hit points until the start of your next turn. Until then, the hand clings to the target.If you hit an undead target, it also has disadvantage on attack rolls against you until the end of your next turn.This spell's damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).",
            AttackSave = 0,
            Range = 120,
            DamageType = Enums.types.Necrotic,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Spell rayofFrost = new Spell()
        {
            Name = "Ray of Frost",
            Description = "A frigid beam of blue-white light streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, it takes 1d8 cold damage, and its speed is reduced by 10 feet until the start of your next turn.The spell's damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).",
            AttackSave = 0,
            Range = 60,
            DamageType = Enums.types.Cold,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Spell shockingGrasp = new Spell()
        {
            Name = "Shocking Grasp",
            Description = "Lightning springs from your hand to deliver a shock to a creature you try to touch. Make a melee spell attack against the target. You have advantage on the attack roll if the target is wearing armor made of metal. On a hit, the target takes 1d8 lightning damage, and it can't take reactions until the start of its next turn.The spell's damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).",
            AttackSave = 0,
            Range = 5,
            DamageType = Enums.types.Lightning,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20
        };

        public static Spell frostBite = new Spell()
        {
            Name = "Frostbite",
            Description = "You cause numbing frost to form on one creature that you can see within range. The target must make a Constitution saving throw. On a failed save, the target takes 1d6 cold damage, and it has disadvantage on the next weapon attack roll it makes before the end of its next turn.",
            AttackSave = 3,
            Range = 60,
            DamageType = Enums.types.Cold,
            DiceType = 6,
            DiceNumber = 1,
            CritRange = 20,
            SavedMod = 0
        };

        public static Spell poisonSpray = new Spell()
        {
            Name = "Poison Spray",
            Description = "You extend your hand toward a creature you can see within range and project a puff of noxious gas from your palm. The creature must succeed on a Constitution saving throw or take 1d12 poison damage.This spell's damage increases by 1d12 when you reach 5th level (2d12), 11th level (3d12), and 17th level (4d12).",
            AttackSave = 3,
            Range = 10,
            DamageType = Enums.types.Poison,
            DiceType = 12,
            DiceNumber = 1,
            CritRange = 20,
            SavedMod = 0
        };

        public static Spell sacredFlame = new Spell()
        {
            Name = "Sacred Flame",
            Description = "Flame-like radiance descends on a creature that you can see within range. The target must succeed on a Dexterity saving throw or take 1d8 radiant damage. The target gains no benefit from cover for this saving throw.The spell's damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).",
            AttackSave = 2,
            Range = 60,
            DamageType = Enums.types.Radiant,
            DiceType = 8,
            DiceNumber = 1,
            CritRange = 20,
            SavedMod = 0
        };

        public static Spell burningHands = new Spell()
        {
            Name = "Burning hands",
            Description = "As you hold your hands with thumbs touching and fingers spread, a thin sheet of flames shoots forth from your outstretched fingertips. Each creature in a 15-foot cone must make a Dexterity saving throw. A creature takes 3d6 fire damage on a failed save, or half as much damage on a successful one.The fire ignites any flammable objects in the area that aren't being worn or carried.",
            AttackSave = 2,
            Range = 15,
            DamageType = Enums.types.Fire,
            DiceType = 6,
            DiceNumber = 3,
            CritRange = 20
        };

        public static Spell guidingBolt = new Spell()
        {
            Name = "Guiding Bolt",
            Description = "A flash of light streaks toward a creature of your choice within range. Make a ranged spell attack against the target. On a hit, the target takes 4d6 radiant damage, and the next attack roll made against this target before the end of your next turn has advantage, thanks to the mystical dim light glittering on the target until then.",
            AttackSave = 0,
            Range = 120,
            DamageType = Enums.types.Radiant,
            DiceType = 6,
            DiceNumber = 4,
            CritRange = 20
        };

        public static Spell magicMissile = new Spell()
        {
            Name = "Magic Missile",
            Description = "You create three glowing darts of magical force. Each dart hits a creature of your choice that you can see within range. A dart deals 1d4 + 1 force damage to its target. The darts all strike simultaneously, and you can direct them to hit one creature or several.",
            AttackSave = 0,
            DamageModifier = 1,
            Range = 120,
            DamageType = Enums.types.Force,
            DiceType = 4,
            DiceNumber = 1,
            CritRange = 20,
            AlwaysHits = true
        };

        public static Spell scorchingRay = new Spell()
        {
            Name = "Scorching Ray",
            Description = "You create three fire rays. You can hurl them at one target or several. Make a ranged spell attack for each ray. On a hit, the target takes 2d6 fire damage.",
            AttackSave = 0,
            Range = 120,
            DamageType = Enums.types.Fire,
            DiceType = 6,
            DiceNumber = 2,
            CritRange = 20
        };

        public static Character Maylee = new Character()
        {
            Name = "Maylee the Rogue",
            Attacks = new List<Attack>() { rapier, boomingBladeRapier, shortsword, offhandShortsword },
            Spells = new List<Spell>() { scorchingRay },
            SpellAttackModifier = 4,
            SpellSaveDC = 12
        };

        public static Character Johny = new Character()
        {
            Name = "Johny the Wizard",
            Attacks = new List<Attack>() { quarterstaff },
            Spells = new List<Spell>() { chilltouch, poisonSpray, burningHands, magicMissile },
            SpellAttackModifier = 5,
            SpellSaveDC = 13
        };

        public static Character Izilgor = new Character()
        {
            Name = "Izilgor the Cleric",
            Attacks = new List<Attack>() { mace },
            Spells = new List<Spell>() { sacredFlame, guidingBolt },
            SpellAttackModifier = 6,
            SpellSaveDC = 14
        };

        public static Character Esper = new Character()
        {
            Name = "Esper the Sorcerer",
            Attacks = new List<Attack>() { lightCrossbow },
            Spells = new List<Spell>() { shockingGrasp, frostBite, scorchingRay, magicMissile },
            SpellAttackModifier = 5,
            SpellSaveDC = 12
        };

        public static List<Character> characters = new List<Character>()
        {
            Maylee, Johny, Izilgor, Esper
        };
    }
}

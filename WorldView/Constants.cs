﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MoreTerra
{
    public class Constants
    {
		public const Int32 currentVersion = 12;
        /// <summary>
        /// List of Credits
        /// </summary>
        public const string Credits = @"TJChap2840, Vib Rib, Infinite Monkeys, Dr VideoGames 0031, Musluk, Sanktanglia, Metamorf.";
                                       

        public const int WallOffset = 268;

        /// <summary>
        /// Maximum Number of Items a Chest Can Contain
        /// </summary>
        public const int ChestMaxItems = 20;

        /// <summary>
        /// Maximum number of chests per world.
        /// </summary>
        public const int ChestMaxNumber = 1000;

		/// <summary>
		/// Maximum number of signs per world.
		/// </summary>
		public const Int32 SignMaxNumber = 1000;

		/// <summary>
		/// Maximum length of the text on a sign.  There is no limit in game I can find but this
		/// beats trying to go all the way to 16k
		/// </summary>
		public const Int32 SignMaxSize = 1500;

        /// <summary>
        /// Points to the root directory for MoreTerra
        /// </summary>
        public static string ApplicationRootDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MoreTerra");

        /// <summary>
        /// Points to the application log directory
        /// </summary>
        public static string ApplicationLogDirectory = System.IO.Path.Combine(ApplicationRootDirectory, "Logs");
        public static string ApplicationResourceDirectory = System.IO.Path.Combine(ApplicationRootDirectory, "Resources");

        public static string ApplicationUserSettingsFile = System.IO.Path.Combine(ApplicationRootDirectory, "UserSettings.xml");

		public static string[] ObjectSymbols = { "Altar", "Chest", "Heart", "Hellforge", "ShadowOrb", "Sign" };
		public static string[] GemSymbols = {"Amethyst", "Diamond", "Emerald", "Ruby", "Sapphire", "Topaz"};
		public static string[] OreSymbols = { "Copper", "Iron", "Silver", "Gold", "Demonite", "Obsidian", "Meteorite", "Hellstone" };
		public static string[] PeopleSymbols = { "ArmsDealer", "Clothier", "Demolitionist", "Dryad", "Guide", "Merchant", "Nurse", "OldMan", "Spawn" };
		public static string[] ExternalSymbolNames = { };

		public static string[] NPCList = {"Arms Dealer", "Clothier", "Demolitionist", "Dryad", "Guide", "Merchant", "Nurse", "Old Man"};

		public static string[] OldProgramNames = { "TerrariaWorldViewer", "MoreTerrra" };

		public static Dictionary<String, String[]> SymbolDict;

		public static void Initialize()
		{
			SymbolDict = new Dictionary<String, String[]>();

			SymbolDict.Add("Objects", ObjectSymbols);
			SymbolDict.Add("Gems", GemSymbols);
			SymbolDict.Add("Ores", OreSymbols);
			SymbolDict.Add("People", PeopleSymbols);

			Int32 i = 0;
			i += ObjectSymbols.Length;
			i += GemSymbols.Length;
			i += OreSymbols.Length;
			i += PeopleSymbols.Length;

			ExternalSymbolNames = new string[i];

			i = 0;
			ObjectSymbols.CopyTo(ExternalSymbolNames, i);
			i += ObjectSymbols.Length;

			GemSymbols.CopyTo(ExternalSymbolNames, i);
			i += GemSymbols.Length;

			OreSymbols.CopyTo(ExternalSymbolNames, i);
			i += OreSymbols.Length;

			PeopleSymbols.CopyTo(ExternalSymbolNames, i);
			i += PeopleSymbols.Length;
		}

		public static string[] defaultItems = {"Aglet",
								  "Angel Statue",
								  "Anklet of the Wind",
								  "Aqua Scepter",
								  "Archery Potion",
								  "Band of Regeneration",
								  "Battle Potion",
								  "Blowpipe",
								  "Blue Moon",
								  "Bomb",
								  "Bottle",
								  "Breathing Reed",
								  "Cloud in a Bottle",
								  "Cobalt Shield",
								  "Copper Bar",
								  "Dark Lance",
								  "Dynamite",
								  "Enchanted Boomerang",
								  "Featherfall Potion",
								  "Feral Claws",
								  "Flaming Arrow",
								  "Flipper", 
								  "Gills Potion",
								  "Glowstick",
								  "Gold Bar",
								  "Gold Coin",
								  "Gravitation Potion",
								  "Grenade",
								  "Handgun",
								  "Healing Potion",
								  "Hellfire Arrow",
								  "Hermes Boots",
								  "Hunter Potion",
								  "Invisibility Potion",
								  "Iron Bar",
								  "Ironskin Potion",
								  "Jester's Arrow",
								  "Lesser Healing Potion",
								  "Lesser Restoration Potion",
								  "Lucky Horseshoe",
								  "Magic Mirror",
								  "Magic Missile",
								  "Magic Power Potion",
								  "Mana Regeneration Potion",
								  "Meteorite Bar",
								  "Muramasa",
								  "Nature's Gift",
								  "Night Owl Potion",
								  "Obsidian Skin Potion",
								  "Regeneration Potion",
								  "Restoration Potion",
								  "Shine Potion",
								  "Shiny Red Balloon",
								  "Shuriken",
								  "Silver Bar",
								  "Silver Bullet",
								  "Silver Coin",
								  "Spear",
								  "Spelunker Potion",
								  "Staff of Regrowth",
								  "Starfury",
								  "Swiftness Potion",
								  "Thorns Potion",
								  "Throwing Knife",
								  "Torch",
								  "Water Walking Potion",
								  "Wooden Arrow",
								  "Wooden Boomerang"};

        // COLOR CONSTANTS

        public static class Colors
        {
            public static Color DIRT = Color.FromArgb(175, 131, 101);
            public static Color STONE = Color.FromArgb(128, 128, 128);
            public static Color GRASS = Color.FromArgb(28, 216, 94);
            public static Color PLANTS = Color.FromArgb(13, 101, 36);
            public static Color LIGHT_SOURCE = Color.FromArgb(253, 62, 3);
            public static Color IRON = Color.FromArgb(189, 159, 139);
            public static Color COPPER = Color.FromArgb(255, 149, 50);
            public static Color GOLD = Color.FromArgb(185, 164, 23);
            public static Color WOOD = Color.FromArgb(86, 62, 44);
            public static Color WOOD_BLOCK = Color.FromArgb(168, 121, 87);
            public static Color SILVER = Color.FromArgb(217, 223, 223);
            public static Color DECORATIVE = Color.FromArgb(0, 255, 242);
            public static Color IMPORTANT = Color.FromArgb(255, 0, 0);
            public static Color DEMONITE = Color.FromArgb(98, 95, 167);
            public static Color CORRUPTION_GRASS = Color.FromArgb(141, 137, 223);
            public static Color EBONSTONE = Color.FromArgb(75, 74, 130);
            public static Color CORRUPTION_VINES = Color.FromArgb(122, 97, 143);
            public static Color BLOCK = Color.FromArgb(178, 0, 255);
            public static Color METEORITE = Color.Magenta;//Color.FromArgb(223, 159, 137);
            public static Color CLAY = Color.FromArgb(216, 115, 101);
            public static Color DUNGEON_GREEN = Color.FromArgb(26, 136, 34);
            public static Color DUNGEON_PINK = Color.FromArgb(169, 49, 117);
            public static Color DUNGEON_BLUE = Color.FromArgb(66, 69, 194);
            public static Color SPIKES = Color.FromArgb(109, 109, 109);
            public static Color WEB = Color.FromArgb(255, 255, 255);
            public static Color SAND = Color.FromArgb(255, 218, 56);
            public static Color OBSIDIAN = Color.FromArgb(87, 81, 173);
            public static Color ASH = Color.FromArgb(68, 68, 76);
            public static Color HELLSTONE = Color.FromArgb(102, 34, 34);
            public static Color MUD = Color.FromArgb(92, 68, 73);
            public static Color UNDERGROUNDJUNGLE_GRASS = Color.FromArgb(143, 215, 29);
            public static Color UNDERGROUNDJUNGLE_PLANTS = Color.FromArgb(143, 215, 29);
            public static Color UNDERGROUNDJUNGLE_VINES = Color.FromArgb(138, 206, 28);
            public static Color UNDERGROUNDJUNGLE_THORNS = Color.FromArgb(94, 48, 55);
            public static Color GEMS = Color.FromArgb(42, 130, 250);

            public static Color CACTUS = Color.DarkGreen;
            public static Color CORAL = Color.LightPink;
            public static Color HERB = Color.OliveDrab;
            public static Color TOMBSTONE = Color.DimGray;


            public static Color UNDERGROUNDMUSHROOM_GRASS = Color.FromArgb(93, 127, 255);
            public static Color UNDERGROUNDMUSHROOM_PLANTS = Color.FromArgb(177, 174, 131);
            public static Color UNDERGROUNDMUSHROOM_TREES = Color.FromArgb(150, 143, 110);

            public static Color LAVA = Color.FromArgb(255, 72, 0);
            public static Color WATER = Color.FromArgb(0, 12, 255);
            public static Color SKY = Color.FromArgb(155, 209, 255);
            public static Color WALL_STONE = Color.FromArgb(66, 66, 66);
            public static Color WALL_DIRT = Color.FromArgb(88, 61, 46);
            public static Color WALL_STONE2 = Color.FromArgb(61, 58, 78);
            public static Color WALL_WOOD = Color.FromArgb(73, 51, 36);
            public static Color WALL_BRICK = Color.FromArgb(60, 60, 60);
            public static Color WALL_BACKGROUND = Color.FromArgb(50, 50, 60);
            public static Color WALL_DUNGEON_PINK = Color.FromArgb(84, 25, 60);
            public static Color WALL_DUNGEON_BLUE = Color.FromArgb(29, 31, 72);
            public static Color WALL_DUNGEON_GREEN = Color.FromArgb(14, 68, 16);
            public static Color UNKNOWN = Color.Magenta;
        }

        /// <summary>
        /// Cell Types Defintions For Enums
        /// </summary>
        public enum CellType
        {
            Air,
            Tile,
            Wall,
            Water,
            Lava,
            Unknown,
        }
    }
}

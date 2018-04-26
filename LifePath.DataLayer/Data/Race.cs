using System.Collections.Generic;
using System.Collections.ObjectModel;
using LifePath.Common.Entities;

namespace LifePath.DataLayer
{
    public static partial class Data
    {
        public static ReadOnlyCollection<Race> Races = new ReadOnlyCollection<Race>(new List<Race>()
        {
            new Race(0, "Aarakocra", null, new List<Asi> { new Asi(2, 2), new Asi(5, 1) }, new Race.Maturity(1, 3, 8, 15, 20, 25, 30), "Elemental Evil"),
            
            new Race(1, "Variant Aasimar", Race.Main.Aasimar, new List<Asi> { new Asi(6, 2), new Asi(5, 1) }, new Race.Maturity(13, 20, 35, 56, 78, 93, 120), "Dungeon Master's Guide"),
            new Race(2, "Protector Aasimar", Race.Main.Aasimar, new List<Asi> { new Asi(6, 2), new Asi(5, 1) }, new Race.Maturity(13, 20, 40, 65, 90, 125, 160), "Volo's Guide to Monsters"),
            new Race(3, "Scourge Aasimar", Race.Main.Aasimar, new List<Asi> { new Asi(6, 2), new Asi(3, 1) }, new Race.Maturity(13, 20, 40, 65, 90, 125, 160), "Volo's Guide to Monsters"),
            new Race(4, "Fallen Aasimar", Race.Main.Aasimar, new List<Asi> { new Asi(6, 2), new Asi(1, 1) }, new Race.Maturity(13, 20, 40, 65, 90, 125, 160), "Volo's Guide to Monsters"),

            new Race(5, "Bugbear", null, new List<Asi> { new Asi(1, 2), new Asi(2, 1) }, new Race.Maturity(8, 16, 27, 42, 58, 70, 80), "Volo's Guide to Monsters"),

            new Race(6, "Dragonborn", null, new List<Asi> { new Asi(1, 2), new Asi(6, 1) }, new Race.Maturity(5, 15, 25, 40, 57, 69, 80), "Player's Handbook"),
            
            new Race(7, "Hill Dwarf", Race.Main.Dwarf, new List<Asi> { new Asi(3, 2), new Asi(5, 1) }, new Race.Maturity(13, 25, 50, 125, 190, 265, 350), "Player's Handbook"),
            new Race(8, "Mountain Dwarf", Race.Main.Dwarf, new List<Asi> { new Asi(3, 2), new Asi(1, 2) }, new Race.Maturity(13, 25, 50, 125, 190, 265, 350), "Player's Handbook"),
            new Race(9, "Duergar", Race.Main.Dwarf, new List<Asi> { new Asi(3, 2), new Asi(1, 1) }, new Race.Maturity(13, 25, 50, 125, 190, 265, 350), "Sword Coast Adventurer's Guide"),
            
            new Race(10, "High Elf", Race.Main.Elf, new List<Asi> { new Asi(2, 2), new Asi(4, 1) }, new Race.Maturity(13, 30, 100, 270, 400, 550, 750), "Player's Handbook"),
            new Race(11, "Wood Elf", Race.Main.Elf, new List<Asi> { new Asi(2, 2), new Asi(5, 1) }, new Race.Maturity(13, 30, 100, 270, 400, 550, 750), "Player's Handbook"),
            new Race(12, "Drow", Race.Main.Elf, new List<Asi> { new Asi(2, 2), new Asi(6, 1) }, new Race.Maturity(13, 30, 100, 270, 400, 550, 750), "Player's Handbook"),
            new Race(13, "Eladrin", Race.Main.Elf, new List<Asi> { new Asi(2, 2), new Asi(4, 1) }, new Race.Maturity(13, 30, 100, 270, 400, 550, 750), "Dungeon Master's Guide"),

            new Race(14, "Firbolg", null, new List<Asi> { new Asi(5, 2), new Asi(1, 1) }, new Race.Maturity(18, 30, 100, 210, 310, 410, 500), "Volo's Guide to Monsters"),
            
            new Race(15, "Air Genasi", Race.Main.Genasi, new List<Asi> { new Asi(3, 2), new Asi(2, 1) }, new Race.Maturity(13, 20, 35, 56, 78, 93, 120), "Elemental Evil"),
            new Race(16, "Earth Genasi", Race.Main.Genasi, new List<Asi> { new Asi(3, 2), new Asi(1, 1) }, new Race.Maturity(13, 20, 35, 56, 78, 93, 120), "Elemental Evil"),
            new Race(17, "Fire Genasi", Race.Main.Genasi, new List<Asi> { new Asi(3, 2), new Asi(4, 1) }, new Race.Maturity(13, 20, 35, 56, 78, 93, 120), "Elemental Evil"),
            new Race(18, "Water Genasi", Race.Main.Genasi, new List<Asi> { new Asi(3, 2), new Asi(5, 1) }, new Race.Maturity(13, 20, 35, 56, 78, 93, 120), "Elemental Evil"),
            
            new Race(19, "Forest Gnome", Race.Main.Gnome, new List<Asi> { new Asi(4, 2), new Asi(2, 1) }, new Race.Maturity(13, 20, 55, 185, 290, 375, 460), "Player's Handbook"),
            new Race(20, "Rock Gnome", Race.Main.Gnome, new List<Asi> { new Asi(4, 2), new Asi(3, 1) }, new Race.Maturity(13, 20, 55, 185, 290, 375, 460), "Player's Handbook"),
            new Race(21, "Deep Gnome", Race.Main.Gnome, new List<Asi> { new Asi(4, 2), new Asi(2, 1) }, new Race.Maturity(13, 20, 55, 185, 290, 375, 460), "Sword Coast Adventurer's Guide"),

            new Race(22, "Goblin", null, new List<Asi> { new Asi(2, 2), new Asi(3, 1) }, new Race.Maturity(4, 8, 18, 30, 40, 50, 60), "Volo's Guide to Monsters"),

            new Race(23, "Goliath", null, new List<Asi> { new Asi(1, 2), new Asi(3, 1) }, new Race.Maturity(11, 18, 29, 48, 68, 82, 100), "Elemental Evil and Volo's Guide to Monsters"),
            
            new Race(24, "Lightfoot Halfling", Race.Main.Halfling, new List<Asi> { new Asi(2, 2), new Asi(6, 1) }, new Race.Maturity(13, 20, 40, 60, 85, 120, 150), "Player's Handbook"),
            new Race(25, "Stout Halfling", Race.Main.Halfling, new List<Asi> { new Asi(2, 2), new Asi(3, 1) }, new Race.Maturity(13, 20, 40, 60, 85, 120, 150), "Player's Handbook"),
            new Race(26, "Ghostwise Halfling", Race.Main.Halfling, new List<Asi> { new Asi(2, 2), new Asi(5, 1) }, new Race.Maturity(13, 20, 40, 60, 85, 120, 150), "Sword Coast Adventurer's Guide"),

            new Race(27, "Half-Elf", null, new List<Asi> { new Asi(6, 2), new Asi(Ability.Any, 1), new Asi(Ability.Any, 1) }, new Race.Maturity(13, 20, 50, 80, 115, 150, 190), "Player's Handbook"),

            new Race(28, "Half-Orc", null, new List<Asi> { new Asi(1, 2), new Asi(3, 1) }, new Race.Maturity(8, 14, 24, 38, 52, 64, 75), "Player's Handbook"),

            new Race(29, "Hobgoblin", null, new List<Asi> { new Asi(3, 2), new Asi(4, 1) }, new Race.Maturity(13, 20, 30, 45, 60, 75, 100), "Volo's Guide to Monsters"),
            
            new Race(30, "Standard Human", Race.Main.Human, new List<Asi> { new Asi(1, 1), new Asi(2, 1), new Asi(3, 1), new Asi(4, 1), new Asi(5, 1), new Asi(6, 1) }, new Race.Maturity(13, 20, 30, 45, 60, 75, 100), "Player's Handbook"),
            new Race(31, "Variant Human", Race.Main.Human, new List<Asi> { new Asi(Ability.Any, 1), new Asi(Ability.Any, 1) }, new Race.Maturity(13, 20, 30, 45, 60, 75, 100), "Player's Handbook"),

            new Race(32, "Kenku", null, new List<Asi> { new Asi(2, 2), new Asi(5, 1) }, new Race.Maturity(6, 12, 20, 34, 42, 50, 60), "Volo's Guide to Monsters"),

            new Race(33, "Kobold", null, new List<Asi> { new Asi(2, 2), new Asi(1, -2) }, new Race.Maturity(3, 6, 25, 50, 75, 95, 120), "Volo's Guide to Monsters"),

            new Race(34, "Lizardfolk", null, new List<Asi> { new Asi(3, 2), new Asi(5, 1) }, new Race.Maturity(5, 14, 25, 36, 45, 52, 60), "Volo's Guide to Monsters"),

            new Race(35, "Orc", null, new List<Asi> { new Asi(1, 2), new Asi(3, 1), new Asi(4, -2) }, new Race.Maturity(5, 12, 22, 32, 38, 44, 50), "Volo's Guide to Monsters"),

            new Race(36, "Tabaxi", null, new List<Asi> { new Asi(2, 2), new Asi(6, 1) }, new Race.Maturity(13, 20, 30, 45, 60, 75, 100), "Volo's Guide to Monsters"),
            
            new Race(37, "Standard Tiefling", Race.Main.Tiefling, new List<Asi> { new Asi(6, 2), new Asi(4, 1) }, new Race.Maturity(13, 20, 34, 52, 72, 95, 125), "Player's Handbook"),
            new Race(38, "Variant Tiefling", Race.Main.Tiefling, new List<Asi> { new Asi(6, 2), new Asi(4, 1) }, new Race.Maturity(13, 20, 34, 52, 72, 95, 125), "Sword Coast Adventurer's Guide"),
            new Race(39, "Feral Tiefling", Race.Main.Tiefling, new List<Asi> { new Asi(2, 2), new Asi(4, 1) }, new Race.Maturity(13, 20, 34, 52, 72, 95, 125), "Sword Coast Adventurer's Guide"),

            new Race(40, "Triton", null, new List<Asi> { new Asi(1, 1), new Asi(3, 1), new Asi(6, 1) }, new Race.Maturity(9, 15, 36, 75, 110, 155, 200), "Volo's Guide to Monsters"),

            new Race(41, "Yuan-Ti Pureblood", null, new List<Asi> { new Asi(6, 2), new Asi(4, 1) }, new Race.Maturity(13, 20, 30, 45, 60, 75, 100), "Volo's Guide to Monsters"),
        });
    }
}

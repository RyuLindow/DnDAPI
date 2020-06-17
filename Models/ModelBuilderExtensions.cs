using Microsoft.EntityFrameworkCore;

namespace QuickAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasData(
                new Class { Id = 1, Class_name = "Barbarian" },
                new Class { Id = 2, Class_name = "Bard" },
                new Class { Id = 3, Class_name = "Cleric" },
                new Class { Id = 4, Class_name = "Druid" },
                new Class { Id = 5, Class_name = "Fighter" },
                new Class { Id = 6, Class_name = "Monk" },
                new Class { Id = 7, Class_name = "Paladin" },
                new Class { Id = 8, Class_name = "Ranger" },
                new Class { Id = 9, Class_name = "Rogue" },
                new Class { Id = 10, Class_name = "Sorcerer" },
                new Class { Id = 11, Class_name = "Warlock" },
                new Class { Id = 12, Class_name = "Wizard" });


            modelBuilder.Entity<Monster>().HasData(
                new Monster { Id = 1, TypeId = 1, Name = "Ancient Red Dragon", Challenge_rating = 24, Alignment = "chaotic evil" },
                new Monster { Id = 2, TypeId = 1, Name = "Adult Black Dragon", Challenge_rating = 14, Alignment = "chaotic evil" },
                new Monster { Id = 3, TypeId = 2, Name = "Ghost", Challenge_rating = 12, Alignment = "any alignment" },
                new Monster { Id = 4, TypeId = 2, Name = "Banshee", Challenge_rating = 16, Alignment = "any alignment" },
                new Monster { Id = 5, TypeId = 3, Name = "Flower Fairy", Challenge_rating = 6, Alignment = "neutral good" },
                new Monster { Id = 6, TypeId = 3, Name = "Arcane Fairy", Challenge_rating = 9, Alignment = "chaotic neutral" },
                new Monster { Id = 7, TypeId = 4, Name = "Erinyes", Challenge_rating = 18, Alignment = "chaotic evil" },
                new Monster { Id = 8, TypeId = 4, Name = "Bone devil", Challenge_rating = 16, Alignment = "chaotic evil" },
                new Monster { Id = 9, TypeId = 5, Name = "Kraken", Challenge_rating = 27, Alignment = "chaotic evil" },
                new Monster { Id = 10, TypeId = 5, Name = "Manticore", Challenge_rating = 17, Alignment = "chaotic neutral" },
                new Monster { Id = 11, TypeId = 6, Name = "Thug", Challenge_rating = 7, Alignment = "neutral evil" },
                new Monster { Id = 12, TypeId = 6, Name = "Dryad", Challenge_rating = 15, Alignment = "lawful neutral" });

            modelBuilder.Entity<Stats>().HasData(
                new Stats { Id = 1, Strength = 25, Dexterity = 23, Constitution = 27, Intelligence = 18, Wisdom = 19, Charisma = 21 },
                new Stats { Id = 2, Strength = 7, Dexterity = 16, Constitution = 17, Intelligence = 14, Wisdom = 21, Charisma = 14 },
                new Stats { Id = 3, Strength = 12, Dexterity = 13, Constitution = 21, Intelligence = 16, Wisdom = 15, Charisma = 10 },
                new Stats { Id = 4, Strength = 16, Dexterity = 12, Constitution = 13, Intelligence = 11, Wisdom = 19, Charisma = 9 },
                new Stats { Id = 5, Strength = 19, Dexterity = 18, Constitution = 18, Intelligence = 12, Wisdom = 8, Charisma = 7 },
                new Stats { Id = 6, Strength = 15, Dexterity = 16, Constitution = 12, Intelligence = 14, Wisdom = 11, Charisma = 18 });

            modelBuilder.Entity<Types>().HasData(
                new Types { Id = 1, Type = "Dragon" },
                new Types { Id = 2, Type = "Ghost" },
                new Types { Id = 3, Type = "Fairy" },
                new Types { Id = 4, Type = "Demon" },
                new Types { Id = 5, Type = "Monstrosity" },
                new Types { Id = 6, Type = "Humanoid" });
        }
    }
}

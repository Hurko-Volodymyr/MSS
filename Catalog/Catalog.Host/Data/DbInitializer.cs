using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data;

public static class DbInitializer
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();

        if (!context.CatalogWeapons.Any())
        {
            await context.CatalogWeapons.AddRangeAsync(GetPreconfiguredCatalogBrands());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogRarities.Any())
        {
            await context.CatalogRarities.AddRangeAsync(GetPreconfiguredCatalogTypes());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogItems.Any())
        {
            await context.CatalogItems.AddRangeAsync(GetPreconfiguredItems());

            await context.SaveChangesAsync();
        }
    }

    private static IEnumerable<CatalogWeapon> GetPreconfiguredCatalogBrands()
    {
        return new List<CatalogWeapon>()
        {
            new CatalogWeapon() { Weapon = "Spear" },
            new CatalogWeapon() { Weapon = "Claymor" },
            new CatalogWeapon() { Weapon = "Sword" },
            new CatalogWeapon() { Weapon = "Catalyst" },
            new CatalogWeapon() { Weapon = "Bow" },
        };
    }

    private static IEnumerable<CatalogRarity> GetPreconfiguredCatalogTypes()
    {
        return new List<CatalogRarity>()
        {
            new CatalogRarity() { Rarity = "4*" },
            new CatalogRarity() { Rarity = "5*" }
        };
    }

    private static IEnumerable<CatalogCharacterItem> GetPreconfiguredItems()
    {
        return new List<CatalogCharacterItem>()
        {
            new CatalogCharacterItem { CatalogRarityId = 2, CatalogWeaponId = 1, Name = "Kamysato Ayaka", Region = "Inazuma", Birthday = "28.09", PictureFileName = "https://static.wikia.nocookie.net/gensin-impact/images/d/d0/Character_Kamisato_Ayaka_Full_Wish.png/revision/latest/scale-to-width-down/1000?cb=20221014024207" },
        };
    }
}
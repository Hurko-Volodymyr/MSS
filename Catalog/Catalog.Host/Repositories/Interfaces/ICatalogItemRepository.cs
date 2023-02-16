using Catalog.Host.Data;
using Catalog.Host.Data.Entities;

namespace Catalog.Host.Repositories.Interfaces;

public interface ICatalogItemRepository
{
    Task<PaginatedItems<CatalogCharacterItem>> GetByPageAsync(int pageIndex, int pageSize, int? weaponFilter, int? rarityFilter);
    Task<int?> Add(string name, string region, string birthday, int catalogWeaponId, int catalogRarityId, string pictureFile);
    Task<PaginatedItems<CatalogCharacterItem>> GetByRarityAsync(string rarity);
    Task<PaginatedItems<CatalogCharacterItem>> GetByWeaponAsync(string weapon);
    Task<CatalogCharacterItem?> GetByIdAsync(int id);
    Task<bool> UpdateAsync(int id, string name, string region, string birthday, int catalogRarityId, int catalogWeaponId, string pictureFile);
    Task<bool> DeleteAsync(int id);
}
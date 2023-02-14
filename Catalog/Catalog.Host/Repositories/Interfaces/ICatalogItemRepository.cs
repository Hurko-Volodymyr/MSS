using Catalog.Host.Data;
using Catalog.Host.Data.Entities;

namespace Catalog.Host.Repositories.Interfaces;

public interface ICatalogItemRepository
{
    Task<PaginatedItems<CatalogCharacterItem>> GetByPageAsync(int pageIndex, int pageSize, int? weaponFilter, int? rarityFilter);
    Task<int?> Add(string name, string region, string birthday, int catalogWeaponId, int catalogRarityId, string pictureFileName);
}
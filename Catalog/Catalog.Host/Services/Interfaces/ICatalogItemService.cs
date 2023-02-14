namespace Catalog.Host.Services.Interfaces;

public interface ICatalogItemService
{
    Task<int?> AddAsync(string name, string region, string birthday, int catalogWeaponId, int catalogRarityId, string pictureFileName);
}
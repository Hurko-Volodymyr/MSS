using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Models.Requests;

public class CreateProductRequest
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string Birthday { get; set; } = null!;

    public string PictureUrl { get; set; } = null!;

    public int CatalogWeaponId { get; set; }

    public int CatalogRarityId { get; set; }
}
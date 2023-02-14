namespace Catalog.Host.Controllers;

[ApiController]
[Route(ComponentDefaults.DefaultRoute)]
public class CatalogWeaponController : ControllerBase
{
    private readonly ILogger<CatalogWeaponController> _logger;

    public CatalogWeaponController(ILogger<CatalogWeaponController> logger)
    {
        _logger = logger;
    }
}
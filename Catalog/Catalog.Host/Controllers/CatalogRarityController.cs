namespace Catalog.Host.Controllers;

[ApiController]
[Route(ComponentDefaults.DefaultRoute)]
public class CatalogRarityController : ControllerBase
{
    private readonly ILogger<CatalogRarityController> _logger;

    public CatalogRarityController(ILogger<CatalogRarityController> logger)
    {
        _logger = logger;
    }
}
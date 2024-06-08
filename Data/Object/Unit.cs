using Sitchensis.Data.Enum;

namespace Sitchensis.Data.Object;

public class Unit : Entity
{
    public required string Name { get; set; }
    public required string Symbol { get; set; }
    public required Position Position { get; set; }
}

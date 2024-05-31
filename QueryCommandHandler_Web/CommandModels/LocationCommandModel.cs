
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class LocationCommandModel
{
    public string Id { get; set; }
}

public static class LocationCommandModelExtensions
{
    public static Location ToDBLocation(this LocationCommandModel Location)
    {
        return new Location()
        {
        };
    }
}


using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class LocationCommandModel
{
    public int Id { get; set; }
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

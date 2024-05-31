
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class MapToQueryCommandModel
{
    public string Id { get; set; }
}

public static class MapToQueryCommandModelExtensions
{
    public static MapToQuery ToDBMapToQuery(this MapToQueryCommandModel MapToQuery)
    {
        return new MapToQuery()
        {
        };
    }
}

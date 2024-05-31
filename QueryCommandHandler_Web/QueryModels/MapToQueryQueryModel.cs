
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class MapToQueryQueryModel
        {
            public int Id { get; set; }
        }

        public static class MapToQueryQueryModelExtensions
        {
    public static MapToQueryQueryModel ToMapToQueryQueryModel(this MapToQuery? maptoquery)
    {
        return new MapToQueryQueryModel { Id = maptoquery.Id};
    }
        }
        
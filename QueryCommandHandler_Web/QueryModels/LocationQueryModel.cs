
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class LocationQueryModel
        {
            public int Id { get; set; }
        }

        public static class LocationQueryModelExtensions
        {
    public static LocationQueryModel ToLocationQueryModel(this Location? location)
    {
        return new LocationQueryModel { Id = 0};
    }
        }
        
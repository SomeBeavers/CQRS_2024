
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class BeaverQueryModel
        {
            public int Id { get; set; }
        }

        public static class BeaverQueryModelExtensions
        {
    public static BeaverQueryModel ToBeaverQueryModel(this Beaver? beaver)
    {
        return new BeaverQueryModel { Id = beaver.Id};
    }
        }
        
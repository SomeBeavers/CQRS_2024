
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class DeerQueryModel
        {
            public int Id { get; set; }
        }

        public static class DeerQueryModelExtensions
        {
    public static DeerQueryModel ToDeerQueryModel(this Deer? deer)
    {
        return new DeerQueryModel { Id = deer.Id};
    }
        }
        
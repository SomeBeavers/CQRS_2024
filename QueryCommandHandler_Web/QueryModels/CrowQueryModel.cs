
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class CrowQueryModel
        {
            public int Id { get; set; }
        }

        public static class CrowQueryModelExtensions
        {
    public static CrowQueryModel ToCrowQueryModel(this Crow? crow)
    {
        return new CrowQueryModel { Id = crow.Id};
    }
        }
        
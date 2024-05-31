
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class ConsequenceQueryModel
        {
            public int Id { get; set; }
        }

        public static class ConsequenceQueryModelExtensions
        {
    public static ConsequenceQueryModel ToConsequenceQueryModel(this Consequence? consequence)
    {
        return new ConsequenceQueryModel { Id = 0};
    }
        }
        
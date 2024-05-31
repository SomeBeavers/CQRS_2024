
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class NotMappedTextQueryModel
        {
            public int Id { get; set; }
        }

        public static class NotMappedTextQueryModelExtensions
        {
    public static NotMappedTextQueryModel ToNotMappedTextQueryModel(this NotMappedText? notmappedtext)
    {
        return new NotMappedTextQueryModel { Id = 0};
    }
        }
        
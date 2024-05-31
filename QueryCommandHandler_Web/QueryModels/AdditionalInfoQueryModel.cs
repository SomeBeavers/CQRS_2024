
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class AdditionalInfoQueryModel
        {
            public int Id { get; set; }
        }

        public static class AdditionalInfoQueryModelExtensions
        {
    public static AdditionalInfoQueryModel ToAdditionalInfoQueryModel(this AdditionalInfo? additionalinfo)
    {
        return new AdditionalInfoQueryModel { Id = additionalinfo.Id};
    }
        }
        
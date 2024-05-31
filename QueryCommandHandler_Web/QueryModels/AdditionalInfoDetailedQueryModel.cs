
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

        public class AdditionalInfoDetailedQueryModel
        {
            public int Id { get; set; }
        }

        public static class AdditionalInfoDetailedQueryModelExtensions
        {
    public static AdditionalInfoDetailedQueryModel ToAdditionalInfoDetailedQueryModel(this AdditionalInfoDetailed? additionalinfodetailed)
    {
        return new AdditionalInfoDetailedQueryModel { Id = additionalinfodetailed.Id};
    }
        }
        
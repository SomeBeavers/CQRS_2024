
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class AdditionalInfoDetailedCommandModel
{
    public string Id { get; set; }
}

public static class AdditionalInfoDetailedCommandModelExtensions
{
    public static AdditionalInfoDetailed ToDBAdditionalInfoDetailed(this AdditionalInfoDetailedCommandModel AdditionalInfoDetailed)
    {
        return new AdditionalInfoDetailed()
        {
        };
    }
}

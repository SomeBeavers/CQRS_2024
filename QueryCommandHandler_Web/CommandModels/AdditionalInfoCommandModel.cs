
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class AdditionalInfoCommandModel
{
    public string Id { get; set; }
}

public static class AdditionalInfoCommandModelExtensions
{
    public static AdditionalInfo ToDBAdditionalInfo(this AdditionalInfoCommandModel AdditionalInfo)
    {
        return new AdditionalInfo()
        {
        };
    }
}

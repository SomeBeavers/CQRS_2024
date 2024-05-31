
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class AdditionalInfoCommandModel
{
    public int Id { get; set; }
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


using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class NotMappedTextCommandModel
{
    public string Id { get; set; }
}

public static class NotMappedTextCommandModelExtensions
{
    public static NotMappedText ToDBNotMappedText(this NotMappedTextCommandModel NotMappedText)
    {
        return new NotMappedText()
        {
        };
    }
}

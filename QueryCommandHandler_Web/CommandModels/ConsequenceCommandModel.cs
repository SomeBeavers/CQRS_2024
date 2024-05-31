
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class ConsequenceCommandModel
{
    public string Id { get; set; }
}

public static class ConsequenceCommandModelExtensions
{
    public static Consequence ToDBConsequence(this ConsequenceCommandModel Consequence)
    {
        return new Consequence()
        {
        };
    }
}

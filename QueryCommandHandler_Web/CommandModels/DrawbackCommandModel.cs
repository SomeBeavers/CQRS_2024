
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class DrawbackCommandModel
{
    public string Id { get; set; }
}

public static class DrawbackCommandModelExtensions
{
    public static Drawback ToDBDrawback(this DrawbackCommandModel Drawback)
    {
        return new Drawback()
        {
        };
    }
}

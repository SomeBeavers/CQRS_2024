
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class DeerCommandModel
{
    public int Id { get; set; }
}

public static class DeerCommandModelExtensions
{
    public static Deer ToDBDeer(this DeerCommandModel Deer)
    {
        return new Deer()
        {
        };
    }
}

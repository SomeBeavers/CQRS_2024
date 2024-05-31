
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class CrowCommandModel
{
    public int Id { get; set; }
}

public static class CrowCommandModelExtensions
{
    public static Crow ToDBCrow(this CrowCommandModel Crow)
    {
        return new Crow()
        {
        };
    }
}

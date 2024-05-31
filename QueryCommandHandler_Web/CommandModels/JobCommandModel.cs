
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class JobCommandModel
{
    public int Id { get; set; }
}

public static class JobCommandModelExtensions
{
    public static Job ToDBJob(this JobCommandModel Job)
    {
        return new Job()
        {
        };
    }
}

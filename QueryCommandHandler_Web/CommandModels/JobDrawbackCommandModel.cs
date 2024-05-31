
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class JobDrawbackCommandModel
{
    public string Id { get; set; }
}

public static class JobDrawbackCommandModelExtensions
{
    public static JobDrawback ToDBJobDrawback(this JobDrawbackCommandModel JobDrawback)
    {
        return new JobDrawback()
        {
        };
    }
}

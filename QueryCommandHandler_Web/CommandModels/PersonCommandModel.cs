
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class PersonCommandModel
{
    public string Id { get; set; }
}

public static class PersonCommandModelExtensions
{
    public static Person ToDBPerson(this PersonCommandModel Person)
    {
        return new Person()
        {
        };
    }
}

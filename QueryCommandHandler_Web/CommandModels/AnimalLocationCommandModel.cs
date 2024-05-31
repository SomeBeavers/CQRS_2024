
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class AnimalLocationCommandModel
{
    public int Id { get; set; }
}

public static class AnimalLocationCommandModelExtensions
{
    public static AnimalLocation ToDBAnimalLocation(this AnimalLocationCommandModel AnimalLocation)
    {
        return new AnimalLocation()
        {
        };
    }
}

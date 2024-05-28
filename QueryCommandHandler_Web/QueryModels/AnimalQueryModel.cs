using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

public class AnimalQueryModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public static class AnimalQueryModelExtensions
{
    public static AnimalQueryModel ToAnimalQueryModel(this Animal? animal)
    {
        return new AnimalQueryModel { Id = animal.Id, Name = animal.Name ?? "Jane Doe" };
    }
}
using DatabaseLib.Model;

namespace QueryCommandHandler_Web.QueryModels;

public class AnimalQueryModel
{
    // BUG: why warning on set is unclear.
    public int Id { get; set; }
    public string Name { get; set; }
}

public static class AnimalQueryModelExtensions
{
    // BUG: this method is called from AddAnimalCommandCommandHandler and GetAnimalQueryHandler
    public static AnimalQueryModel ToAnimalQueryModel(this Animal? animal)
    {
        return new AnimalQueryModel { Id = animal.Id, Name = animal.Name ?? "Jane Doe" };
    }
}
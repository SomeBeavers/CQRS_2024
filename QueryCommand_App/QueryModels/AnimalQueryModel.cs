using DatabaseLib.Model;

namespace QueryCommand_App.QueryModels;

public class AnimalQueryModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// TODO: awesome suggestion by VS after `public static`, exactly what I wanted
public static class AnimalQueryModelExtensions
{
    // TODO: completion suggests method on new line with empty class
    public static AnimalQueryModel ToAnimalQueryModel(this Animal animal)
    {
        return new AnimalQueryModel { Id = animal.Id, Name = animal.Name };
    }
}
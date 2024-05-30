using DatabaseLib.Model;

namespace QueryCommandHandler_Web.CommandModels;

public class BeaverCommandModel
{
    public string Name { get; set; }
}

public static class BeaverCommandModelExtensions
{
    public static Beaver ToDBBeaver(this BeaverCommandModel beaver)
    {
        return new Beaver()
        {
            Name = beaver.Name,
            Age = 18,
            Fluffiness = FluffinessEnum.VeryFluffy,
            Size = 1
        };
    }
}


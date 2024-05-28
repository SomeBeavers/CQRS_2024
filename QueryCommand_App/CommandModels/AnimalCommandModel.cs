using CoreLib_Common.Model;

namespace QueryCommand_App.CommandModels;

public class AnimalCommandModel
{
    public string Name { get; set; }
}

public static class AnimalCommandModelExtensions
{
    public static Animal ToAnimal(this AnimalCommandModel animal)
    {
        return new Animal
        {
            // TODO: completion should suggest all properties 
            Name = animal.Name,
            Age = 18,
            //Clubs = null,
            //Grades = null,
            //Job = null,
            //JobId = null,
            //LovedBy = null,
            //HatedBy = null,
            //Food = null,
            IpAddress = null
        };
    }
}


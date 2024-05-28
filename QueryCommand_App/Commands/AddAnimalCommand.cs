using QueryCommand_App.CommandModels;

namespace QueryCommand_App.Commands;

public class AddAnimalCommand
{
    public void Execute(AnimalCommandModel animal)
    {
        var context = Helper.GetContext();
        context.Animals.Add(animal.ToAnimal());
        context.SaveChanges();
    }
}
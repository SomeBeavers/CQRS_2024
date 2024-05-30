using Castle.Components.DictionaryAdapter.Xml;
using JetBrains.Annotations;
using QueryCommand_App.CommandModels;

namespace QueryCommand_App.Commands;

public class AddAnimalCommand:Command
{
    public override void Execute(AnimalCommandModel animal)
    {
        var componentType = this.GetComponentType();
        var context = Helper.GetContext();
        context.Animals.Add(animal.ToAnimal());
        context.SaveChanges();
    }
}
[Command]
public abstract class Command
{
    public abstract void Execute(AnimalCommandModel animal);
}
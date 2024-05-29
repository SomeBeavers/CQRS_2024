using Castle.Components.DictionaryAdapter.Xml;
using DatabaseLib.Model;
using QueryCommand_App.CommandModels;

namespace QueryCommand_App.Commands;

public class UseQueryCommand
{
    public void Execute()
    {
        var context = Helper.GetContext();
        var componentType = this.GetComponentType();
        var addAnimalCommand = new AddAnimalCommand();
        addAnimalCommand.Execute(new AnimalCommandModel
        {
            Name = "Dog",
            Age = 1
        });
    }
}
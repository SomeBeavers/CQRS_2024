using Castle.Components.DictionaryAdapter.Xml;
using QueryCommand_App.CommandModels;
using QueryCommand_App.Commands;
using QueryCommand_App.Queries;

namespace QueryCommand_App;

// Used in Query only
public class UseCommandClass
{
    public void UseCommandMethod(out Command addAnimalCommand)
    {
        //string methodName = nameof(UseCommandQuery.Execute);
        var context = Helper.GetContext();
        var componentType = this.GetComponentType();
        addAnimalCommand = new AddAnimalCommand();
        addAnimalCommand.Execute(new AnimalCommandModel
        {
            Name = "Dog",
        });
    }
}
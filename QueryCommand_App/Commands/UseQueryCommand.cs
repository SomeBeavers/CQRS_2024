using Castle.Components.DictionaryAdapter.Xml;
using DatabaseLib.Model;
using QueryCommand_App.CommandModels;
using QueryCommand_App.Queries;
using QueryCommand_App.QueryModels;

namespace QueryCommand_App.Commands;

public class UseQueryCommand<T>: ICommand<T> where T: GetAnimalByIdQuery
{
    //public AnimalQueryModel Execute(GetAnimalByIdQuery query)
    //{
    //    var animalQueryModel = query.Execute(1);
        
    //    return animalQueryModel;
    //    //var context = Helper.GetContext();
    //    //var componentType = this.GetComponentType();
    //    //var addAnimalCommand = new AddAnimalCommand();
    //    //addAnimalCommand.Execute(new AnimalCommandModel
    //    //{
    //    //    Name = "Dog",
    //    //    Age = 1
    //    //});
    //}

    public AnimalQueryModel Execute(T query)
    {
        var animalQueryModel = query.Execute(1);
        
        return animalQueryModel;
    }
}

public interface ICommand<T>
{
    AnimalQueryModel Execute(T query);
}
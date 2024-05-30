using JetBrains.Annotations;
using QueryCommand_App.Queries;

namespace QueryCommand_App.Commands;

public class RemoveAnimal<T>(int id, T query):IGenericCommand<T> where T: INormalQuery
{
    public void Test(RemoveAnimalCommand tRemoveAnimalCommand)
    {
        tRemoveAnimalCommand.Test();
        query.MethodFromQueryInterface();

    }
}

public interface IGenericCommand<T>
{
}

public class RemoveAnimalCommand
{
    public void Test()
    {
    }
}
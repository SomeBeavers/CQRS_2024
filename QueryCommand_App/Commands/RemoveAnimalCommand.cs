using JetBrains.Annotations;
using QueryCommand_App.Queries;

namespace QueryCommand_App.Commands;

public class RemoveAnimalCommand<T>(int id, T query):IGenericCommand<T> where T: INormalQuery
{
    public void Test(TQuery tQuery)
    {
        tQuery.Test();
        query.MethodFromQueryInterface();

    }
}

public interface IGenericCommand<T>
{
}

public class TQuery
{
    public void Test()
    {
    }
}
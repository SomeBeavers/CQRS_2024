namespace QueryCommand_App.Queries;

public class GetBeaverQuery : INormalQuery
{
    //public void UseCommonMethod()
    //{
    //    Helper.GetComponentType();
    //}
    public void MethodFromQueryInterface()
    {
        throw new NotImplementedException();
    }
}

public interface INormalQuery : IQuery
{
    new void UseCommonMethod()
    {
        //Helper.GetComponentType();
    }

    void MethodFromQueryInterface();
}

public interface IQuery
{
    void UseCommonMethod()
    {
        Helper.GetComponentType();
    }
}
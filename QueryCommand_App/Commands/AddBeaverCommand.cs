using JetBrains.Annotations;
using QueryCommand_App.Queries;

namespace QueryCommand_App.Commands;

public class AddBeaverCommand
{
    //public void UseCommonMethod()
    //{
    //    Helper.GetComponentType();
    //}

    public void UseQueryMethod(GetBeaverQuery query)
    {
        ((INormalQuery)query).UseCommonMethod();
    }

    //public void UseQueryMethod2(INormalQuery query)
    //{
    //    query.UseCommonMethod();
    //}
}
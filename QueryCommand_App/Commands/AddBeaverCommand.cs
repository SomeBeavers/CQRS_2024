using JetBrains.Annotations;
using NLog;
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

    public void LoggingMethod()
    {
        var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(this);

        Logger logger = LogManager.GetCurrentClassLogger();
        logger.Info(serializedObject);
    }

    //public void UseQueryMethod2(INormalQuery query)
    //{
    //    query.UseCommonMethod();
    //}
}